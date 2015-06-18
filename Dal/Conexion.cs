using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {


        public DataSet ds = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlCommandBuilder cmd = new SqlCommandBuilder();

        //public static SqlConnection con = new SqlConnection("workstation id=Stefani.mssql.somee.com;packet size=4096;user id=friass_SQLLogin_1;pwd=qwnugz9mq5;data source=Stefani.mssql.somee.com;persist security info=False;initial catalog=Stefani");
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Stefani\documents\visual studio 2013\Projects\RegistroMedico\RegistroMedico\App_Data\Stefani.mdf;Integrated Security=True");
        public bool EjecutarDB(string Codigo)
        {
            bool mensaje = false;
            SqlCommand cmd = new SqlCommand();



            try
            {
                con.Open(); // abrimos la conexion
                //MessageBox.Show("Conexion abierta");

                cmd.Connection = con; //asignamos la conexion
                cmd.CommandText = Codigo;     //asignamos el comando
                cmd.ExecuteNonQuery(); // ejecutamos el comando

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mensaje = true;
                con.Close(); //cerramos la conexion
                // MessageBox.Show("Conexion cerrada");

            }
            return mensaje;
        }
        /// <summary>
        /// para buscar datos en la base de datos
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public DataTable BuscarDb(string comando)
        {
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            try
            {
                con.Open(); // abrimos la conexion
                adp = new SqlDataAdapter(comando, con);

                adp.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close(); //cerramos la conexion

            }
            return dt;
        }

        public void Consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmd = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public object GetDbValue(String Query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(Query,con);
            object returnValue;
            returnValue = cmd.ExecuteScalar();
            con.Close();
            return returnValue;
        }

    }

}
