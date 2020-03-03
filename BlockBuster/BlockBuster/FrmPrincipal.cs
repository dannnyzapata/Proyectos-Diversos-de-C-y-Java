using Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBuster
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            
            InitializeComponent();
            
        }
        DataTable origen = new DataTable();
        
        private void rbnPelicula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPelicula.Checked)
            {
                cmbGenero.Items.Clear();
                cmbGenero.Items.Add("Terror");
                cmbGenero.Items.Add("Suspenso");
                cmbGenero.Items.Add("Accion");
                cmbGenero.Items.Add("Comedia");
                cmbGenero.Items.Add("Drama");

                LblDirDes.Text = "Director";
            }
            else
            {
                cmbGenero.Items.Clear();
                cmbGenero.Items.Add("Plataforma");
                cmbGenero.Items.Add("RPG");
                cmbGenero.Items.Add("Shooter");
                cmbGenero.Items.Add("ESports");
                cmbGenero.Items.Add("Estrategia");

                LblDirDes.Text = "Desarrolladora";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();           
            conn.conectar();
            if (rbnPelicula.Checked)
            {
               // origen.Rows.Add(txtNombre.Text, "Pelicula", nudAnio.Value.ToString(), txtDirDes.Text, cmbGenero.Text);
                conn.ejecutaTransaccion("Insert into Peliculas Values('"+ txtNombre.Text+"','"+ nudAnio.Value.ToString()+"','"+ txtDirDes.Text+"','" + cmbGenero.Text+"');");
                txtDirDes.Clear();
                txtNombre.Clear();
               

                
            }
            else
            {
                //origen.Rows.Add(txtNombre.Text, "VideoJuego", nudAnio.Value.ToString(), txtDirDes.Text, cmbGenero.Text);
                conn.ejecutaTransaccion("Insert into Videojuegos Values('" + txtNombre.Text+"','" + nudAnio.Value.ToString()+"','" + txtDirDes.Text+"','" + cmbGenero.Text+"');");
                txtDirDes.Clear();
                txtNombre.Clear();
            }
            conn.desconectar();
            dgvDatos.DataSource = origen;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            conn.conectar();
            if (rbnPelicula.Checked)
            {
                dgvDatos.DataSource = conn.ejecutarQuery("select * from Peliculas where Nombre='" + txtNombre.Text + "'");
            }
            else
            {
                dgvDatos.DataSource = conn.ejecutarQuery("select * from Videojuegos where Nombre='" + txtNombre.Text + "'");

            }
            conn.desconectar();


        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            origen.Columns.Add("nombre");
            origen.Columns.Add("tipo");
            origen.Columns.Add("anio");
            origen.Columns.Add("dirdes");
            origen.Columns.Add("genero");
            dgvDatos.DataSource = origen;
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            conn.conectar();
            
           
            if (rbnPelicula.Checked)
            {
                dgvDatos.DataSource = conn.ejecutarQuery("select * from Peliculas");


            }
            else
            {
                dgvDatos.DataSource = conn.ejecutarQuery("select * from Videojuegos");

            }
            conn.desconectar();


        }
    }
}
