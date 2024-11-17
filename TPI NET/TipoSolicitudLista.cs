using Dominio.Model;
using TPI_NET.APIs;
using WindowsForms;

namespace TPI_NET
{
    public partial class TipoSolicitudLista : Form
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
        public TipoSolicitudLista()
        {
            InitializeComponent();
        }

        private void TipoSolicitudLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TipoSolicitudDetalle tipoSolicitudDetalle = new TipoSolicitudDetalle();

            TipoSolicitud tipoSolicitudNueva = new TipoSolicitud();

            tipoSolicitudDetalle.TipoSolicitud = tipoSolicitudNueva;

            tipoSolicitudDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            TipoSolicitudDetalle tipoSolicitudDetalle = new TipoSolicitudDetalle();

            int id;

            id = this.SelectedItem().Id;

            TipoSolicitud tipoSolicitud = await TipoSolicitudApiClient.GetAsync(id);

            tipoSolicitudDetalle.EditMode = true;
            tipoSolicitudDetalle.TipoSolicitud = tipoSolicitud;

            tipoSolicitudDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;
            string nombreTipoSolicitud = this.SelectedItem().Nombre;

            if (MessageBox.Show("¿Está seguro que desea eliminar \"" + nombreTipoSolicitud + "\"?", "Eliminar Tipo Solicitud Id: " + id, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await TipoSolicitudApiClient.DeleteAsync(id);
            }

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            TipoSolicitudApiClient tipoSolicitud = new TipoSolicitudApiClient();
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;

            this.dgvLista.DataSource = null;
            this.dgvLista.DataSource = await TipoSolicitudApiClient.GetAllAsync();

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

        private TipoSolicitud SelectedItem()
        {
            TipoSolicitud tipoSolicitud;

            tipoSolicitud = (TipoSolicitud) dgvLista.SelectedRows[0].DataBoundItem;

            return tipoSolicitud;
        }
    }
}
