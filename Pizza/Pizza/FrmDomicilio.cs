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
    public partial class FrmDomicilio : Form
    {
        public FrmDomicilio()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.conectar();
            DataTable Datos = con.ejecutarQuery("select ID, Nombre from Cliente");
            con.desconectar();
            FrmBuscador form = new FrmBuscador(Datos);
            form.ShowDialog();
            if (form.descripcion.Length > 0)
            {
                txtCliente.Text = form.descripcion;
            }
        }

        private void BtnBuscarPizza_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.conectar();
            DataTable Datos = con.ejecutarQuery("select ID, Descripcion from Pizzas");
            con.desconectar();
            FrmBuscador form = new FrmBuscador(Datos);
            form.ShowDialog();
            if (form.descripcion.Length > 0)
            {
                txtPizza.Text = form.descripcion;
               
            }

            con.desconectar();
        }

        private void btBuscarDireccion_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.conectar();
            DataTable Datos = con.ejecutarQuery("select ID, Calle from Cliente");
            con.desconectar();
            FrmBuscador form = new FrmBuscador(Datos);
            form.ShowDialog();
            if (form.descripcion.Length > 0)
            {
                txtCalle.Text = form.descripcion;

            }

            con.conectar();
            DataTable Datos2 = con.ejecutarQuery("select ID, Numero from Cliente where Calle like" + txtCalle.Text);
            con.desconectar();

            FrmBuscador form2 = new FrmBuscador(Datos2);
            if (form.descripcion.Length > 0)
            {
                txtNumero.Text = form.descripcion;

            }

            con.conectar();
            DataTable Datos3 = con.ejecutarQuery("select ID, Colonia from Cliente where Calle like" + txtCalle.Text);
            con.desconectar();

            FrmBuscador form3 = new FrmBuscador(Datos3);
            if (form.descripcion.Length > 0)
            {
                txtColonia.Text = form.descripcion;

            }

            con.conectar();
            DataTable Datos4 = con.ejecutarQuery("select ID, CP from Cliente where Calle like" + txtCalle.Text);
            con.desconectar();

            FrmBuscador form4 = new FrmBuscador(Datos4);
            if (form.descripcion.Length > 0)
            {
                txtCP.Text = form.descripcion;

            }

            con.conectar();
            DataTable Datos5 = con.ejecutarQuery("select ID, Referencia from Cliente where Calle like" + txtCalle.Text);
            con.desconectar();

            FrmBuscador form5 = new FrmBuscador(Datos5);
            if (form.descripcion.Length > 0)
            {
                txtReferencias.Text = form.descripcion;

            }
            con.conectar();
            DataTable Datos6 = con.ejecutarQuery("select ID, Telefono from Cliente where Calle like" + txtCalle.Text);
            con.desconectar();

            FrmBuscador form6 = new FrmBuscador(Datos6);
            if (form.descripcion.Length > 0)
            {
                txtTelefono.Text = form.descripcion;

            }

        }
    }
}
