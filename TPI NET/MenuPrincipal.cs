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
    }
}
