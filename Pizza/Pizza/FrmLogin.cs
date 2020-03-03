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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength > 0 && txtPassword.TextLength > 0)
            {
                Conexion con = new Conexion();
                con.conectar();
                if (con.ejecutarQuery("select * from Usuario where Usuario='" + txtUsuario.Text + "' and Password='" + txtPassword.Text + "'").Rows.Count == 1)
                {
                    FrmMenu form = new FrmMenu();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.desconectar();
            }
            else
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
