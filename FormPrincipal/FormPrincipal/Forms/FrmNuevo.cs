using FormPrincipal.Clases.ActivoFijoModel;
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
    public partial class FrmNuevo : Form
    {
        public ActivoFijoModel activosFijos { get; set; }
        public FrmNuevo()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
            cmbTipoActivoFijo.Items.AddRange(Enum.GetValues(typeof(TipoActivoFijo)).Cast<object>().ToArray());
            cmbTipoActivoFijo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int index = cmbTipoActivoFijo.SelectedIndex;

            TipoActivoFijo tipoActivoFijo = (TipoActivoFijo)Enum.GetValues(typeof(TipoActivoFijo)).GetValue(index);

            int vida = Convert.ToInt32(txtVida.Text);
            decimal costo = Convert.ToDecimal(txtCosto.Text);
            decimal residual = Convert.ToDecimal(txtValorSalvamento.Text);

            ActivoFijo af = new ActivoFijo()
            {
                Nombre = nombre,
                TipoActivoFijo = tipoActivoFijo,
                VidaUtil = vida,
                Costo = costo,
                Salvamento = residual

            };

            activosFijos.Add(af);

            MessageBox.Show("Se agrego correctamente", "Mensaje de confirmacion", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtVida.Clear();
            txtCosto.Clear();
            txtValorSalvamento.Clear();
            
        }

        private void cmbTipoActivoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbChange = (ComboBox)sender;
            int index = cmbChange.SelectedIndex;

            TipoActivoFijo tipoActivoFijo = Enum.GetValues(typeof(TipoActivoFijo)).
                                            Cast<TipoActivoFijo>().ToArray()[index];

            switch (tipoActivoFijo)
            {
                case TipoActivoFijo.EQUIPO_COMPUTO:
                    txtVida.Text = "1";
                    break;
                case TipoActivoFijo.MOBILIARIO:
                    txtVida.Text = "2";
                    break;
                case TipoActivoFijo.VEHICULO:
                    txtVida.Text = "5";
                    break;
                case TipoActivoFijo.MAQUINARIA:
                    txtVida.Text = "7";
                    break;
                case TipoActivoFijo.EDIFICIO:
                    txtVida.Text = "20";
                    break;
                default:
                    MessageBox.Show("Opcion invalida", "Mensaje de Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }
    }
}
