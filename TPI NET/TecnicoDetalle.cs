using Dominio.Model;
using System.Text.RegularExpressions;
using TPI_NET.APIs;

namespace WindowsForms
{
    public partial class TecnicoDetalle : Form
    {
        private Tecnico tecnico;
        private List<string> roles = new List<string> { "Tecnico", "Supervisor" };
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public Tecnico Tecnico
        {
            get { return tecnico; }
            set
            {
                tecnico = value;
                this.SetTecnico();
            }
        }

        public bool EditMode { get; set; } = false;

        public TecnicoDetalle()
        {

            InitializeComponent();

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            TecnicoApiClient client = new TecnicoApiClient();

            if (this.ValidateTecnico())
            {
                this.Tecnico.Nombre = this.nombreTextBox.Text;
                this.Tecnico.Apellido = this.apellidoTextBox.Text;
                this.Tecnico.NombreMix = this.apellidoTextBox.Text + ", " + this.nombreTextBox.Text;
                this.Tecnico.Telefono = this.telefonoTextBox.Text;
                this.Tecnico.Email = this.emailTextBox.Text;
                this.Tecnico.Password = this.contraTextBox.Text;
                this.Tecnico.Rol = (string)this.rolComboBox.SelectedValue;
                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await TecnicoApiClient.UpdateAsync(this.Tecnico);
                }
                else
                {
                    await TecnicoApiClient.AddAsync(this.Tecnico);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetTecnico()
        {
            this.nombreTextBox.Text = this.Tecnico.Nombre;
            this.apellidoTextBox.Text = this.Tecnico.Apellido;
            this.telefonoTextBox.Text = this.Tecnico.Telefono;
            this.rolComboBox.SelectedValue = this.Tecnico.Rol;
            this.emailTextBox.Text = this.Tecnico.Email;
            this.contraTextBox.Text = this.Tecnico.Password;
        }

        private bool ValidateTecnico()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);
            /*if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "El Apellido es Requerido");
            }

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }*/


            isValid &= controlIsValid(nombreTextBox, "El Nombre es Requerido");
            isValid &= controlIsValid(apellidoTextBox, "El Apellido es Requerido");
            isValid &= controlIsValid(telefonoTextBox, "El Telefono es Requerido");
            isValid &= controlIsValid(emailTextBox, "El e-Mail es Requerido");
            isValid &= controlIsValid(contraTextBox, "La contraseña es Requerida");
            isValid &= controlIsValid(rolComboBox, "El Rol es Requerido");

            string password = contraTextBox.Text;

            if (password.Length < 6 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"\d"))
            {
                errorProvider.SetError(contraTextBox, "La contraseña debe incluir: \n" +
                    "- Al menos 6 caracteres.\n" +
                    "- Al menos una letra mayúscula.\n" +
                    "- Al menos una letra minúscula.\n" +
                    "- Al menos un número.");
                isValid &= false;
            }

            string email = emailTextBox.Text;

            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(emailTextBox, "El email proporcionado no tiene un formato válido.");
                isValid &= false;
            }


            return isValid;
        }

        private bool controlIsValid(Control control, string errorMessage)
        {
            if (control.Text == string.Empty)
            {
                errorProvider.SetError(control, errorMessage);
                return false;
            }

            return true;
        }

        private void TecnicoDetalle_Load(object sender, EventArgs e)
        {
            rolComboBox.DataSource = roles;
        }
    }
}
