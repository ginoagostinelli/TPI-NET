﻿using Dominio.Model;
using TPI_NET.APIs;

namespace WindowsForms
{
    public partial class ClienteDetalle : Form
    {
        private Cliente cliente;
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set
            {
                cliente = value;
                this.SetCliente();
            }
        }

        public bool EditMode { get; set; } = false;

        public ClienteDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ClienteApiClient client = new ClienteApiClient();

            if (this.ValidateCliente())
            {
                this.Cliente.Nombre = nombreTextBox.Text;
                this.Cliente.Apellido = apellidoTextBox.Text;
                this.Cliente.RazonSocial = razonTextBox.Text;
                this.Cliente.Direccion = direccionTextBox.Text;
                this.Cliente.Telefono = telefonoTextBox.Text;


                if (this.EditMode)
                {
                    await ClienteApiClient.UpdateAsync(this.Cliente);
                }
                else
                {
                    await ClienteApiClient.AddAsync(this.Cliente);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCliente()
        {
            this.nombreTextBox.Text = this.Cliente.Nombre;
            this.apellidoTextBox.Text = this.Cliente.Apellido;
            this.razonTextBox.Text = this.Cliente.RazonSocial;
            this.direccionTextBox.Text = this.Cliente.Direccion;
            this.telefonoTextBox.Text = this.Cliente.Telefono;
        }

        private bool ValidateCliente()
        {
            bool isValid = true;


            isValid &= textboxIsValid(nombreTextBox, "El Nombre es Requerido");
            isValid &= textboxIsValid(apellidoTextBox, "El Apellido es Requerido");
            isValid &= textboxIsValid(direccionTextBox, "La Direccion es Requerida");
            isValid &= textboxIsValid(telefonoTextBox, "El Teléfono es Requerido");
            

            return isValid;
        }

        private bool textboxIsValid(TextBox textbox, string errorMessage)
        {
            if (textbox.Text == string.Empty)
            {
                errorProvider.SetError(textbox, errorMessage);
                return false;
            }

            return true;
        }
    }
}
