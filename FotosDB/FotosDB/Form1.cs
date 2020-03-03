using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotosDB
{
    public partial class Form1 : Form
    {
        Conexion con = new Conexion();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imagenes|*.png;*.jpg;*.jpeg;*.bmp;*.tiff";
            dialogo.Multiselect = false;
            dialogo.ShowDialog();
            if (dialogo.FileName.Length > 0)
            {
                PicBox.Image = Image.FromFile(dialogo.FileName);
                txtImagen.Text = dialogo.FileName;
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            
            con.conectar();
            con.InsertarImagen(txtID.Text,txtDescrip.Text,cbCategoria.SelectedItem.ToString(),PicBox);
            txtDescrip.Clear();
            txtID.Clear();
            txtImagen.Clear();
            

            con.desconectar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void cbRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.conectar();
            con.cargarImagenes(cbRegistro);
            con.VerImagen(PicBox,cbRegistro.SelectedItem.ToString());
            con.desconectar();
        }
    }
}
