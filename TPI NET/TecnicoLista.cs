using Dominio.Model;

namespace WindowsForms
{
    public partial class TecnicoLista : Form
    {
        public TecnicoLista()
        {
            InitializeComponent();
        }

        private void Tecnicos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            TecnicoDetalle tecnicoDetalle = new TecnicoDetalle();

            Tecnico tecnicoNuevo = new Tecnico();

            tecnicoDetalle.Tecnico = tecnicoNuevo;

            tecnicoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            TecnicoDetalle tecnicoDetalle = new TecnicoDetalle();

            int id;

            id = this.SelectedItem().Id;

            Tecnico tecnico = await TecnicoApiClient.GetAsync(id);

            tecnicoDetalle.EditMode = true;
            tecnicoDetalle.Tecnico = tecnico;

            tecnicoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await TecnicoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            TecnicoApiClient client = new TecnicoApiClient();
            this.eliminarButton.Enabled = false;
            this.modificarButton.Enabled = false;

            this.tecnicosDataGridView.DataSource = null;
            this.tecnicosDataGridView.DataSource = await TecnicoApiClient.GetAllAsync();

            if (this.tecnicosDataGridView.Rows.Count > 0)
            {
                this.tecnicosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Tecnico SelectedItem()
        {
            Tecnico tecnico;

            tecnico = (Tecnico)tecnicosDataGridView.SelectedRows[0].DataBoundItem;

            return tecnico;
        }


    }
}