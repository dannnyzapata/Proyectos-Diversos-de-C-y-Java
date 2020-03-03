using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolLetras
{
    public partial class FrmArbol : Form
    {
        public FrmArbol()
        {
            InitializeComponent();
        }

        private int obtenerNivelMaximo(TreeNode nodoPadre)
        {
            var subnivel = nodoPadre.Nodes.Cast<TreeNode>().Select<TreeNode, int>(subnodo => obtenerNivelMaximo(subnodo));
            return subnivel.Count<int>() == 0 ? 1 : subnivel.Max() + 1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtLetra.Text.Equals("A") || TxtLetra.Text.Equals("E") || TxtLetra.Text.Equals("I") || TxtLetra.Text.Equals("O") || TxtLetra.Text.Equals("U"))
            {
                int niveles = 0;
                if (TvArbol.Nodes[0].Nodes.Find(TxtLetra.Text, true).Length > 0)
                {
                    niveles = obtenerNivelMaximo(TvArbol.Nodes[0].Nodes.Find(TxtLetra.Text, true)[0]);
                }
                bool agregado = false;
                if (niveles == 1)
                {
                    if (TvArbol.Nodes[0].Nodes["NdIzquierda"].Nodes.Find(TxtLetra.Text, true).Length > 0)
                    {
                        TvArbol.Nodes[0].Nodes["NdIzquierda"].Nodes[TxtLetra.Text].Nodes.Add(TxtLetra.Text + "1", TxtLetra.Text + "1");
                    }
                }
                else
                {
                    for (int i = niveles - 1; i > 0; i--)
                    {
                        if (TvArbol.Nodes[0].Nodes.Find(TxtLetra.Text + i, true).Length > 0)
                        {
                            TvArbol.Nodes[0].Nodes.Find(TxtLetra.Text+i, true)[0].Nodes.Add(TxtLetra.Text + (i+1), TxtLetra.Text + (i+1));
                            agregado = true;
                            break;
                        }
                    }
                    if (!agregado)
                    {
                        TvArbol.Nodes[0].Nodes["NdIzquierda"].Nodes.Add(TxtLetra.Text, TxtLetra.Text);
                    }  
                }
                

            }
            else
            {
                if (TvArbol.Nodes[0].Nodes.Find(TxtLetra.Text, true).Length > 0)
                {
                    TvArbol.Nodes[0].Nodes.Find(TxtLetra.Text, true)[0].Nodes.Add(TxtLetra.Text + "1", TxtLetra.Text + "1");
                }
                else
                {
                    TvArbol.Nodes[0].Nodes["NdDerecha"].Nodes.Add(TxtLetra.Text, TxtLetra.Text);
                }
            }
            
        }

        private void FrmArbol_Load(object sender, EventArgs e)
        {
            TvArbol.Nodes[0].Nodes.Add("NdIzquierda", "Izquierda");
            TvArbol.Nodes[0].Nodes.Add("NdDerecha", "Derecha");
        }
    }
}
