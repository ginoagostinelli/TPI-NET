using Dominio.Model;
using TPI_NET.APIs;

namespace WindowsForms
{
    public partial class TecnicoLista : Form
    {
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public TecnicoLista()
        {
            InitializeComponent();
        }

        private void Tecnicos_Load(object sender, EventArgs e)
        {
            EjecutarRol();
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
            string nombreMixTecnico;

            id = this.SelectedItem().Id;
            nombreMixTecnico = this.SelectedItem().NombreMix;
            if (MessageBox.Show("¿Está seguro que desea eliminar el técnico: \"" + nombreMixTecnico + "\"?", "Eliminar técnico Id: " + id, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await TecnicoApiClient.DeleteAsync(id);
            }
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            this.eliminarButton.Enabled = false;
            this.modificarButton.Enabled = false;
            this.agregarButton.Enabled = false;

            this.tecnicosDataGridView.DataSource = null;
            this.tecnicosDataGridView.DataSource = await TecnicoApiClient.GetAllAsync();
            this.tecnicosDataGridView.Columns["Password"].Visible = false;

            EjecutarRol();

            if (this.tecnicosDataGridView.Rows.Count > 0)
            {
                this.tecnicosDataGridView.Rows[0].Selected = true;
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

        private void EjecutarRol()
        {
            if (this.rolSesion.TecnicosAgregar) this.agregarButton.Enabled = true;
            else this.agregarButton.Enabled = false;

            if (this.rolSesion.TecnicosModificar) this.modificarButton.Enabled = true;
            else this.modificarButton.Enabled = false;

            if (this.rolSesion.TecnicosEliminar) this.eliminarButton.Enabled = true;
            else this.eliminarButton.Enabled = false;


        }

    }
}