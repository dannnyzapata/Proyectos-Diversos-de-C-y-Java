using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MATRicularas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Alumnos.txt"))
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Alumnos.txt");

            }
            this.Close();
        }
    }
}
