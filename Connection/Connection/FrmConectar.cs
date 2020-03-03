using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            conn.conectar();
            string nombre = conn.ejecutarQuery("select * from Alumno").Rows[0]["Nombre"].ToString();
            MessageBox.Show(nombre);
            conn.ejecutaTransaccion("Insert into Alumno values(282254,'Larissa','Perez','Ingeniero Quimico','Facultad de Ciencias Quimicas',10)");
            nombre = conn.ejecutarQuery("select * from Alumno").Rows[1]["Nombre"].ToString();
            MessageBox.Show(nombre);
            conn.desconectar();
        }
    }
}
