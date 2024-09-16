using WindowsForms;

namespace TPI_NET
{
    public partial class ClienteLista : Form
    {
        public ClienteLista()
        {
            InitializeComponent();
        }

        private void ClienteLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            ClienteApiClient client = new ClienteApiClient();

            this.dgvLista.DataSource = null;
            this.dgvLista.DataSource = await ClienteApiClient.GetAllAsync();

            if (this.dgvLista.Rows.Count > 0)
            {
                this.dgvLista.Rows[0].Selected = true;
                //this.eliminarButton.Enabled = true;
                //this.modificarButton.Enabled = true;
            }
            else
            {
                //this.eliminarButton.Enabled = false;
                //this.modificarButton.Enabled = false;
            }
        }
    }
}
