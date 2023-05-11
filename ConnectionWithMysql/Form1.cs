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
        private void mostrarDatosMySQL()
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
                txtCalleMySql.Text = "";
                //MessageBox.Show("La consulta del proveedor MySql fué exitosa");
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
            mostrarDatosMySQL();
            MessageBox.Show("La consulta del proveedor MySql fué exitosa");
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
            mostrarDatosMySQL();
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
            string query = "UPDATE proveedorMySQL SET Nombre = @Nombre, Calle = @Calle WHERE IdProveedor = @IdProveedor"; // Reemplaza "Usuarios" por el nombre de tu tabla, "Nombre" por el campo que deseas actualizar, y "Id" por el campo que identifica al registro a actualizar

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nombre", txtNombreMySql.Text); // Reemplaza "Nuevo nombre" por el nuevo valor que deseas asignar al campo "Nombre"
                cmd.Parameters.AddWithValue("@Calle", txtCalleMySql.Text);
                cmd.Parameters.AddWithValue("@IdProveedor", txtIDMySql.Text); // Reemplaza "1" por el valor que identifica al registro que deseas actualizar
                conn.Open();
                cmd.ExecuteNonQuery();
                mostrarDatosMySQL();
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
            string query = "DELETE FROM proveedorMySQL WHERE IdProveedor = @IdProveedor";  // Reemplaza "Usuarios" por el nombre de tu tabla, "Nombre" por el campo que deseas actualizar, y "Id" por el campo que identifica al registro a actualizar

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
               
                cmd.Parameters.AddWithValue("@IdProveedor", txtIDMySql.Text); // Reemplaza "1" por el valor que identifica al registro que deseas actualizar
                conn.Open();
                cmd.ExecuteNonQuery();
                mostrarDatosMySQL();
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
                txtCalleMySql.Text = "";

            }
            if (dgvDatosMySQL.SelectedRows.Count > 0 && cmbOperacionMySQL.SelectedIndex == 1)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosMySQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes
                txtIDMySql.Text = dgvDatosMySQL.CurrentRow.Cells[0].Value.ToString();
                txtNombreMySql.Text = dgvDatosMySQL.CurrentRow.Cells[1].Value.ToString();
                txtCalleMySql.Text = dgvDatosMySQL.CurrentRow.Cells[2].Value.ToString();

            }
            if (dgvDatosMySQL.SelectedRows.Count > 0 && cmbOperacionMySQL.SelectedIndex == 2)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosMySQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes

                txtIDMySql.Text = dgvDatosMySQL.CurrentRow.Cells[0].Value.ToString();

                txtNombreMySql.Text = dgvDatosMySQL.CurrentRow.Cells[1].Value.ToString();
                txtCalleMySql.Text = dgvDatosMySQL.CurrentRow.Cells[1].Value.ToString();

            }
        }
        private void pasarInfoATextBoxSQL()
        {
            if (dgvDatosSQL.SelectedRows.Count > 0 && cmbOperacionSQL.SelectedIndex == 0)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosSQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes
                //txtIDSql.Text = "";
                //txtNombreSql.Text = "";
                //txtCalleSql.Text = "";

            }
            if (dgvDatosSQL.SelectedRows.Count > 0 && cmbOperacionSQL.SelectedIndex == 1)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosSQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes
                txtIDSql.Text = dgvDatosSQL.CurrentRow.Cells[0].Value.ToString();
                txtNombreSql.Text = dgvDatosSQL.CurrentRow.Cells[1].Value.ToString();
                txtCalleSql.Text = dgvDatosSQL.CurrentRow.Cells[2].Value.ToString();

            }
            if (dgvDatosSQL.SelectedRows.Count > 0 && cmbOperacionSQL.SelectedIndex == 2)
            {
                // Get the selected row's data
                DataRow dataRow = ((DataRowView)dgvDatosSQL.SelectedRows[0].DataBoundItem).Row;

                // Update the text boxes

                txtIDSql.Text = dgvDatosSQL.CurrentRow.Cells[0].Value.ToString();

                txtNombreSql.Text = dgvDatosSQL.CurrentRow.Cells[1].Value.ToString();
                txtCalleSql.Text = dgvDatosSQL.CurrentRow.Cells[2].Value.ToString();

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

                    break;
                default:
                    MessageBox.Show("Debes seleccionar una operacion", "Selecciona un tipo de Operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        //SqlCommand cmd;
        //SqlParameter par;
        //DataSet dst; 
        SqlDataAdapter da;
        DataTable dt;
        private void btnFragmentacion_Click(object sender, EventArgs e)
        {
            string operacion = cmbTipoFragmentacion.Text;
            Console.WriteLine(operacion);
            switch (operacion)
            {
                case "Horizontal":
                    //FragmentacionHorizontal();
                    break;

                case "Deriva":
                    //FragmentacionVertical();
                    break;

                case "HorizontalDeriva":
                    FragmentacionHorizontalDeriva();

                    break;

                default:
                    MessageBox.Show("Para realizar una consulta primero debes\nseleccionar un tipo de fragmentación","Selecciona un tipo de Fragmentación",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        /*Acciones para SQL*/
        private void mostrarDatosSQL()
        {
            SqlConnection cn = new SqlConnection(Operaciones.ObtenerCadenaSql());
            //MySqlConnection con = new MySqlConnection(Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password));
            try
            {

                SqlCommand cmd = new SqlCommand("mostrarProveedorServer", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                                        //cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                                        //cmd.Parameters.AddWithValue("@Titulo", buscar);
                da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da.Fill(dt);
                dgvDatosSQL.DataSource = dt;
                txtIDSql.Text = "";
                txtNombreSql.Text = "";
                txtCalleSql.Text = ""; 
                //// Carga los resultados en el control DataGridView
                //dgvDatosMySQL.DataSource = dt;
                //MessageBox.Show("El proceso se realizó con éxito");

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

        private void btnMostrarDatosSQL_Click(object sender, EventArgs e)
        {
            mostrarDatosSQL();
        }
        public void RegistrarDatosSQL()
        {
            SqlConnection cn = new SqlConnection(Operaciones.ObtenerCadenaSql());
            try
            { 
                SqlCommand cmd = new SqlCommand("insertarProveedor", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                                                              //cmd.Parameters.AddWithValue("@IdLibro", usuario.IdUsuario);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                              //el parametro @distrito nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                //Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
                cmd.Parameters.AddWithValue("@Nombre", txtNombreSql.Text); // Reemplaza "Nuevo nombre" por el nuevo valor que deseas asignar al campo "Nombre"
                cmd.Parameters.AddWithValue("@Calle", txtCalleSql.Text);
                cmd.Parameters.AddWithValue("@IdProveedor", txtIDSql.Text);
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("El proveedor de SQL se registró correctamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje
                mostrarDatosSQL();
            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Categoria", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }
        public void ActualizarDatosSQL()
        {
            SqlConnection cn = new SqlConnection(Operaciones.ObtenerCadenaSql());
            try
            {
                SqlCommand cmd = new SqlCommand("editarProveedorServer", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                                                              //cmd.Parameters.AddWithValue("@IdLibro", usuario.IdUsuario);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                              //el parametro @distrito nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                                                              //Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
                cmd.Parameters.AddWithValue("@Nombre", txtNombreSql.Text); // Reemplaza "Nuevo nombre" por el nuevo valor que deseas asignar al campo "Nombre"
                cmd.Parameters.AddWithValue("@Calle", txtCalleSql.Text);
                cmd.Parameters.AddWithValue("@IdProveedor", txtIDSql.Text);
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("El proveedor de SQL se actualizó correctamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje
                mostrarDatosSQL();
            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Categoria", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }
        public void EliminarDatosSQL()
        {
            SqlConnection cn = new SqlConnection(Operaciones.ObtenerCadenaSql());
            try
            {
                SqlCommand cmd = new SqlCommand("eliminarProveedorServer", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                                                              //cmd.Parameters.AddWithValue("@IdLibro", usuario.IdUsuario);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                              //el parametro @distrito nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                                                              //Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
                cmd.Parameters.AddWithValue("@IdProveedor", txtIDSql.Text);
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("El proveedor de SQL se eliminó correctamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje
                mostrarDatosSQL();
            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Categoria", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }

        private void btnRealizarSql_Click(object sender, EventArgs e)
        {
            string operacion = cmbOperacionSQL.Text;
            Console.WriteLine(operacion);
            switch (operacion)
            {
                case "Insertar":
                    try
                    {
                        RegistrarDatosSQL();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;

                case "Eliminar":
                    EliminarDatosSQL();
                    break;

                case "Actualizar":
                    ActualizarDatosSQL();

                    break;
                default:
                    MessageBox.Show("Debes seleccionar una operacion", "Selecciona un tipo de Operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void dgvDatosSQL_SelectionChanged(object sender, EventArgs e)
        {
            pasarInfoATextBoxSQL();
        }

        private void cmbOperacionSQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            pasarInfoATextBoxSQL();
        }

        /*Consultas de fragmentaciones tipos*/
        private void FragmentacionHorizontalDeriva()
        {
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
                lblTipoFragmentación.Text = "Consulta Fragmentacion Horizontal Deriva";
                MessageBox.Show("Se realizó la: " + lblTipoFragmentación.Text, lblTipoFragmentación.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
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
        private void FragmentacionHorizontal()
        {
            SqlConnection cn = new SqlConnection(Operaciones.ObtenerCadenaSql());
            //MySqlConnection con = new MySqlConnection(Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password));
            try
            {

                SqlCommand cmd = new SqlCommand("mostrarProveedoresHorizontal", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                //cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                //cmd.Parameters.AddWithValue("@Titulo", buscar);
                da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da.Fill(dt);
                dgvConsultaFragmentacion.DataSource = dt;
                lblTipoFragmentación.Text = "Consulta Fragmentacion Horizontal";
                MessageBox.Show("Se realizó la: " + lblTipoFragmentación.Text, lblTipoFragmentación.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void FragmentacionVertical()
        {
            SqlConnection cn = new SqlConnection(Operaciones.ObtenerCadenaSql());
            //MySqlConnection con = new MySqlConnection(Operaciones.ObtenerCadenaMySQL(host, bd, usuario, password));
            try
            {

                SqlCommand cmd = new SqlCommand("mostrarProveedoresVertical", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                //cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                //cmd.Parameters.AddWithValue("@Titulo", buscar);
                da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da.Fill(dt);
                dgvConsultaFragmentacion.DataSource = dt;
                lblTipoFragmentación.Text = "Consulta Fragmentacion Vertical";
                MessageBox.Show("Se realizó la: " + lblTipoFragmentación.Text, lblTipoFragmentación.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
