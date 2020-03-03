using System;
using System.Drawing;
using System.Windows.Forms;
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
    public partial class frmVentas : Form
    {
        string[] URLS = new string[5];
        bool tab = false;
        
        int ID = 0;

        public frmVentas()
        {
            InitializeComponent();
            URLS[0] = "https://image.jimcdn.com/app/cms/image/transf/none/path/sf7ce3f8068d88249/image/i6e85c52004b97a7f/version/1573694766/image.png";
            URLS[1] = "https://image.jimcdn.com/app/cms/image/transf/none/path/sf7ce3f8068d88249/image/i8ea273082d6abf78/version/1573694783/image.png";
            URLS[2] = "https://image.jimcdn.com/app/cms/image/transf/none/path/sf7ce3f8068d88249/image/i7c69a1624c7c7c43/version/1573694793/image.png";
            URLS[3] = "https://s3.amazonaws.com/ptx-blogs/wp-content/uploads/sites/8/2019/01/29234845/Subaru-pick-up-1.jpg";
            URLS[4] = "https://www.leasevan.co.uk/images/main/vans/1/3/574/isuzu_d_max_diesel_1_9_single_cab_4x2_2017_front_three_quarter.jpeg.pagespeed.ce.gc3vnl1Qu3.jpg";
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void btAbrirCarro_Click(object sender, EventArgs e)
        {
            frmCatalogo Catalogo = new frmCatalogo();
            Catalogo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
 
    }
}
