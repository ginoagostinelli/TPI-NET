using Dominio.Model;
using WindowsForms;

namespace TPI_NET
{
    public partial class VisitaLista : Form
    {
        public VisitaLista()
        {
            InitializeComponent();
        }

        private void VisitaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VisitaDetalle visitaDetalle = new VisitaDetalle();

            Visita visitaNuevo = new Visita();

            visitaDetalle.Visita = visitaNuevo;

            visitaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            VisitaDetalle visitaDetalle = new VisitaDetalle();

            int id;

            id = this.SelectedItem().Id;

            Visita visita = await VisitaApiClient.GetAsync(id);

            visitaDetalle.EditMode = true;
            visitaDetalle.Visita = visita;

            visitaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await VisitaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            VisitaApiClient client = new VisitaApiClient();

            this.dgvLista.DataSource = null;
            this.dgvLista.DataSource = await VisitaApiClient.GetAllAsync();

            if (this.dgvLista.Rows.Count > 0)
            {
                this.dgvLista.Rows[0].Selected = true;
                this.btnEliminar.Enabled = true;
                this.btnModificar.Enabled = true;
            }
            else
            {
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }

        private Visita SelectedItem()
        {
            Visita visita;

            visita = (Visita)dgvLista.SelectedRows[0].DataBoundItem;

            return visita;
        }
    }
}
