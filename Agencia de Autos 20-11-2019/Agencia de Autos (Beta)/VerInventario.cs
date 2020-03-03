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
    public partial class VerInventario : Form
    {
        string url;
        int indice = 0;

        public VerInventario()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            indice = 0;
            txtAuto.Clear();
            txtAño.Clear();
            txtColor.Clear();
            txtModelo.Clear();
            txtPrecio.Clear();
            rtxDescripción.Clear();
            pbAutoView.Image = null; 
            this.Hide();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.conectar();
            
            indice++;
            txtAño.Text = con.ejecutarQuery("select Año from Inventario where Indice= " + indice).Rows[0]["Año"].ToString();
            txtModelo.Text = con.ejecutarQuery("select Modelo from Inventario where Indice= " + indice).Rows[0]["Modelo"].ToString();
            txtColor.Text = con.ejecutarQuery("select Color from Inventario where Indice= " + indice).Rows[0]["Color"].ToString();
            txtPrecio.Text = con.ejecutarQuery("select Precio from Inventario where Indice= " + indice).Rows[0]["Precio"].ToString();
            txtAuto.Text = con.ejecutarQuery("select Auto from Inventario where Indice= " + indice).Rows[0]["Auto"].ToString();
            rtxDescripción.Text = con.ejecutarQuery("select Descripcion from Inventario where Indice= " + indice).Rows[0]["Descripcion"].ToString();
            url = con.ejecutarQuery("select Descripcion from Imagen where Indice= " + indice).Rows[0]["Imagen"].ToString();


            con.desconectar();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.conectar();

            indice--;
            txtAño.Text = con.ejecutarQuery("select Año from Inventario where Indice= " + indice).Rows[0]["Año"].ToString();
            txtModelo.Text = con.ejecutarQuery("select Modelo from Inventario where Indice= " + indice).Rows[0]["Modelo"].ToString();
            txtColor.Text = con.ejecutarQuery("select Color from Inventario where Indice= " + indice).Rows[0]["Color"].ToString();
            txtPrecio.Text = con.ejecutarQuery("select Precio from Inventario where Indice= " + indice).Rows[0]["Precio"].ToString();
            txtAuto.Text = con.ejecutarQuery("select Auto from Inventario where Indice= " + indice).Rows[0]["Auto"].ToString();
            rtxDescripción.Text = con.ejecutarQuery("select Descripcion from Inventario where Indice= " + indice).Rows[0]["Descripcion"].ToString();
            url = con.ejecutarQuery("select Descripcion from Imagen where Indice= " + indice).Rows[0]["Imagen"].ToString();


            con.desconectar();

        }
    }
}
