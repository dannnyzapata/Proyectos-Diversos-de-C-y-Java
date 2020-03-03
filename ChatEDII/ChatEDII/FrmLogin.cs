using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatEDII
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                char genero = ' ';
                if (rbnHombre.Checked)
                {
                    genero = 'H';
                }
                else if (rbnMujer.Checked)
                {
                    genero = 'M';
                }
                FrmPrincipal form = new FrmPrincipal(genero);
                form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Ingrese un valor para el nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
