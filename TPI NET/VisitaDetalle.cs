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
    public partial class VisitaDetalle : Form
    {
        private Visita visita;

        public Visita Visita
        {
            get { return visita; }
            set
            {
                visita = value;
                this.SetVisita();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        public VisitaDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            VisitaApiClient client = new VisitaApiClient();

            if (this.ValidateVisita())
            {
                this.Visita.Descripcion = descripcionTextBox.Text;
                this.Visita.DebeVolver = apellidoTextBox.Text;
                this.Visita.Tecnico = razonTextBox.Text;
                this.Visita.Solicitud = direccionTextBox.Text;
                this.Visita.Fecha = telefonoTextBox.Text;

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await VisitaApiClient.UpdateAsync(this.Visita);
                }
                else
                {
                    await VisitaApiClient.AddAsync(this.Visita);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetVisita()
        {
            this.descripcionTextBox.Text = this.Visita.Descripcion;
            this.apellidoTextBox.Text = this.Visita.DebeVolver;
            this.razonTextBox.Text = this.Visita.Tecnico;
            this.direccionTextBox.Text = this.Visita.Solicitud;
            this.telefonoTextBox.Text = this.Visita.Fecha;
        }

        private bool ValidateVisita()
        {
            bool isValid = true;


            isValid &= textboxIsValid(descripcionTextBox, "El Nombre es Requerido");
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
