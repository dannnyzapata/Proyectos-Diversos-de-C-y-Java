using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciudades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {         
            
            if (cbSeleccionar.SelectedItem.ToString() == "Pais")
            {

                int n = dtgMuestra.Rows.Add();
                dtgMuestra.Rows[n].Cells[0].Value = txtContenidos.Text;
                txtContenidos.Clear();
            }

            if (cbSeleccionar.SelectedItem.ToString() == "Estado")
            {

                int n = dtgMuestra.Rows.Add();
                dtgMuestra.Rows[n].Cells[1].Value = txtContenidos.Text;
                txtContenidos.Clear();
            }

            if (cbSeleccionar.SelectedItem.ToString() == "Ciudad")
            {

                int n = dtgMuestra.Rows.Add();
                dtgMuestra.Rows[n].Cells[2].Value = txtContenidos.Text;
                txtContenidos.Clear();
            }
        }
    }
}
