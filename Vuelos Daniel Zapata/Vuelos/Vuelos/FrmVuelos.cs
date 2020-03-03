using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuelos
{
    public partial class FrmVuelos : Form
    {
        public FrmVuelos()
        {
            InitializeComponent();
        }
        int mano = 1, documentada = 0, asiento = 0, seguro = 0, total = 0, valorMano=200, valorDocumentada=0, valorVuelo=0, valorAsiento=0, valorSeguro=0;

        private void NudLlegada_ValueChanged(object sender, EventArgs e)
        {
            if (tvVuelos.Nodes.Find(seguro.ToString() + " Seguro de Llegada: " + (1500 * seguro).ToString(), true).Length > 0)
            {
                tvVuelos.Nodes.Remove(tvVuelos.Nodes.Find(seguro.ToString() + "Seguro de Llegada: " + (1500 * seguro).ToString(), true)[0]);
            }

            if (nudSeguro.Value > 0)
            {
                tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add(nudSeguro.Value.ToString() + " Seguro de Llegada: " + (1500 * nudSeguro.Value).ToString(), nudSeguro.Value.ToString() + " Seguro de Llegada: " + (1500 * nudSeguro.Value).ToString());
            }
            seguro = (int)nudSeguro.Value;
            valorSeguro = seguro * 1500;
            total = valorAsiento + valorMano + valorVuelo + valorDocumentada + valorSeguro;
            lblTotal.Text = "Total:" + total.ToString();
        }

        private void NudAsiento_ValueChanged(object sender, EventArgs e)
        {
            if (tvVuelos.Nodes.Find(asiento.ToString() + " Asiento asignado por: " + (300 * asiento).ToString(), true).Length > 0)
            {
                tvVuelos.Nodes.Remove(tvVuelos.Nodes.Find(asiento.ToString() + " Asiento asignado por: " + (300 * asiento).ToString(), true)[0]);
            }

            if (nudAsiento.Value > 0)
            {
                tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add(nudAsiento.Value.ToString() + " Asiento asignado por: " + (300 * nudAsiento.Value).ToString(), nudAsiento.Value.ToString() + " Asiento asignado por: " + (300 * nudAsiento.Value).ToString());
            }
            asiento = (int)nudAsiento.Value;
            valorAsiento = asiento * 300;
            total = valorAsiento + valorMano + valorVuelo + valorDocumentada + valorSeguro;
            lblTotal.Text = "Total:" + total.ToString();
        }

        private void cmbIda_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = 0;
            if (txtNombre.TextLength > 0)
            {
                if (tvVuelos.Nodes.Count > 0)
                {
                    tvVuelos.Nodes.Remove(tvVuelos.Nodes.Find(txtNombre.Text, true)[0]);
                }
                if (ChkRedondo.Checked)
                {
                    cmbVuelta.SelectedIndex = cmbIda.SelectedIndex;
                    switch (cmbIda.SelectedIndex)
                    {
                        case 0:
                            tvVuelos.Nodes.Add(txtNombre.Text, txtNombre.Text);
                            tvVuelos.Nodes[txtNombre.Text].Nodes.Add(cmbIda.Text + "(R)", cmbIda.Text + "(R)");
                            tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add("Vuelo:$5000", "Vuelo:$5000");
                            valorVuelo = 5000;
                            tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add(nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString(), nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString());
                            break;
                        case 1:
                            tvVuelos.Nodes.Add(txtNombre.Text, txtNombre.Text);
                            tvVuelos.Nodes[txtNombre.Text].Nodes.Add(cmbIda.Text + "(R)", cmbIda.Text + "(R)");
                            tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add("Vuelo:$1400", "Vuelo:$1400");
                            valorVuelo = 1400;
                            tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add(nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString(), nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString());
                            break;
                        case 2:
                             tvVuelos.Nodes.Add(txtNombre.Text, txtNombre.Text);
                            tvVuelos.Nodes[txtNombre.Text].Nodes.Add(cmbIda.Text + "(R)", cmbIda.Text + "(R)");
                            tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add("Vuelo:$2200", "Vuelo:$2200");
                            valorVuelo = 2200;
                            tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add(nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString(), nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString());
                            break;
                    }
                }
            }
            else if (cmbIda.SelectedIndex >= 0)
            {
                cmbIda.SelectedIndex = -1;
                MessageBox.Show("Escriba el nombre del pasajero");
            }
            nudMano.Value = 1;
            total = valorDocumentada + valorMano + valorVuelo + valorAsiento + valorSeguro;
            lblTotal.Text ="Total:"+ total.ToString();
        }

        private void ChkRedondo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRedondo.Checked)
            {
                cmbVuelta.Enabled = true;
                cmbVuelta.SelectedIndex = cmbIda.SelectedIndex;
            }
            else
            {
                cmbVuelta.SelectedIndex = -1;
                cmbVuelta.Enabled = false;
            }

        }

        private void FrmVuelos_Load(object sender, EventArgs e)
        {

        }

        private void nudMano_ValueChanged(object sender, EventArgs e)
        {
            tvVuelos.Nodes.Remove(tvVuelos.Nodes.Find(mano.ToString() + " Maleta(s) de mano:" + (200 * mano).ToString(),true)[0]);
            tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add(nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString(), nudMano.Value.ToString() + " Maleta(s) de mano:" + (200 * nudMano.Value).ToString());
            mano = (int)nudMano.Value;
            valorMano= mano * 200;
            total = valorDocumentada + valorMano + valorVuelo + valorAsiento + valorSeguro;
            lblTotal.Text = "Total:" + total.ToString();
        }

        private void nudDocumentada_ValueChanged(object sender, EventArgs e)
        {
            if (tvVuelos.Nodes.Find(documentada.ToString() + " Maleta(s) documentada(s):" + (400 * documentada).ToString(), true).Length > 0)
            {
                tvVuelos.Nodes.Remove(tvVuelos.Nodes.Find(documentada.ToString() + " Maleta(s) documentada(s):" + (400 * documentada).ToString(), true)[0]);
            }

            if (nudDocumentada.Value > 0)
            {
                tvVuelos.Nodes[txtNombre.Text].Nodes[cmbIda.Text + "(R)"].Nodes.Add(nudDocumentada.Value.ToString() + " Maleta(s) documentada(s):" + (400 * nudDocumentada.Value).ToString(), nudDocumentada.Value.ToString() + " Maleta(s) documentada(s):" + (400 * nudDocumentada.Value).ToString());
            }
            documentada = (int)nudDocumentada.Value;
            valorDocumentada= documentada * 400;
            total = valorDocumentada + valorMano + valorVuelo + valorAsiento + valorSeguro;
            lblTotal.Text = "Total:" + total.ToString();
        }
    }
}
