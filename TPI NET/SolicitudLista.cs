using Dominio.Model;
using TPI_NET.APIs;

namespace WindowsForms
{
    public partial class SolicitudLista : Form
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
        public SolicitudLista()
        {
            InitializeComponent();
        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            SolicitudDetalle solicitudDetalle = new SolicitudDetalle();

            Solicitud solicitudNuevo = new Solicitud();

            solicitudDetalle.Solicitud = solicitudNuevo;
            solicitudDetalle.RolSesion = rolSesion;

            solicitudDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            SolicitudDetalle solicitudDetalle = new SolicitudDetalle();

            int id;

            id = this.SelectedItem().Id;

            Solicitud solicitud = await SolicitudApiClient.GetAsync(id);

            solicitudDetalle.EditMode = true;
            solicitudDetalle.Solicitud = solicitud;
            solicitudDetalle.RolSesion = rolSesion;

            solicitudDetalle.ShowDialog();

            this.GetAllAndLoad();
        }


        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;

            if (MessageBox.Show("¿Está seguro que desea eliminar solicitud (Id: \"" + id + "\")?", "Eliminar Solicitud Id: " + id, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await SolicitudApiClient.DeleteAsync(id);
            }

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            this.eliminarButton.Enabled = false;
            this.modificarButton.Enabled = false;
            this.agregarButton.Enabled = false;

            this.solicitudesDataGridView.DataSource = null;
            this.solicitudesDataGridView.DataSource = await SolicitudApiClient.GetAllAsync();

            EjecutarRol();

            if (this.solicitudesDataGridView.Rows.Count > 0)
            {
                this.solicitudesDataGridView.Rows[0].Selected = true;
                
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Solicitud SelectedItem()
        {
            Solicitud solicitud;

            solicitud = (Solicitud)solicitudesDataGridView.SelectedRows[0].DataBoundItem;

            return solicitud;
        }
        private void EjecutarRol()
        {

            if (this.rolSesion.SolicitudesAgregar) this.agregarButton.Enabled = true;
            else this.agregarButton.Enabled = false;

            if (this.rolSesion.SolicitudesModificar || this.rolSesion.SolicitudesVer) this.modificarButton.Enabled = true;
            else this.modificarButton.Enabled = false;

            if (this.rolSesion.SolicitudesEliminar) this.eliminarButton.Enabled = true;
            else this.eliminarButton.Enabled = false;

            if (this.rolSesion.SolicitudesVer && !this.rolSesion.SolicitudesModificar) this.modificarButton.Text = "Ver";


        }

    }
}