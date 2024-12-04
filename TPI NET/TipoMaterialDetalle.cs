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
    public partial class TipoMaterialDetalle : Form
    {
        private TipoMaterial tipoMaterial;
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public TipoMaterial TipoMaterial
        {
            get { return tipoMaterial; }
            set
            {
                tipoMaterial = value;
                this.SetTipoMaterial();
            }
        }
    
        public bool EditMode { get; set; } = false;

        public TipoMaterialDetalle()
        {

            InitializeComponent();

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            TipoMaterialApiClient client = new TipoMaterialApiClient();

            if (this.ValidateTipoMaterial())
            {
                this.TipoMaterial.Descripcion = this.descripcionTextBox.Text;



                if (this.EditMode)
                {
                    await TipoMaterialApiClient.UpdateAsync(this.TipoMaterial);
                }
                else
                {
                    await TipoMaterialApiClient.AddAsync(this.TipoMaterial);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetTipoMaterial()
        {
            this.descripcionTextBox.Text = this.TipoMaterial.Descripcion;
        }

        private bool ValidateTipoMaterial()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);
         
            isValid &= controlIsValid(descripcionTextBox, "La Descripcion es Requerida");

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
    }
}
