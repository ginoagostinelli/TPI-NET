using Dominio.Model;
using System.Data;
using TPI_NET.APIs;
using WindowsForms;

namespace TPI_NET
{
    public partial class VisitaLista : Form
    {
        IEnumerable<Visita> visitas = null;
        private Rol rolSesion = new Rol();
        private Solicitud solicitud = new Solicitud();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }

        public Solicitud Solicitud
        {
            get { return solicitud; }
            set
            {
                solicitud = value;
            }
        }
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
            visitaDetalle.Solicitud = this.solicitud;

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
            visitaDetalle.Solicitud = this.solicitud;

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
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnAgregar.Enabled = false;
            this.visitas = await VisitaApiClient.GetAllAsync();
            IEnumerable<Tecnico> tecnicos = await TecnicoApiClient.GetAllAsync();

            this.dgvLista.DataSource = null;
            if (this.solicitud.Id == 0)
            {
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
            }
            else
            {
                this.dgvLista.DataSource = (from v in this.visitas
                                            join t in tecnicos
                                            on v.Tecnico equals t.Id
                                            where v.Solicitud == this.solicitud.Id
                                            select new
                                            {
                                                Id = v.Id,
                                                Descripcion = v.Descripcion,
                                                DebeVolver = v.DebeVolver,
                                                Fecha = v.Fecha,
                                                Tecnico = t.NombreMix,
                                            }).ToList();
            }

            if (this.dgvLista.Rows.Count > 0)
            {
                this.dgvLista.Rows[0].Selected = true;
                
            }
            else
            {
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }

            if (this.solicitud.Id == 0)
            {
                this.btnAgregar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }

            EjecutarRol();

        }

        private Visita? SelectedItem()
        {
            Visita? visita;

            visita = (from v in this.visitas
                        where v.Id == (int)dgvLista.SelectedRows[0].Cells["Id"].Value
                        select v).FirstOrDefault();

            return visita;
        }

        private void EjecutarRol()
        {
            if (this.rolSesion.VisitasAgregar) this.btnAgregar.Enabled = true;
            else this.btnAgregar.Enabled = false;

            if (this.rolSesion.VisitasModificar) this.btnModificar.Enabled = true;
            else this.btnModificar.Enabled = false;

            if (this.rolSesion.VisitasEliminar) this.btnEliminar.Enabled = true;
            else this.btnEliminar.Enabled = false;


        }
    }
}
