using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                con.conectar();
                con.ejecutaTransaccion("insert into Cliente values('"+
                                        txtNombre.Text+"','"+
                                        txtCalle.Text+"','"+
                                        txtNumero.Text+"','"+
                                        txtColonia.Text+"',"+
                                        txtCP.Text+",'"+
                                        txtReferencias.Text+"','"+
                                        txtTelefono.Text+"')");
                con.desconectar();
                MessageBox.Show("Cliente insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.conectar();
                LblID.Text += con.ejecutarQuery("Select Top 1 ID from Cliente order by ID desc").Rows[0]["ID"].ToString();
                con.desconectar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
