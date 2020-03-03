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
    public partial class FrmPrincipal : Form
    {
        private char _genero;
        public FrmPrincipal(char genero)
        {
            InitializeComponent();
            _genero = genero;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_genero.ToString());
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
