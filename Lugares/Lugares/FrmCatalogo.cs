using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lugares
{
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 1)
            {
                cmbPais.Visible = true;
                cmbEstado.Visible = false;
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                cmbPais.Visible = true;
                cmbEstado.Visible = true;
            }
            else
            {
                cmbPais.Visible = false;
                cmbEstado.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtLugar.TextLength > 0)
            {
                if (cmbTipo.SelectedIndex == 0)
                {
                    dgvLugares.Rows.Add(txtLugar.Text, "", "");
                    dgvLugares.Rows[dgvLugares.RowCount - 1].Cells["clmPais"].Style.Font = new Font("Arial", 8, FontStyle.Bold);
                    cmbPais.Items.Add(txtLugar.Text);
                }
                else if (cmbTipo.SelectedIndex == 1)
                {
                    if (cmbPais.SelectedIndex >= 0)
                    {
                        dgvLugares.Rows.Add(cmbPais.Text, txtLugar.Text, "");
                        dgvLugares.Rows[dgvLugares.RowCount - 1].Cells["clmEstado"].Style.Font = new Font("Arial", 8, FontStyle.Bold);
                        cmbEstado.Items.Add(txtLugar.Text);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el Pais del estado a agregar");
                    }
                }
                else
                {
                    if (cmbPais.SelectedIndex >= 0 && cmbEstado.SelectedIndex >= 0)
                    {
                        dgvLugares.Rows.Add(cmbPais.Text, cmbEstado.Text,txtLugar.Text);
                        dgvLugares.Rows[dgvLugares.RowCount - 1].Cells["clmCiudad"].Style.Font = new Font("Arial", 8, FontStyle.Bold);
                    }
                    else
                    {
                        MessageBox.Show("Revise Pais y Estado de la ciudad a agregar");
                    }
                }
              
            }
            else
            {
                MessageBox.Show("Ingrese algun valor en el lugar");
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Pais");
            tabla.Columns.Add("Estado");
            tabla.Columns.Add("Ciudad");
            foreach (DataGridViewRow row in dgvLugares.Rows)
            {
                tabla.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
            }
            FrmLugares form = new FrmLugares(tabla);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
