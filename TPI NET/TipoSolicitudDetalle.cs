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
using TPI_NET.APIs;

namespace WindowsForms
{
    public partial class TipoSolicitudDetalle : Form
    {
        private TipoSolicitud tipoSolicitud;
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public TipoSolicitud TipoSolicitud
        {
            get { return tipoSolicitud; }
            set
            {
                tipoSolicitud = value;
                this.SetSolicitud();
            }
        }     
        public bool EditMode { get; set; } = false;

        public TipoSolicitudDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            TipoSolicitudApiClient client = new TipoSolicitudApiClient();

            if (this.ValidateSolicitud())
            {
                this.TipoSolicitud.Nombre = nombreTextBox.Text;
                this.TipoSolicitud.Descripcion = descripcionTextBox.Text;

                if (this.EditMode)
                {
                    await TipoSolicitudApiClient.UpdateAsync(this.TipoSolicitud);
                }
                else
                {
                    await TipoSolicitudApiClient.AddAsync(this.TipoSolicitud);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetSolicitud()
        {
            this.nombreTextBox.Text = this.TipoSolicitud.Nombre;
            this.descripcionTextBox.Text = this.TipoSolicitud.Descripcion;
        }

        private bool ValidateSolicitud()
        {
            bool isValid = true;


            isValid &= textboxIsValid(nombreTextBox, "El Nombre es Requerido");
            isValid &= textboxIsValid(descripcionTextBox, "La descripcion es Requerida");

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
