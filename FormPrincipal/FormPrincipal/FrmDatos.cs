using FormPrincipal.Clases;
using FormPrincipal.Enums;
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
    public partial class FrmDatos : Form
    {
        public PersonasModel Personas { get; set; }
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            cmbNacionalidad.Items.AddRange(Enum.GetValues(typeof(Nacionalidad)).Cast<object>().ToArray());
            cmbNacionalidad.SelectedIndex = 0;

            lblHora.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = Convert.ToInt32(nudEdad.Value);
            string sexo;

            if (rdbMasculino.Checked)
            {
                sexo = rdbMasculino.Text;
            }
            else
            {
                sexo = rdbFemenino.Text;
            }

            string nacionalidad = Convert.ToString(cmbNacionalidad.SelectedItem);

            Persona p = new Persona
            {
                Nombre = nombre,
                Apellidos = apellidos,
                Edad = edad,
                Sexo = sexo,
                Nacionalidad = nacionalidad
            };

            Personas.Add(p);

            MessageBox.Show("Se agrego correctamente al registro", "Confirmación", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach(Persona persona in Personas.FindAll())
            {
                Console.WriteLine($"Nombre: {persona.Nombre} \nApellidos: {persona.Apellidos} \nEdad: {persona.Edad} " +
                    $"\nSexo: {persona.Sexo} \nNacionalidad: {persona.Nacionalidad}\n\n");
                                   
            }
        }
    }
}
