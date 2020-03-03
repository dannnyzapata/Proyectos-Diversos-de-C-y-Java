using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Autos__Beta_
{
    class Conexion
    {
        static string cadenaConexion = "Data Source=(MREDLLJOULE),1433;Initial Catalog=AgenciaDB;Integrated Security=SSPI;User ID=sa;Password=ingenieria";
        SqlConnection conn = new SqlConnection(cadenaConexion);
        public void conectar()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //################################################################
        /*
        private string server = "DESKTOP-7I7I2N3\\SQLEXPRESS";
        private string dbname = "UACH";
        //constructor código que se va a ejecutar cuando hagas el objeto
        public void conectar()
        {
            //inciar conexion
            conn = new SqlConnection("server=" + server + ";database=" + dbname + "; integrated security = true");
            //integrated security = true sirve para identificarse con tu pc
            conn.Open();
            //conexion establecida
        }
         */
        //################################################################

        public void desconectar()
        {
            conn.Close();
        }
        public DataTable ejecutarQuery(string consulta)
        {
            DataTable resultado = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            adaptador.Fill(resultado);
            return resultado;
        }
        public bool ejecutaTransaccion(string consulta)
        {
            bool bien = true;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                bien = false;
                MessageBox.Show(ex.Message);
            }
            return bien;
        }
    }
}
