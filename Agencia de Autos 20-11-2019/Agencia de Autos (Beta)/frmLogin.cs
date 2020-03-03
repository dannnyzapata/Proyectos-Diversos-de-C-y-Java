using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Autos__Beta_
{
    public partial class frmLogin : Form
    {
        bool enter=false;
        Conexion sql = new Conexion();
        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(bool entra)
        {
            enter = entra;
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //frmInicio ini = new frmInicio();
            //ini.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sql.conectar();
            //DataTable Names = sql.ejecutarQuery("select * from Empleados where Nombre = '" + txtLogin.Text + "' and Contraseña = '"+txtPasswrod.Text+"'");
            //if (Names != null)
            //{
            if (enter == false)
            {
                frmInicio inicio = new frmInicio();
                this.Hide();
                inicio.ShowDialog();
                this.Close();
            }
            else
            {
                frmEmpleados empleado = new frmEmpleados();
                empleado.ShowDialog();
            }
            /*}
            else
            {
                MessageBox.Show("Usuario no encontrado!");
            }
            sql.desconectar();*/
        }

    }
}
