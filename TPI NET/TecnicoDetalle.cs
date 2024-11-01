using Dominio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class TecnicoDetalle : Form
    {
        private Tecnico tecnico;
        List<string> roles = new List<string> { "Tecnico", "Supervisor" };
        public Tecnico Tecnico
        {
            get { return tecnico; }
            set
            {
                tecnico = value;
                this.SetTecnico();
            }
        }

        //Probablemente un Enum seria mas apropiado        
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


            isValid &= textboxIsValid(nombreTextBox, "El Nombre es Requerido");
            isValid &= textboxIsValid(apellidoTextBox, "El Apellido es Requerido");
            isValid &= textboxIsValid(telefonoTextBox, "El Telefono es Requerido");
            isValid &= textboxIsValid(emailTextBox, "El e-Mail es Requerido");
            isValid &= textboxIsValid(contraTextBox, "La contraseña es Requerida");
            isValid &= textboxIsValid(rolComboBox, "El Rol es Requerido");


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

        private void TecnicoDetalle_Load(object sender, EventArgs e)
        {
            rolComboBox.DataSource = roles;
        }
    }
}
