﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Autos__Beta_
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewInventario add = new frmNewInventario();
            add.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            frmNewInventario add = new frmNewInventario();
            add.ShowDialog();
        }
    }
}
