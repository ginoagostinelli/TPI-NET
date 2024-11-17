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
    public partial class VisitaMaterialDetalle : Form
    {
        private Material material = new Material();
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public Material Material
        {
            get { return material; }
            
        }

       

        public VisitaMaterialDetalle()
        {

            InitializeComponent();

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
      

            if (this.ValidateMaterialDetalle())
            {
                this.material.Cantidad = (int)this.cantidadUpDown.Value;
                this.material.Tipo = (int) this.tipoComboBox.SelectedValue;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SetVisitaMaterial()
        {
            this.tipoComboBox.DataSource = null;
            this.tipoComboBox.DataSource = await TipoMaterialApiClient.GetAllAsync();
            this.tipoComboBox.ValueMember = "Id";
            this.tipoComboBox.DisplayMember = "Descripcion";


        }

        private void VisitaMaterialDetalle_Load(object sender, EventArgs e)
        {
            this.SetVisitaMaterial();
        }

        private bool ValidateMaterialDetalle()
        {
            bool isValid = true;

            errorProvider.SetError(tipoComboBox, string.Empty);
            errorProvider.SetError(cantidadUpDown, string.Empty);
            if (this.tipoComboBox.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(tipoComboBox, "El Tipo de Material es Requerido");
            }

            if ((int)this.cantidadUpDown.Value == 0)
            {
                isValid = false;
                errorProvider.SetError(cantidadUpDown, "La Cantidad es Requerida");
            }



            return isValid;
        }

    }
}
