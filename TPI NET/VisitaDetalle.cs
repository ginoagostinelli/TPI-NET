using Dominio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class VisitaDetalle : Form
    {
        private Visita visita;
        private List<Material>? materiales = new List<Material>();

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
                    foreach (Material material in materiales)
                    {
                        material.Visita = this.Visita.Id;
                    }
                }
                else
                {
                    auxiliar = await VisitaApiClient.AddAsync(this.Visita);
                    foreach (Material material in materiales)
                    {
                        material.Visita = auxiliar.Id;
                    }
                }

                await MaterialApiClient.AddListaAsync(materiales);

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
            //MaterialApiClient client = new TecnicoApiClient();
            //IEnumerable<Material> materialesObtenidos = await MaterialApiClient.GetVisitaAsync(this.Visita.Id);
            this.agregarMaterialButton.Enabled = false;
            this.eliminarMaterialButton.Enabled = false;

            this.materialesGridView.DataSource = null;
            materiales = (await MaterialApiClient.GetVisitaAsync(this.Visita.Id)).ToList<Material>();
            this.materialesGridView.DataSource = materiales;
           // MessageBox.Show(this.materialesGridView.Rows.Count.ToString(), "Question", MessageBoxButtons.YesNo);
            if (this.materialesGridView.Rows.Count > 0)
            {
                //this.tecnicosDataGridView.Rows[0].Selected = true;
                this.agregarMaterialButton.Enabled = true;
                this.eliminarMaterialButton.Enabled = true;
            }
            else
            {
                this.agregarMaterialButton.Enabled = true;
                this.eliminarMaterialButton.Enabled = false;
            }
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

            visitaMaterialDetalle.ShowDialog();
            //CODIGO PARA AGREGAR EL MATERIAL A LA LISTA DE MATERIALES
            materiales.Add(visitaMaterialDetalle.Material);
            //this.GetAllAndLoad();
            this.materialesGridView.DataSource = null;
            this.materialesGridView.DataSource = materiales;

        }

        private void VisitaDetalle_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarMaterialButton_Click(object sender, EventArgs e)
        {
            int id = (int) materialesGridView.SelectedRows[0].Cells[0].Value;
            materiales.RemoveAll(r => r.Id == id);
            this.materialesGridView.DataSource = null;
            this.materialesGridView.DataSource = materiales;

        }
    }
}
