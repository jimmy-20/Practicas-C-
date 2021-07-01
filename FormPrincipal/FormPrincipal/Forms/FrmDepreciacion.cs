using FormPrincipal.Clases.ActivoFijoModel;
using FormPrincipal.Clases.Depreciacion;
using FormPrincipal.Clases.Enums;
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
    public partial class FrmDepreciacion : Form
    {
        public ActivoFijoModel ActivoFijos { get; set; }
        private DataTable dt;
        public FrmDepreciacion()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void FrmDepreciacion_Load(object sender, EventArgs e)
        {
            cmbMetodoDepreciacion.Items.AddRange(Enum.GetValues(typeof(MetodoDepreciacion)).
                                                Cast<object>().ToArray());
            cmbMetodoDepreciacion.SelectedIndex = 0;
            //int index = cmbMetodoDepreciacion.SelectedIndex;
            //loadDepreciacion(index);
        }

        private void cmbMetodoDepreciacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox change = (ComboBox)sender;
            int index = change.SelectedIndex;
            loadDepreciacion(index);
        }

        private void loadDepreciacion(int index)
        {
            if (ActivoFijos.FindAll() == null)
            {
                return;
            }
            dt = null;
            dt = new DataTable();

            dt.Columns.Clear();
            dt.Rows.Clear();

            IDepreciacion depreciacion = Factory.GetInstance(Enum.GetValues(typeof(MetodoDepreciacion)).
                                         Cast<MetodoDepreciacion>().ToArray()[index]);
            dt.Columns.Add("Nombre");

            

            for (int i = 1 ; i<=ActivoFijos.Max(); i++)
            {
                dt.Columns.Add($"{i}");
            }

            dt.Rows.Clear();
            foreach(ActivoFijo af in ActivoFijos.FindAll())
            {
                DataRow row = dt.NewRow();
                row["Nombre"] = af.Nombre;

                decimal[] dep = depreciacion.calcular(af.VidaUtil, af.Costo, af.Salvamento);

                for (int i = 1; i <=ActivoFijos.Max(); i++)
                {
                    if (i > dep.Length)
                    {
                        continue;
                    }
                    row[$"{i}"] = dep[i - 1];
                    Console.WriteLine(dep[i-1]+ " ");

                    

                }

                dt.Rows.Add(row);
            }


            dgvDepreciacion.DataSource = dt;
        }
    }
}
