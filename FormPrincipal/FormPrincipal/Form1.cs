using FormPrincipal.Clases.ActivoFijoModel;
using FormPrincipal.Forms;
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
    public partial class Form1 : Form
    {
        private FrmNuevo frmNuevo;
        private FrmVer frmVer;
        private FrmDepreciacion frmDepreciacion;
        private ActivoFijoModel activosFijos;

        public Form1()
        {
            InitializeComponent();
            activosFijos = new ActivoFijoModel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevo = new FrmNuevo();
            frmNuevo.activosFijos = activosFijos;
            frmNuevo.MdiParent = this;
            frmNuevo.Show();

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVer = new FrmVer();
            frmVer.ActivoFijos = activosFijos;
            frmVer.MdiParent = this;
            frmVer.Show();

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepreciacion = new FrmDepreciacion();
            frmDepreciacion.ActivoFijos = activosFijos;
            frmDepreciacion.MdiParent = this;
            frmDepreciacion.Show();

        }
    }
}
