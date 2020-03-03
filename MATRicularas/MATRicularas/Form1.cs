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


    public partial class Form1 : Form
    {

        public Form1()
        {

   
            InitializeComponent();
        }

        int n;
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            n = dtgMatriculas.Rows.Add(); 
            dtgMatriculas.Rows[n].Cells[0].Value = txtMatricula.Text;
            dtgMatriculas.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgMatriculas.Rows[n].Cells[2].Value = txtApellidoP.Text;
            dtgMatriculas.Rows[n].Cells[3].Value = txtApellidoM.Text;
            dtgMatriculas.Rows[n].Cells[4].Value = txtTelefono.Text;

            txtMatricula.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();


        }

        private void BtBorrarS_Click(object sender, EventArgs e)
        {
            dtgMatriculas.Rows.RemoveAt(dtgMatriculas.SelectedRows[0].Index);
        }

        
        
        private void BtBuscarM_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n+1; i++)
            {
                dtgMatriculas.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            int chez = -1;

            foreach (DataGridViewRow Row in dtgMatriculas.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells[0].Value);
                

                if (Valor == this.txtMatriculaBus.Text)
                {
                    dtgMatriculas.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Red;
                    chez = 0;
                }
        
            }
            if (chez == -1)
            {
                MessageBox.Show("Alumno No Existe!");
            }

            txtMatriculaBus.Clear();
        }

        private void BtExportar_Click(object sender, EventArgs e)
        {


           
            TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Alumnos.txt");
            for (int i = 0; i < dtgMatriculas.Rows.Count; i++)
            {
                for (int j = 0; j < dtgMatriculas.Columns.Count; j++)
                {
                    writer.Write("\t" + dtgMatriculas.Rows[i].Cells[j].Value.ToString() + "\t" + "||");
                }
                writer.WriteLine("");
                writer.WriteLine("--------------------------------------------------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Datos Exportados");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtBorrarM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dtgMatriculas.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells[0].Value);

                if (Valor == this.txtMatriculaBus.Text)
                {
                    dtgMatriculas.Rows.RemoveAt(dtgMatriculas.Rows[Convert.ToInt32(strFila)].Index);
                    
                }
            }

            txtMatriculaBus.Clear();
        }

        private void TxtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if(!char.IsDigit(chr)&& chr!= 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo Acepto Numeros");
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo Acepto Numeros");
            }
        }

        private void TxtMatriculaBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo Acepto Numeros");
            }
        }
    }
}
