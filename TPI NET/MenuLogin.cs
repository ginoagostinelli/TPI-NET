using Dominio.Model;
using TPI_NET.APIs;
using WindowsForms;

namespace TPI_NET
{
    public partial class MenuLogin : Form
    {
        Tecnico sesion = null;
        public MenuLogin()
        {
            InitializeComponent();
        }

        private async void ingresarButton_Click(object sender, EventArgs e)
        {
            this.ingresarButton.Enabled = false;
            this.sesion = new Tecnico();
            this.sesion.Email = this.emailTextBox.Text;
            this.sesion.Password = this.contraTextBox.Text;

            Tecnico tecnico = await TecnicoApiClient.GetMailAsync(this.sesion);
            if (tecnico != null)
            {
                sesion = tecnico;
                invalidosLabel.Visible = false;
                MessageBox.Show("Rol obtenido: \"" + tecnico.Rol + "\"", "Tecnico obtenido", MessageBoxButtons.YesNo);

            }
            else
            {
                sesion = null;
                invalidosLabel.Visible = true;
                this.ingresarButton.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
