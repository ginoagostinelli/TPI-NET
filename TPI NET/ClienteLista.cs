using Dominio.Model;
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteDetalle clienteDetalle = new ClienteDetalle();

            Cliente clienteNuevo = new Cliente();

            clienteDetalle.Cliente = clienteNuevo;

            clienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            ClienteDetalle clienteDetalle = new ClienteDetalle();

            int id;

            id = this.SelectedItem().Id;

            Cliente cliente = await ClienteApiClient.GetAsync(id);

            clienteDetalle.EditMode = true;
            clienteDetalle.Cliente = cliente;

            clienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await ClienteApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            ClienteApiClient client = new ClienteApiClient();
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;

            this.dgvLista.DataSource = null;
            this.dgvLista.DataSource = await ClienteApiClient.GetAllAsync();

            if (this.dgvLista.Rows.Count > 0)
            {
                this.dgvLista.Rows[0].Selected = true;
                this.btnEliminar.Enabled = true;
                this.btnModificar.Enabled = true;
            }
            else
            {
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }

        private Cliente SelectedItem()
        {
            Cliente cliente;

            cliente = (Cliente)dgvLista.SelectedRows[0].DataBoundItem;

            return cliente;
        }
    }
}
