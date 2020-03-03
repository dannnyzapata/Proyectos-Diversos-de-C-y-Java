using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace FotosDB
{
    public class Conexion
    {
        static string cadenaConexion = "Data Source=(local),1433;Initial Catalog=PicturesDB;Integrated Security=SSPI;User ID=sa;Password=ingenieria";
        SqlConnection conn = new SqlConnection(cadenaConexion);
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;
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

        public void InsertarImagen(string id, string descripcion, string categoria, PictureBox PicBox)
        {
            string mensaje = "Imagen en base de datos";
            try
            {
                cmd = new SqlCommand("Insert into picture(id, Descripcion, Categoria, Imagen) values (@ID, @Descripcion, @Categoria, @Imagen)", conn);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar);
                cmd.Parameters.Add("@Imagen", SqlDbType.Image);

                cmd.Parameters["@ID"].Value = id;
                cmd.Parameters["@Descripcion"].Value = descripcion;
                cmd.Parameters["@Categoria"].Value = categoria;
                
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                PicBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                mensaje = "No se inserto la image: " + ex.ToString();
            }
        }

        public void VerImagen(PictureBox pbFoto, string descripcion)
        {
            try
            {
                da = new SqlDataAdapter("Select Imagen from pictures where descripcion = '"+descripcion+"'", conn);
                ds = new DataSet();
                da.Fill(ds, "pictures");
                byte[] datos = new byte[0];
                dr = ds.Tables["pictures"].Rows[0];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }

        }
        public void cargarImagenes (ComboBox cbImg)
        {
            try
            {
                cmd = new SqlCommand("Select descripcion from pictures", conn);
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    cbImg.Items.Add(sqldr["descripcion"]);
                }
                sqldr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el ComboBox: " + ex.ToString());
            }
        }

    }

}