using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class FrmImages : Form
    {
        public FrmImages()
        {
            InitializeComponent();
        }

        private void BtnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imagenes|*.png;*.jpg;*.jpeg;*.bmp;*.tiff";
            dialogo.Multiselect = false;
            dialogo.ShowDialog();
            if (dialogo.FileName.Length > 0)
            {
                PbImagen.Image = Image.FromFile(dialogo.FileName);
                TxtRuta.Text = dialogo.FileName;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            String Datos = "";
            Datos += TxtID.Text + Environment.NewLine;
            Datos += TxtDescripcion.Text + Environment.NewLine;
            Datos += CmbCategoria.Text + Environment.NewLine;
            Datos += TxtPrecio.Text + Environment.NewLine;
            Datos += TxtRuta.Text;
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivo.txt", Datos);

            MessageBox.Show("Datos Guardados!");

            TxtID.Clear();
            TxtDescripcion.Clear();
            CmbCategoria.SelectedIndex = -1;
            TxtPrecio.Clear();
            TxtRuta.Clear();
            PbImagen.Image = null;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivo.txt").Split('\n');
            TxtID.Text = lineas[0].Replace("\r","");
            TxtDescripcion.Text = lineas[1].Replace("\r", "");
            CmbCategoria.Text = lineas[2].Replace("\r", "");
            TxtPrecio.Text = lineas[3].Replace("\r", "");
            TxtRuta.Text = lineas[4].Replace("\r", "");
            PbImagen.Image = Image.FromFile(lineas[4].Replace("\r", ""));
        }
    }
}
