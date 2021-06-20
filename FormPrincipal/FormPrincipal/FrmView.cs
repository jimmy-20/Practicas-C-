using FormPrincipal.Clases;
using FormPrincipal.Poco;
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
    
    public partial class FrmView : Form
    {
        public PersonasModel personas { get; set; }
        private DataTable dt;
        public FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Nacionalidad");

            if (personas.FindAll() == null)
            {
                return;
            }

            if (personas.FindAll().Length == 0 )
            {
                return;
            }

            

            foreach (Persona p in personas.FindAll())
            {
                DataRow dr = dt.NewRow();
                dr["Nombre"] = p.Nombre;
                dr["Apellidos"] = p.Apellidos;
                dr["Edad"] = p.Edad;
                dr["Sexo"] = p.Sexo;
                dr["Nacionalidad"] = p.Nacionalidad;
                dt.Rows.Add(dr);
            }

            dgvPersonas.DataSource = dt;
        }


    }
}
