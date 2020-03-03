using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ferreteria
{
    class Conexion
    {
        static string cadenaConexion = "Data Source=(local),1433;Initial Catalog=MecanicoDB;Integrated Security=SSPI;User ID=sa;Password=ingenieria";
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
