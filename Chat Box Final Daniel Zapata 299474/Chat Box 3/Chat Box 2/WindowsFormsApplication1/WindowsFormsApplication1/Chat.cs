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

namespace WindowsFormsApplication1
{
    public partial class Chat : Form
    {
        private char genre;
        private string _nombre;
        public Chat(char genero, string nombre)
        {

            InitializeComponent();
           
            genre = genero;
            _nombre = nombre;
            this.Text = "Chat - " + _nombre;
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            
            Timer timer = new Timer();
            timer.Interval =  1000; 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {


            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ChatLog.txt", (_nombre + ", " + DateTime.Now.ToString("HH:mm:ss") + ", " + genre + ": " + rtxUsuario.Text + Environment.NewLine));
            rtxUsuario.Text = " ";
            
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ChatLog.txt"))
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ChatLog.txt");
            }
            rtxChat.Text = "";



            string[] texto = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ChatLog.txt");
            foreach (string line in texto){

                if (line.StartsWith(_nombre))
                {
                    if (genre == 'H')
                    {
                        rtxChat.SelectionColor = Color.Blue;
                    }

                    if (genre == 'M')
                    {
                        rtxChat.SelectionColor = Color.Pink;
                    }

                    if (genre == 'O')
                    {
                        rtxChat.SelectionColor = Color.Purple;
                    }


                    rtxChat.SelectionAlignment = HorizontalAlignment.Right;
                    rtxChat.AppendText(line + Environment.NewLine);

                }
                else 
                {

                    if (line.Contains('H'))
                    {
                        rtxChat.SelectionColor = Color.Blue;
                    }

                    if (line.Contains('M'))
                    {
                        rtxChat.SelectionColor = Color.Pink;
                    }

                    if (line.Contains('O'))
                    {
                        rtxChat.SelectionColor = Color.Purple;
                    }
                    rtxChat.SelectionAlignment = HorizontalAlignment.Left;
                    rtxChat.AppendText(line + Environment.NewLine);

                }

            }                                       
        }

        private void RtxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ChatLog.txt", (_nombre + ", " + DateTime.Now.ToString("HH:mm:ss") + ", " + genre + ": " + rtxUsuario.Text + Environment.NewLine));
                rtxUsuario.Text = " ";
            }
        }
    }
}
