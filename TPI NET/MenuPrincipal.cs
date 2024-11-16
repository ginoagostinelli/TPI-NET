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
using WindowsForms;

namespace TPI_NET
{
    public partial class MenuPrincipal : Form
    {
        Rol rolSesion = new Rol();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            ClienteLista clienteLista = new ClienteLista();
            clienteLista.Show();
        }

        private void tecnicosButton_Click(object sender, EventArgs e)
        {
            TecnicoLista tecnicoLista = new TecnicoLista();
            tecnicoLista.Show();
        }

        private void solicitudesButton_Click(object sender, EventArgs e)
        {
            SolicitudLista solicitudLista = new SolicitudLista();
            solicitudLista.Show();
        }

        private void tipoSolicitudesButton_Click(object sender, EventArgs e)
        {
            TipoSolicitudLista tipoSolicitudLista = new TipoSolicitudLista();
            tipoSolicitudLista.Show();
        }

        private void visitasButton_Click(object sender, EventArgs e)
        {
            VisitaLista visitaLista = new VisitaLista();
            visitaLista.Show();
        }

        private void materialesButton_Click(object sender, EventArgs e)
        {
            TipoMaterialLista tipoMaterialLista = new TipoMaterialLista();
            tipoMaterialLista.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            MenuLogin login = new MenuLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                this.rolSesion = login.Sesion;
            }
            else
            {
                Application.Exit();
            }

            this.EjecutarRol();

        }

        private void EjecutarRol()
        {
            if (this.rolSesion.ClientesVer) this.clientesButton.Enabled = true;
            else this.clientesButton.Enabled = false;

            if (this.rolSesion.SolicitudesVer) this.solicitudesButton.Enabled = true;
            else this.solicitudesButton.Enabled = false;

            if (this.rolSesion.VisitasVer) this.visitasButton.Enabled = true;
            else this.visitasButton.Enabled = false;

            if (this.rolSesion.TecnicosVer) this.tecnicosButton.Enabled = true;
            else this.tecnicosButton.Enabled = false;

            if (this.rolSesion.TiposSolicitudesVer) this.tipoSolicitudesButton.Enabled = true;
            else this.tipoSolicitudesButton.Enabled = false;

            if (this.rolSesion.TiposMaterialesVer) this.tipoMaterialesButton.Enabled = true;
            else this.tipoMaterialesButton.Enabled = false;
        }
    }
}
