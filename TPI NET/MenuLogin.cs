using Dominio.Model;
using TPI_NET.APIs;
using WindowsForms;

namespace TPI_NET
{
    public partial class MenuLogin : Form
    {
        Rol sesion = null;

        public Rol Sesion
        {
            get { return sesion; }
            
        }
        public MenuLogin()
        {
            InitializeComponent();
        }

        private async void ingresarButton_Click(object sender, EventArgs e)
        {
            this.ingresarButton.Enabled = false;
            Tecnico tecnicoLogin = new Tecnico();
            tecnicoLogin.Email = this.emailTextBox.Text;
            tecnicoLogin.Password = this.contraTextBox.Text;

            Tecnico tecnicoObtenido = await TecnicoApiClient.GetMailAsync(tecnicoLogin);
            if (tecnicoObtenido != null)
            {
                sesion = await RolApiClient.GetDescripcionAsync(tecnicoObtenido.Rol);
                invalidosLabel.Visible = false;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                invalidosLabel.Visible = true;
                this.ingresarButton.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
    }
}
