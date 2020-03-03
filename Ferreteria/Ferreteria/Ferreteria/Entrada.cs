using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {

            if (rdPartes.Checked)
            {
                VistaAutos autor = new VistaAutos();
                autor.Show();
                this.Hide();
            }
            if (rdHerramientas.Checked)
            {
                VistaHerramientas herra = new VistaHerramientas();
                this.Hide();
                
            }
            if (rdEmpleados.Checked)
            {
                VistaEmpleados emp = new VistaEmpleados();
                emp.Show();
                this.Hide();
            }

            
            
        }
    }
}
