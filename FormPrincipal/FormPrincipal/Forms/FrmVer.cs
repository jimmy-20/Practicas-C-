using FormPrincipal.Clases.ActivoFijoModel;
using FormPrincipal.Clases.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal.Forms
{
    public partial class FrmVer : Form
    {
        public ActivoFijoModel ActivoFijos;
        private DataTable dt;
        public FrmVer()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void FrmVer_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Tipo Activo Fijo");
            dt.Columns.Add("Vida util");
            dt.Columns.Add("Costo");
            dt.Columns.Add("Valor de salvamento");

            if (ActivoFijos.FindAll() == null)
            {
                return;
            }

            foreach(ActivoFijo af in ActivoFijos.FindAll())
            {
                DataRow row = dt.NewRow();
                row["Nombre"] = af.Nombre;
                row["Tipo Activo Fijo"] = af.TipoActivoFijo;
                row["Vida util"] = af.VidaUtil;
                row["Costo"] = af.Costo;
                row["Valor de salvamento"] = af.Salvamento;

                dt.Rows.Add(row);

            }

            dgvViews.DataSource = dt;
        }
    }
}
