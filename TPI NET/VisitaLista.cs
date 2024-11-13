using Dominio.Model;
using System.Data;
using TPI_NET.APIs;
using WindowsForms;

namespace TPI_NET
{
    public partial class VisitaLista : Form
    {
        IEnumerable<Visita> visitas = null;
        public VisitaLista()
        {
            InitializeComponent();
        }

        private void VisitaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VisitaDetalle visitaDetalle = new VisitaDetalle();

            Visita visitaNuevo = new Visita();

            visitaDetalle.Visita = visitaNuevo;

            visitaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            VisitaDetalle visitaDetalle = new VisitaDetalle();

            int id;

            id = this.SelectedItem().Id;

            Visita visita = await VisitaApiClient.GetAsync(id);

            visitaDetalle.EditMode = true;
            visitaDetalle.Visita = visita;

            visitaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            List<Material> materiales = new List<Material>();
            id = this.SelectedItem().Id;
            if(MessageBox.Show("¿Está seguro que desea eliminar la visita Id: " + id + "?", "Eliminar visita Id: " + id, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await VisitaApiClient.DeleteAsync(id);
                await MaterialApiClient.AddListaAsync(materiales, id);
            }
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            //VisitaApiClient client = new VisitaApiClient();
            //TecnicoApiClient tecnicoClient = new TecnicoApiClient();
            this.visitas = await VisitaApiClient.GetAllAsync();
            IEnumerable<Tecnico> tecnicos = await TecnicoApiClient.GetAllAsync();

            this.dgvLista.DataSource = null;
            this.dgvLista.DataSource = (from v in this.visitas
                                        join t in tecnicos
                                        on v.Tecnico equals t.Id
                                        select new
                                        {
                                            Id = v.Id,
                                            Descripcion = v.Descripcion,
                                            DebeVolver = v.DebeVolver,
                                            Fecha = v.Fecha,
                                            Tecnico = t.NombreMix,
                                        }).ToList();
            
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

        private Visita? SelectedItem()
        {
            Visita? visita;

            //visita = (Visita)dgvLista.SelectedRows[0].DataBoundItem;
            visita = (from v in this.visitas
                        where v.Id == (int)dgvLista.SelectedRows[0].Cells["Id"].Value
                        select v).FirstOrDefault();

            return visita;
        }
    }
}
