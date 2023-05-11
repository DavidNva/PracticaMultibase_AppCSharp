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
using MySql.Data.MySqlClient;

namespace ConnectionWithMysql
{
    public partial class Form1 : Form
    {
        Operaciones operaciones = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void mostrarDatos()
        {
            string host = txtHost.Text;
            string bd = txtUsuario.Text;
            string usuario = txtPassword.Text;
            string password = txtBD.Text;
            MySqlConnection con = new MySqlConnection(Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password));
            try
            {
                // Abre la conexión
                con.Open();

                // Crea una consulta SQL para seleccionar todos los registros de una tabla
                string sql = "SELECT * FROM proveedorMySQL";

                // Ejecuta la consulta y obtiene los resultados
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Carga los resultados en el control DataGridView
                dgvDatosMySQL.DataSource = dt;
                txtIDMySql.Text = "";
                txtNombreMySql.Text = "";
                MessageBox.Show("El proceso se realizó con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cierra la conexión
                con.Close();
            }
        }
        private void btnProbarConexión_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
        public void InsertarDatos()
        {
            string host = txtHost.Text;
            string bd = txtUsuario.Text;
            string usuario = txtPassword.Text;
            string password = txtBD.Text;

            // Set up a connection string
            //string connString = Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password);
            string connString = Operaciones.ObtenerCadenaSql();
            // Create a new MySqlConnection object
            SqlConnection conn = new SqlConnection(connString);

            // Open the connection
            // Create a MySqlCommand object to execute the SQL query
            SqlCommand cmd = new SqlCommand("insertarProveedorMySQL", conn);
            cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                                                          //cmd.Parameters.AddWithValue("@IdLibro", usuario.IdUsuario);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                          //el parametro @distrito nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
            cmd.Parameters.AddWithValue("@IDProveedor", txtIDMySql.Text);//Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
            cmd.Parameters.AddWithValue("@Nombre", txtNombreMySql.Text);
            cmd.Parameters.AddWithValue("@Calle", txtCalleMySql.Text);

            conn.Open();//Abrimos la conexion
            cmd.ExecuteNonQuery();//Ejecutamos la consulta
            mostrarDatos();
            conn.Close();//Cerramos la conexión
            
            // Close the connection

        }
        public void ActualizarDatos()
        {
            string host = txtHost.Text;
            string bd = txtUsuario.Text;
            string usuario = txtPassword.Text;
            string password = txtBD.Text;
            // Set up a connection string
            string connString = Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password);


            // Create a new MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "UPDATE Categoria SET Categoria = @Categoria WHERE IdCategoria = @id"; // Reemplaza "Usuarios" por el nombre de tu tabla, "Nombre" por el campo que deseas actualizar, y "Id" por el campo que identifica al registro a actualizar

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Categoria", txtNombreMySql.Text); // Reemplaza "Nuevo nombre" por el nuevo valor que deseas asignar al campo "Nombre"
                cmd.Parameters.AddWithValue("@id", txtIDMySql.Text); // Reemplaza "1" por el valor que identifica al registro que deseas actualizar
                conn.Open();
                cmd.ExecuteNonQuery();
                mostrarDatos();
                conn.Close();
            }

        }
        public void EliminarDatos()
        {
            string host = txtHost.Text;
            string bd = txtUsuario.Text;
            string usuario = txtPassword.Text;
            string password = txtBD.Text;
            // Set up a connection string
            string connString = Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password);


            // Create a new MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "DELETE FROM  Categoria WHERE IdCategoria = @id"; // Reemplaza "Usuarios" por el nombre de tu tabla, "Nombre" por el campo que deseas actualizar, y "Id" por el campo que identifica al registro a actualizar

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                //cmd.Parameters.AddWithValue("@Categoria", txtCategoria.Text); // Reemplaza "Nuevo nombre" por el nuevo valor que deseas asignar al campo "Nombre"
                cmd.Parameters.AddWithValue("@id", txtIDMySql.Text); // Reemplaza "1" por el valor que identifica al registro que deseas actualizar
                conn.Open();
                cmd.ExecuteNonQuery();

                mostrarDatos();
                conn.Close();
            }

        }
        
        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            pasarInfoATextBox();
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            pasarInfoATextBox();
        }
        private void pasarInfoATextBox(){
            if (dgvDatosMySQL.SelectedRows.Count > 0 && cmbOperacionMySQL.SelectedIndex == 0)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosMySQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes
                txtIDMySql.Text = "";
                txtNombreMySql.Text = "";

            }
            if (dgvDatosMySQL.SelectedRows.Count > 0 && cmbOperacionMySQL.SelectedIndex == 1)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosMySQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes
                txtIDMySql.Text = dgvDatosMySQL.CurrentRow.Cells[0].Value.ToString();
                txtNombreMySql.Text = dgvDatosMySQL.CurrentRow.Cells[1].Value.ToString();

            }
            if (dgvDatosMySQL.SelectedRows.Count > 0 && cmbOperacionMySQL.SelectedIndex == 2)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosMySQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes

                txtIDMySql.Text = dgvDatosMySQL.CurrentRow.Cells[0].Value.ToString();

                txtNombreMySql.Text = dgvDatosMySQL.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void btnRealizarMySQL_Click(object sender, EventArgs e)
        {
            string operacion = cmbOperacionMySQL.Text;
            Console.WriteLine(operacion);
            switch (operacion)
            {
                case "Insertar":
                    try
                    {
                        InsertarDatos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;

                case "Eliminar":
                    EliminarDatos();
                    break;

                case "Actualizar":
                    ActualizarDatos();
                    /*
                     * if (dgvDatos.SelectedRows.Count > 0)
              {
                  // Get the selected row's data
                  DataRow dataRow = ((DataRowView)dgvDatos.SelectedRows[0].DataBoundItem).Row;

                  // Update the text boxes
                  txtIDCategoria.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                  txtCategoria.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();

              }
                     */

                    break;
                default:
                    break;
            }
        }
        SqlCommand cmd;
        SqlParameter par;
        DataSet dst;
        SqlDataAdapter da;
        DataTable dt;
        private void btnFragmentacion_Click(object sender, EventArgs e)
        { 
            string host = txtHost.Text;
            string bd = txtUsuario.Text;
            string usuario = txtPassword.Text;
            string password = txtBD.Text;
            SqlConnection cn = new SqlConnection(Operaciones.ObtenerCadenaSql());
            //MySqlConnection con = new MySqlConnection(Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password));
            try
            {
               
                SqlCommand cmd = new SqlCommand("mostrarProveedores", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                //cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                //cmd.Parameters.AddWithValue("@Titulo", buscar);
                da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da.Fill(dt);
                dgvConsultaFragmentacion.DataSource = dt;
                //cn.Open();
                //if (dst == null)
                //{
                //    dst = new DataSet();
                //}
                //if(da == null)
                //{
                //    da = new SqlDataAdapter("exec mostrarProveedores", cn);
                //}
                //dst.Clear();
                //da.Fill(dst, "dgvConsultaFragmentacion");
                //dst = null;
                //da = null;
                //cn.Close();

                //MySqlCommand cmd = new MySqlCommand(sql, con);
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);

                //// Carga los resultados en el control DataGridView
                //dgvDatosMySQL.DataSource = dt;
                MessageBox.Show("El proceso se realizó con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Cierra la conexión
                    cn.Close();
                }
            }
        }
    
}
