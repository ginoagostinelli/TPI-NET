using Dominio.Model;
using System.Linq;
using System.Windows.Forms;
using TPI_NET.APIs;
using WindowsForms;


namespace TPI_NET
{
    public partial class ClienteLista : Form
    {
        private Rol rolSesion = new Rol();
        private IEnumerable<Cliente> clientes;
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
            
            clientes = await ClienteApiClient.GetAllAsync();
            this.dgvLista.DataSource = clientes;

            this.dgvLista.Columns["Id"].Visible = false;
            this.dgvLista.Columns["Nombre"].Visible = false;
            this.dgvLista.Columns["Apellido"].Visible = false;

            this.dgvLista.Columns["NombreMix"].DisplayIndex = 0;
            this.dgvLista.Columns["RazonSocial"].DisplayIndex = 1;
            this.dgvLista.Columns["Direccion"].DisplayIndex = 2;
            this.dgvLista.Columns["Telefono"].DisplayIndex = 3;


            this.dgvLista.Columns["NombreMix"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void busquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            
            List<Cliente> clientesFiltrados = (from c in clientes
                                               where (c.NombreMix.Contains(this.busquedaTextBox.Text, StringComparison.OrdinalIgnoreCase)
                                               || c.RazonSocial.Contains(this.busquedaTextBox.Text, StringComparison.OrdinalIgnoreCase)
                                               || c.Direccion.Contains(this.busquedaTextBox.Text, StringComparison.OrdinalIgnoreCase)
                                               || c.Telefono.Contains(this.busquedaTextBox.Text, StringComparison.OrdinalIgnoreCase))
                                                select c).ToList();

            this.dgvLista.DataSource = clientesFiltrados;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.busquedaTextBox.Clear();
            GetAllAndLoad();
        }
    }
}
