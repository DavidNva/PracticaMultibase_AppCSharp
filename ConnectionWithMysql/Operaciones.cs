using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.Windows.Forms;


namespace ConnectionWithMysql
{
    class Operaciones:Conexion
    {

        
        public static string ObtenerCadenaMySQL(string host, string usuario, string password, string bd)
        {
            //string cadenaConexion = "Server=" + host + "; Database = " + bd + "; UserID=" + usuario + "; Password=" + password + "";
            //string connectionString = "Server=localhost;Database=nombre_de_tu_base_de_datos;Uid=usuario_de_mysql;Pwd=contraseña_de_mysql;";
            //using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            //{
            //    //Abrir la conexión
            //    connection.Open();
            //}
            return "Server=" + host + "; Database = " + bd + "; User ID=" + usuario + "; Password=" + password + "";
            
            //return "Database=" + bd + "; Data Source=" + host + "; User Id=" + usuario + "; Password=" + password + "";
        }
        public static string ObtenerCadenaSql(/*string host, string usuario, string password, string bd*/)
        {
            return "Data Source =.; Initial Catalog = TiendaCarBD; Integrated Security = True";
            //return "Server=" + host + "; Database = " + bd + "; User ID=" + usuario + "; Password=" + password + "";

            //return "Database=" + bd + "; Data Source=" + host + "; User Id=" + usuario + "; Password=" + password + "";
        }
        

        //SqlDataAdapter daCategoria;
        //private MySqlConnection con = new MySqlConnection();
        DataTable dtCategoria;
        public void ObtenerDatos(DataGridView grid, string host, string usuario, string password, string bd)
        {
            //Operaciones operacion = new Operaciones();
            string cadena = Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password);
            MySqlConnection con = new MySqlConnection(cadena);


            con.Open();

            string comando = "SELECT * FROM Categoria";
            MySqlCommand cmd = new MySqlCommand(comando, con);

            //DataTable dtCategoria;
            //cmd.CommandType = CommandType.Text;
            dtCategoria = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            //dataAdapterCategoria.SelectCommand.CommandType = CommandType.Text;

            adapter.Fill(dtCategoria);

            grid.DataSource = dtCategoria;


            //cmd.ExecuteNonQuery();
            //return con.ConnectionString;
            //con.Close();
            
            /*
             * public void Consultar(DataGridView grid, string consultaProcedimiento)
         {
             con.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
             SqlCommand cmd = new SqlCommand(consultaProcedimiento, con);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
             cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
             //cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
             //cmd.Parameters.AddWithValue("@Titulo", buscar);
             daCategoria = new SqlDataAdapter(cmd);
             daCategoria.SelectCommand.CommandType = CommandType.StoredProcedure;
             dtCategoria = new DataTable();
             daCategoria.Fill(dtCategoria);
             grid.DataSource = dtCategoria;

             con.Close();
         }
             */
        }
    }
}

/*
 *    //var builder = new MySqlConnectionStringBuilder
            //{
            //    Server = "YOUR-SERVER.mysql.database.azure.com",
            //    Database = "YOUR-DATABASE",
            //    UserID = "USER@YOUR-SERVER",
            //    Password = "PASSWORD",
            //    SslMode = MySqlSslMode.Required,
            //}; 
 */