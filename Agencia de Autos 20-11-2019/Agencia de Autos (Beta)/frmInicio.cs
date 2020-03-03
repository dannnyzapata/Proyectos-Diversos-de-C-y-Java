using System;
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
    public partial class frmInicio : Form
    {
        public bool shutdown = false;
        string datos;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVentas Ventas = new frmVentas();
            Ventas.StartPosition = FormStartPosition.CenterParent;
            Ventas.MdiParent = this;
            Ventas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInventario Inventario = new frmInventario();
            Inventario.StartPosition = FormStartPosition.CenterParent;
            Inventario.MdiParent = this;
            Inventario.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shutdown = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLogin incio = new frmLogin();
            incio.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
