//Daniel Zapata 299474
//Profe, el programa "funciona" a la segunda vez que se ejecuta porque no pude hacer que no tronara cuando crea el nuevo archivo y quieres agregar datos :(

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipos
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        private void btAgregarB_Click(object sender, EventArgs e)
        {

            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo1.txt", (txtG1.Text + "\n"));
            txtG1.Text = " ";
        }


        private void btAgregarR_Click(object sender, EventArgs e)
        {
            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo2.txt", (txtG2.Text + "\n"));
            txtG2.Text = " ";
        }


        private void txtG1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo1.txt", (txtG1.Text + "\n"));
                txtG1.Text = "";
            }
        }

        private void txtG2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo2.txt", (txtG2.Text + "\n"));
                txtG2.Text = "";
            }
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            int contador1, contador2, checador1, checador2, vision1, vision2;
            int i; 
            contador1 = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo1.txt").Length;
            contador2 = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo2.txt").Length;
            checador1 = contador1 % 2;
            checador2 = contador2 % 2;
            if (checador1 != 0 && checador2 != 0)
            {
                MessageBox.Show("Necesitamos Numeros Pares de Equipos!");
            }
            else
            {
                for (i = 0; i < contador1; i++)
                {
                    vision1 = contador1 % 2;
                    if(vision1==0){
                        
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo1.txt"))
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo1.txt");
            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo2.txt"))
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Grupo2.txt");
            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Partidos.txt"))
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Partidos.txt");
            }
        }
    }
}
