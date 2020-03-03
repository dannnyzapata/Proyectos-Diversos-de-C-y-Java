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
    public partial class FrmLugares : Form
    {
        DataTable Lugares;
        public FrmLugares()
        {
            InitializeComponent();
        }
        public FrmLugares(DataTable Tabla)
        {
            InitializeComponent();
            Lugares = Tabla;

            foreach (DataRow row in Lugares.Rows)
            {
                if (row[1].ToString().Equals("") && row[2].ToString().Equals(""))
                {
                    cmbPais.Items.Add(row[0].ToString());
                }
            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.Items.Clear();
            cmbCiudad.Items.Clear();
            foreach (DataRow row in Lugares.Rows)
            {
                if (row[0].ToString().Equals(cmbPais.Text) && row[1].ToString().Length>0 && row[2].ToString().Length==0)
                {
                    cmbEstado.Items.Add(row[1].ToString());
                }
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCiudad.Items.Clear();
            foreach (DataRow row in Lugares.Rows)
            {
                if (row[1].ToString().Equals(cmbEstado.Text) && row[2].ToString().Length > 0)
                {
                    cmbCiudad.Items.Add(row[2].ToString());
                }
            }
        }
    }
}
