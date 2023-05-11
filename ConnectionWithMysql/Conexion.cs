using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ConnectionWithMysql
{
    public class Conexion
    {
        public string Conectar(string host,  string usuario, string password, string bd)
        {
            string cadenaConexion = "Server=" + host + ", Database = " + bd + ", User ID=" + usuario + ", Password=" + password + "";
            //string cadenaConexion = "Server=" + host + "; Database = " + bd + "; UserID=" + usuario + "; Password=" + password + "";
            //string connectionString = "Server=localhost;Database=nombre_de_tu_base_de_datos;Uid=usuario_de_mysql;Pwd=contraseña_de_mysql;";
            //using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            //con = DriverManager.getConnection("jdbc:mysql://localhost:3306/BibliotecaD","root","");
            //{
            //    //Abrir la conexión
            //    connection.Open();
            //}
            return cadenaConexion;
            //return "Server=" + host + ", Database = " + bd + ", User ID=" + usuario + ", Password=" + password + "";

            //return "Database=" + bd + "; Data Source=" + host + "; User Id=" + usuario + "; Password=" + password + "";
        }
    }
}
