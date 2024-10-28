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
                this.Tecnico.Nombre = nombreTextBox.Text;

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
            //this.telefonoTextBox.Text = this.Tecnico.Rol;
        }

        private bool ValidateTecnico()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "El Nombre es Requerido");
            }

            return isValid;
        }

        private void TecnicoDetalle_Load(object sender, EventArgs e)
        {
            rolComboBox.DataSource = roles;
        }
    }
}
