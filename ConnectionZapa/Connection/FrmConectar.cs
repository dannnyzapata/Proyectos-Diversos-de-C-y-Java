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
            DataTable resultados = new DataTable();
            Conexion conn = new Conexion();
            conn.conectar();
            resultados = conn.ejecutarQuery("select * from Alumno");
            dtMatriculas.DataSource = resultados;
            conn.desconectar();
        }
    }
}
