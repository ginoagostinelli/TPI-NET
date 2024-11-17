using Dominio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NET.APIs;

namespace WindowsForms
{
    public partial class VisitaDetalle : Form
    {
        private Visita visita;
        private List<Material>? materiales = new List<Material>();
        private IEnumerable<TipoMaterial> tipos;
        private Rol rolSesion = new Rol();
        public Rol RolSesion
        {
            get { return rolSesion; }
            set
            {
                rolSesion = value;
            }
        }
        public Visita Visita
        {
            get { return visita; }
            set
            {
                visita = value;
                this.SetVisita();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        public VisitaDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            VisitaApiClient client = new VisitaApiClient();
            Visita auxiliar = null;

            if (this.ValidateVisita())
            {
                this.Visita.Descripcion = this.descripcionTextBox.Text;
                this.Visita.DebeVolver = this.volverCheckBox.Checked;
                this.Visita.Tecnico = (int)this.tecnicoComboBox.SelectedValue;
                this.Visita.Solicitud = 1;
                this.Visita.Fecha = DateTime.UtcNow;

                //this.Visita.Solicitud = this.direccionTextBox.Text;
                //this.Visita.Fecha = this.telefonoTextBox.Text;

                if (this.EditMode)
                {
                    await VisitaApiClient.UpdateAsync(this.Visita);
                    /*foreach (Material material in materiales)
                    {
                        material.Visita = this.Visita.Id;
                    }*/
                    await MaterialApiClient.AddListaAsync(materiales, this.Visita.Id);
                }
                else
                {
                    auxiliar = await VisitaApiClient.AddAsync(this.Visita);
                    /*foreach (Material material in materiales)
                    {
                        material.Visita = auxiliar.Id;
                    }*/
                    await MaterialApiClient.AddListaAsync(materiales, auxiliar.Id);
                }

                //await MaterialApiClient.AddListaAsync(materiales, this.Visita.Id);

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SetVisita()
        {
            this.tecnicoComboBox.DataSource = null;
            this.tecnicoComboBox.DataSource = await TecnicoApiClient.GetAllAsync();
            this.tecnicoComboBox.ValueMember = "Id";
            this.tecnicoComboBox.DisplayMember = "NombreMix";


            this.descripcionTextBox.Text = this.Visita.Descripcion;
            this.volverCheckBox.Checked = this.Visita.DebeVolver;
            this.tecnicoComboBox.SelectedValue = this.Visita.Tecnico;
            //this.direccionTextBox.Text = this.Visita.Solicitud;
            //this.telefonoTextBox.Text = this.Visita.Fecha;
        }

        private async void GetAllAndLoad()
        {
            
            this.agregarMaterialButton.Enabled = false;
            this.eliminarMaterialButton.Enabled = false;

            this.materialesGridView.DataSource = null;
            materiales = (await MaterialApiClient.GetVisitaAsync(this.Visita.Id)).ToList<Material>();
            tipos = await TipoMaterialApiClient.GetAllAsync();
            //this.materialesGridView.DataSource = materiales;
            this.materialesGridView.DataSource = (from m in materiales
                                                  join t in this.tipos
                                                  on m.Tipo equals t.Id
                                                  select new
                                                  {
                                                      Id = m.Id,
                                                      Descripcion = t.Descripcion,
                                                      Cantidad = m.Cantidad,

                                                  }).ToList();
            actualizaBotones();
        }

        private bool ValidateVisita()
        {
            bool isValid = true;


            isValid &= controlIsValid(descripcionTextBox, "La Descripcion es Requerida");
            isValid &= controlIsValid(tecnicoComboBox, "El Tecnico es Requerido");

            return isValid;
        }

        private bool controlIsValid(Control control, string errorMessage)
        {
            if (control.Text == string.Empty)
            {
                errorProvider.SetError(control, errorMessage);
                return false;
            }

            return true;
        }

        private void agregarMaterialbutton_Click(object sender, EventArgs e)
        {
            VisitaMaterialDetalle visitaMaterialDetalle = new VisitaMaterialDetalle();
            DialogResult resultado = visitaMaterialDetalle.ShowDialog();
            if ( resultado == DialogResult.OK)
            {
                materiales.Add(visitaMaterialDetalle.Material);
            }
            //this.GetAllAndLoad();
            this.materialesGridView.DataSource = null;
            this.materialesGridView.DataSource = (from m in materiales
                                                  join t in this.tipos
                                                  on m.Tipo equals t.Id
                                                  select new
                                                  {
                                                      Id = m.Id,
                                                      Descripcion = t.Descripcion,
                                                      Cantidad = m.Cantidad,

                                                  }).ToList();
            actualizaBotones();
        }

        private void VisitaDetalle_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
            //this.materialesGridView.Columns["Id"].Visible = false;
        }

        private async void eliminarMaterialButton_Click(object sender, EventArgs e)
        {
            int id = (int) materialesGridView.SelectedRows[0].Cells["Id"].Value;
            materiales.RemoveAll(r => r.Id == id);
            this.materialesGridView.DataSource = null;
            this.materialesGridView.DataSource = (from m in materiales
                                                  join t in this.tipos
                                                  on m.Tipo equals t.Id
                                                  select new
                                                  {
                                                      Id = m.Id,
                                                      Descripcion = t.Descripcion,
                                                      Cantidad = m.Cantidad,

                                                  }).ToList();
            actualizaBotones();

        }

        private void actualizaBotones()
        {
            if (this.materialesGridView.Rows.Count > 0)
            {
                this.agregarMaterialButton.Enabled = true;
                this.eliminarMaterialButton.Enabled = true;
            }
            else
            {
                this.agregarMaterialButton.Enabled = true;
                this.eliminarMaterialButton.Enabled = false;
            }
        }
    }
}
