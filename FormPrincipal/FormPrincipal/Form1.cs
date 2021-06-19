﻿using FormPrincipal.Enums;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNacionalidad.Items.AddRange(Enum.GetValues(typeof(Paises)).Cast<object>().ToArray());
            cmbNacionalidad.SelectedIndex = 0;

            lstPreferencias.Items.AddRange(Enum.GetValues(typeof(Preferencias)).Cast<object>().ToArray());
        }
    }
}
