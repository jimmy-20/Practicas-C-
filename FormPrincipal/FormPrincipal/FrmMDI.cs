using FormPrincipal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FrmMDI : Form
    {
        private FrmDatos frmDatos;
        private FrmView frmView;
        private PersonasModel personas;
        public FrmMDI()
        {
            InitializeComponent();
            personas = new PersonasModel();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos = new FrmDatos();
            frmDatos.MdiParent = this;
            frmDatos.Personas = personas;
            frmDatos.Show();
        }

        private void registroDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmView = new FrmView();
            frmView.MdiParent = this;
            frmView.personas = personas;
            frmView.Show();
        }
    }
}
