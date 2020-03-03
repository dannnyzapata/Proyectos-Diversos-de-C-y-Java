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
    public partial class frmEmpleados : Form
    {
        Conexion conn = new Conexion();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            //AgenciaDB
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            conn.conectar();
            DataTable Names = conn.ejecutarQuery("select * from Empleados where Nombre = '"+txtLogin.Text+"'");
            if (Names == null) {
            conn.ejecutaTransaccion("insert into Empleados values ('" + txtLogin.Text + "','" + txtPasword.Text + "')");
            }
            else
            {
                MessageBox.Show("Usuario ya registrado");
            }
                conn.desconectar();
        }
    }
}
