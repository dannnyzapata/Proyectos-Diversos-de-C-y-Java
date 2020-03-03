using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teams
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarG1_Click(object sender, EventArgs e)
        {
            lbxGrupo1.Items.Add(txtEquipoG1.Text);
            txtEquipoG1.Clear();
        }

        private void btnAgregarG2_Click(object sender, EventArgs e)
        {
            lbxGrupo2.Items.Add(txtEquipoG2.Text);
            txtEquipoG2.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string Grupo1 = "Grupo 1:"+Environment.NewLine;
            int agregar = 0;
            for(int i=0;i<=lbxGrupo1.Items.Count-1; i++)
            {
                foreach (string equipo in lbxGrupo1.Items)
                {
                    if (lbxGrupo1.Items.IndexOf(equipo) != i)
                    {
                        Grupo1 += lbxGrupo1.Items[i].ToString() + " VS " + equipo.ToString() + " " + DateTime.Now.AddDays(agregar).ToShortDateString() + " " + DateTime.Now.AddHours(agregar * 2).ToLongTimeString() + Environment.NewLine;
                        agregar++;
                    }
                }
            }
            string Grupo2 = "Grupo 2:" + Environment.NewLine;
            int agregar2 = 0;
            for (int i = 0; i <= lbxGrupo2.Items.Count - 1; i++)
            {
                foreach (string equipo in lbxGrupo2.Items)
                {
                    if (lbxGrupo2.Items.IndexOf(equipo) != i)
                    {
                        Grupo2 += lbxGrupo2.Items[i].ToString() + " VS " + equipo.ToString() + " " + DateTime.Now.AddDays(agregar2).ToShortDateString() + " " + DateTime.Now.AddHours(agregar2 * 2).ToLongTimeString() + Environment.NewLine;
                        agregar2++;
                    }
                }
            }
            File.WriteAllText("C:\\Users\\Oscar\\Desktop\\Juegos.txt", Grupo1+Grupo2);
            MessageBox.Show("Horarios Guardados!");
        }
    }
}
