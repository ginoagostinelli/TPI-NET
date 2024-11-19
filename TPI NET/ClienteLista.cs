using Dominio.Model;
using TPI_NET.APIs;
using WindowsForms;

namespace TPI_NET
{
    public partial class ClienteLista : Form
    {
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public ClienteLista()
        {
            InitializeComponent();
        }

        private void ClienteLista_Load(object sender, EventArgs e)
        {
            EjecutarRol();
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
            int id = this.SelectedItem().Id;
            string nombreMix = this.SelectedItem().NombreMix;

            if (MessageBox.Show("¿Está seguro que desea eliminar el cliente: \"" + nombreMix + "\"?", "Eliminar cliente Id: " + id, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await ClienteApiClient.DeleteAsync(id);
            }

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnAgregar.Enabled = false;

            this.dgvLista.DataSource = null;
            this.dgvLista.DataSource = await ClienteApiClient.GetAllAsync();

            EjecutarRol();
            if (this.dgvLista.Rows.Count > 0)
            {
                this.dgvLista.Rows[0].Selected = true;
                
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

        private void EjecutarRol()
        {
            if (this.rolSesion.ClientesAgregar) this.btnAgregar.Enabled = true;
            else this.btnAgregar.Enabled = false;

            if (this.rolSesion.ClientesModificar) this.btnModificar.Enabled = true;
            else this.btnModificar.Enabled = false;

            if (this.rolSesion.ClientesEliminar) this.btnEliminar.Enabled = true;
            else this.btnEliminar.Enabled = false;

            
        }
    }
}
