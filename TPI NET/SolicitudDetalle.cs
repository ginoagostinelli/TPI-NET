using Dominio.Model;
using System.Data;
using TPI_NET;
using TPI_NET.APIs;


namespace WindowsForms
{
    public partial class SolicitudDetalle : Form
    {
        private Solicitud solicitud;
        private List<string> estadosSolicitud = new List<string> { "En Curso", "Cancelada", "Completada" };
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public Solicitud Solicitud
        {
            get { return solicitud; }
            set
            {
                solicitud = value;
                this.SetSolicitud();
            }
        }
        public bool EditMode { get; set; } = false;

        public SolicitudDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            SolicitudApiClient client = new SolicitudApiClient();

            if (this.ValidateSolicitud())
            {
                this.Solicitud.Estado = estadoBox.Text;
                this.Solicitud.Motivo = motivoBox.Text;
                this.Solicitud.Conclusion = conclusionBox.Text;
                this.Solicitud.Tipo = (int)tipoBox.SelectedValue;
                this.Solicitud.Cliente = (int)clienteBox.SelectedValue;

                this.Solicitud.Fecha = DateTime.Today;

                if (this.EditMode)
                {
                    await SolicitudApiClient.UpdateAsync(this.Solicitud);
                }
                else
                {
                    await SolicitudApiClient.AddAsync(this.Solicitud);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SetSolicitud()
        {
            this.estadoBox.Text = this.Solicitud.Estado;
            this.motivoBox.Text = this.Solicitud.Motivo;
            this.fechaBox.Text = DateTime.Today.ToString("dd-MM-yyyy");
            this.conclusionBox.Text = this.Solicitud.Conclusion;

            this.tipoBox.DataSource = null;
            this.tipoBox.DataSource = await TipoSolicitudApiClient.GetAllAsync();
            this.tipoBox.ValueMember = "Id";
            this.tipoBox.DisplayMember = "Nombre";


            this.clienteBox.DataSource = null;
            this.clienteBox.DataSource = await ClienteApiClient.GetAllAsync();
            this.clienteBox.ValueMember = "Id";
            this.clienteBox.DisplayMember = "NombreMix";
        }

        private bool ValidateSolicitud()
        {
            bool isValid = true;

            isValid &= textboxIsValid(estadoBox, "El Estado es Requerido");
            isValid &= textboxIsValid(motivoBox, "El Motivo es Requerido");
            isValid &= textboxIsValid(tipoBox, "El Tipo es Requerido");
            isValid &= textboxIsValid(clienteBox, "El Cliente es Requerido");

            return isValid;
        }

        private bool textboxIsValid(Control control, string errorMessage)
        {
            if (control.Text == string.Empty)
            {
                errorProvider.SetError(control, errorMessage);
                return false;
            }

            return true;
        }

        private void SolicitudDetalle_Load(object sender, EventArgs e)
        {
            estadoBox.DataSource = estadosSolicitud;
            if (this.solicitud.Id == 0)
            {
                this.visitasButton.Enabled = false;
            }
        }

        private void visitasButton_Click(object sender, EventArgs e)
        {
            VisitaLista visitaLista = new VisitaLista();
            visitaLista.RolSesion = rolSesion;
            visitaLista.Solicitud = this.solicitud;
            visitaLista.Show();
        }
    }
}
