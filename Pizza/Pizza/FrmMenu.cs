﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void domicilioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDomicilio form = new FrmDomicilio();
            form.StartPosition = FormStartPosition.CenterParent;
            form.MdiParent = this;
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.StartPosition = FormStartPosition.CenterParent;
            form.MdiParent = this;
            form.Show();
        }
    }
}
