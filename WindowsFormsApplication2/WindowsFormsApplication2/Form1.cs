using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Archivo.txt", rtxCaja.Text.Replace("\n", Environment.NewLine));
            MessageBox.Show("Archivo Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName.Length > 0)
            {
                txtAbrir.Text = ofd.FileName;
            }
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            rtxCaja.Text = File.ReadAllText(txtAbrir.Text);
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxCaja.SelectedText);
        }

        private void btCortar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxCaja.SelectedText);
            rtxCaja.SelectedText = "";
        }

        private void btPegar_Click(object sender, EventArgs e)
        {
            rtxCaja.Text = rtxCaja.Text + Clipboard.GetText();
        }
    }
}
