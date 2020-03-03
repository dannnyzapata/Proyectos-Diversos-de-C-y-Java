using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Aviones.Nodes[0].Nodes.Add("NdMTY", "MTY-CUU");
            //Aviones.Nodes[0].Nodes.Add("NdCUU", "CUU-MTY");

            Aviones.Nodes[0].Nodes.Add("NdCDMX", "CDMX-CUU");
            //Aviones.Nodes[0].Nodes.Add("NdCHI", "CUU-CDMX");

            Aviones.Nodes[0].Nodes.Add("NdGDL", "GDL-CUU");
           // Aviones.Nodes[0].Nodes.Add("NdCHUA", "CUU-GDL");

            Aviones.Nodes[0].Nodes.Add("NdHUU", "HUU-CUU");
            //Aviones.Nodes[0].Nodes.Add("NdCGA", "CUU-HUU");



        }

        int pasajeros = 0, voladores=-1;
        int maletas = 0, clase=0, volver=0;


        private void Pasajero_Click(object sender, EventArgs e)
        {
            
            int i, r=1;
            for (i = 0; i < 4; i++)
            {
                if (Aviones.SelectedNode == Aviones.Nodes[0].Nodes[i])
                {
                    r = -1;
                    double price = 3000.00;
                    Aviones.SelectedNode.Nodes.Add(nombre.Text + " $" + price);
                    nombre.Text = "";
                    pasajeros++;
                    voladores++;
                }
                else if(r!=-1)
                {
                    r = 0;
                    
                }
            }
            if (r == 0)
            {
                MessageBox.Show("Solo se puede seleccionar en el Viaje", "warning");
            }

        }

        private void Aviones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            maletas = 0;
            clase = 0;
            volver = 0;
        }

        private void Regreso_Click(object sender, EventArgs e)
        {

            double Regreso = 1560.76;
            int i, r = 2, gear = -1;


            if (volver == 1)
            {
                MessageBox.Show("Ya sea seleccionado un Regreso", "warning");

                goto away;
            }


            for (i = 0; i < 4; i++)
            {
                if (Aviones.SelectedNode == Aviones.Nodes[0].Nodes[i] || Aviones.SelectedNode == Aviones.Nodes[0])
                {
                    gear = 2;
                    r = 0;

                }
                else if (r != 0 && gear == -1)
                {
                    gear = 2;
                    r = -1;

                    Aviones.SelectedNode.Nodes.Add("Vuelo de Regreso Agendado por $" + Regreso);
                    volver++;

                }
            }
            if (r == 0)
            {
                MessageBox.Show("Solo se puede seleccionar en el Pasajero", "warning");
            }
        away:;
        }

        private void documentar_Click(object sender, EventArgs e)
        {
            double Equipaje = 200.00;
            int i, r = 2, gear=-1;
            

            if(maletas==2)
            {
                MessageBox.Show("Maletas Maximas Alcanzadas", "warning");
                maletas = 0;
                goto away;
            }
            
                    for (i = 0; i < 4; i++)
                   {
                        if (Aviones.SelectedNode == Aviones.Nodes[0].Nodes[i]||Aviones.SelectedNode==Aviones.Nodes[0])
                        {
                            gear = 2;
                            r = 0;

                        }
                        else if(r!=0 && gear==-1)
                        {
                            gear = 2;
                            r = -1;
                            Aviones.SelectedNode.Nodes.Add("Documentacion $" + Equipaje);                          
                            maletas++;

                        }
                    }
                    if (r == 0)
                    {
                        MessageBox.Show("Solo se puede seleccionar en el Pasajero", "warning");
                    }
        away:;
           
        }   


        
        

        private void subir_Click(object sender, EventArgs e)
        {

            double Subir = 1200.69;
            int i, r = 2, gear = -1;


            if (clase == 1)
            {
                MessageBox.Show("Clase ya aumentada", "warning");
                
                goto away;
            }


            for (i = 0; i < 4; i++)
            {
                if (Aviones.SelectedNode == Aviones.Nodes[0].Nodes[i] || Aviones.SelectedNode == Aviones.Nodes[0])
                {
                    gear = 2;
                    r = 0;

                }
                else if (r != 0 && gear == -1)
                {
                    gear = 2;
                    r = -1;
                    
                    Aviones.SelectedNode.Nodes.Add("Cargo extra de $" + Subir);
                    clase++;

                }
            }
            if (r == 0)
            {
                MessageBox.Show("Solo se puede seleccionar en el Pasajero", "warning");
            }
        away:;
        }

    }


}
