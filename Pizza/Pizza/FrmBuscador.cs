using System;
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
    public partial class FrmBuscador : Form
    {
        public int id;
        public string descripcion;
        public FrmBuscador()
        {
            InitializeComponent();
        }
        DataTable Tabla;
        public FrmBuscador(DataTable Datos)
        {
            InitializeComponent();
            Tabla = Datos;
            dgvDatos.DataSource = Datos;
            dgvDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.ReadOnly = true;
            dgvDatos.Sort(dgvDatos.Columns[0], ListSortDirection.Ascending);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            int columna = 0;
            if (txtFiltro.TextLength > 0)
            {
                DataTable filtrado = Tabla.Clone();
                if (dgvDatos.SortedColumn.Index==0)
                {
                    DataRow[] resultado = Tabla.Select("Convert("+dgvDatos.SortedColumn.Name+",System.String) like '%" + txtFiltro.Text + "%'");
                    foreach (DataRow row in resultado)
                    {
                        filtrado.Rows.Add(row[0].ToString(), row[1].ToString());
                    }
                    columna = 0;
                }
                else
                {
                    DataRow[] resultado = Tabla.Select(dgvDatos.SortedColumn.Name+" like '%" + txtFiltro.Text + "%'");
                    foreach (DataRow row in resultado)
                    {
                        filtrado.Rows.Add(row[0].ToString(), row[1].ToString());
                    }
                    columna = 1;
                }
                dgvDatos.DataSource = filtrado;
                dgvDatos.Sort(dgvDatos.Columns[columna], ListSortDirection.Ascending);
            }
            else
            {
                dgvDatos.DataSource = Tabla;
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '%' || e.KeyChar == '*')
            {
                e.Handled = true;
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString());
            descripcion = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }
    }
}
