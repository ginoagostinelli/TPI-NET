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
            clienteLista.RolSesion = rolSesion;
            clienteLista.Show();
        }

        private void tecnicosButton_Click(object sender, EventArgs e)
        {
            TecnicoLista tecnicoLista = new TecnicoLista();
            tecnicoLista.RolSesion = rolSesion;
            tecnicoLista.Show();
        }

        private void solicitudesButton_Click(object sender, EventArgs e)
        {
            SolicitudLista solicitudLista = new SolicitudLista();
            solicitudLista.RolSesion = rolSesion;
            solicitudLista.Show();
        }

        private void tipoSolicitudesButton_Click(object sender, EventArgs e)
        {
            TipoSolicitudLista tipoSolicitudLista = new TipoSolicitudLista();
            tipoSolicitudLista.RolSesion = rolSesion;
            tipoSolicitudLista.Show();
        }

        private void visitasButton_Click(object sender, EventArgs e)
        {
            VisitaLista visitaLista = new VisitaLista();
            visitaLista.RolSesion = rolSesion;
            visitaLista.Show();
        }

        private void materialesButton_Click(object sender, EventArgs e)
        {
            TipoMaterialLista tipoMaterialLista = new TipoMaterialLista();
            tipoMaterialLista.RolSesion = rolSesion;
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

            rolLabel.Text = "Rol: " + rolSesion.Descripcion;

            SetButtonState(this.clientesButton, this.rolSesion.ClientesVer);
            SetButtonState(this.solicitudesButton, this.rolSesion.SolicitudesVer);
            //SetButtonState(this.visitasButton, this.rolSesion.VisitasVer);
            SetButtonState(this.tecnicosButton, this.rolSesion.TecnicosVer);
            SetButtonState(this.tipoSolicitudesButton, this.rolSesion.TiposSolicitudesVer);
            SetButtonState(this.tipoMaterialesButton, this.rolSesion.TiposMaterialesVer);
        }

        private void SetButtonState(Button button, bool canView)
        {
            button.Enabled = canView;
            button.Visible = canView;
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
