using Dominio.Model;
using TPI_NET.APIs;

namespace WindowsForms
{
    public partial class TipoMaterialLista : Form
    {
        public TipoMaterialLista()
        {
            InitializeComponent();
        }

        private void Tecnicos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            TipoMaterialDetalle tipoMaterialDetalle = new TipoMaterialDetalle();

            TipoMaterial tipoMaterialNuevo = new TipoMaterial();

            tipoMaterialDetalle.TipoMaterial = tipoMaterialNuevo;

            tipoMaterialDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            TipoMaterialDetalle tipoMaterialDetalle = new TipoMaterialDetalle();

            int id;

            id = this.SelectedItem().Id;

            TipoMaterial tipoMaterial = await TipoMaterialApiClient.GetAsync(id);

            tipoMaterialDetalle.EditMode = true;
            tipoMaterialDetalle.TipoMaterial = tipoMaterial;

            tipoMaterialDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            string descripcionMaterial;

            id = this.SelectedItem().Id;
            descripcionMaterial = this.SelectedItem().Descripcion;

            if (MessageBox.Show("¿Está seguro que desea eliminar \"" + descripcionMaterial + "\"?", "Eliminar material Id: " + id, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await TipoMaterialApiClient.DeleteAsync(id);
            }

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            TipoMaterialApiClient client = new TipoMaterialApiClient();
            this.eliminarButton.Enabled = false;
            this.modificarButton.Enabled = false;

            this.tipoMaterialDataGridView.DataSource = null;
            this.tipoMaterialDataGridView.DataSource = await TipoMaterialApiClient.GetAllAsync();

            if (this.tipoMaterialDataGridView.Rows.Count > 0)
            {
                this.tipoMaterialDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private TipoMaterial SelectedItem()
        {
            TipoMaterial tipoMaterial;

            tipoMaterial = (TipoMaterial)tipoMaterialDataGridView.SelectedRows[0].DataBoundItem;

            return tipoMaterial;
        }


    }
}