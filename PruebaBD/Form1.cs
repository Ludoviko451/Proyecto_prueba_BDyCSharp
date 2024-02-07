using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace PruebaBD
{
    public partial class Form1 : Form
    {
        string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        string bd = "mysql"; //Nombre de la base de datos
        string usuario = "root"; //Usuario de acceso a MySQL
        string password = "password"; //Contrase�a de usuario de acceso a MySQL
        string datos = ""; //Variable para almacenar el resultado

        //Crearemos la cadena de conexi�n concatenando las variables
        //string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

        //Instancia para conexi�n a MySQL, recibe la cadena de conexi�n
        MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database=prueba; Uid=root; pwd=;");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    MessageBox.Show("La conexi�n a la BD: " + conexion.Database + " ha sido exitosa");
                }
                else
                {
                    MessageBox.Show("La conexi�n ya est� abierta.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexi�n: " + ex.Message);
            }

            Picturebox1.Image = PruebaBD.Properties.Resources.on;
        }
        

        private void DESCONECTARSE_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("Se ha desconectado correctamente");
            Picturebox1.Image = PruebaBD.Properties.Resources.off;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string query;
            if (string.IsNullOrWhiteSpace(txt_pais.Text))
            {
                query = "SELECT * FROM persona";
            }
            else
            {
                string pais = txt_pais.Text;
                query = $"SELECT * FROM persona WHERE pais = '{pais}'";
            }

            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            grid_datos.DataSource = tabla;

            txt_pais.Text = "";
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string query;
            if (!string.IsNullOrWhiteSpace(txt_paisAgregar.Text) & !string.IsNullOrWhiteSpace(txt_nombreAgregar.Text))
            {
                query = $"INSERT INTO persona (nombre, pais) VALUES ('{txt_nombreAgregar.Text}', '{txt_paisAgregar.Text}') ";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Persona ingresada exitosamente");

                txt_nombreAgregar.Text = "";
                txt_paisAgregar.Text = "";
            }
            else
            {
                MessageBox.Show("Faltan llenar los campos");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verifica si el TextBox txt_nombreAgregar no est� vac�o ni contiene solo espacios en blanco
            if (!string.IsNullOrWhiteSpace(txt_nombreAgregar.Text))
            {
                // Construye la consulta SQL para seleccionar la persona con el nombre especificado
                string querySelect = $"SELECT COUNT(*) FROM persona WHERE Nombre = '{txt_nombreAgregar.Text}'";
                MySqlCommand comandoSelect = new MySqlCommand(querySelect, conexion);

                // Ejecuta la consulta SQL y obtiene el n�mero de filas seleccionadas (deber�a ser 1 si existe la persona)
                int rowCount = Convert.ToInt32(comandoSelect.ExecuteScalar());

                // Verifica si se encontr� exactamente una persona con el nombre especificado
                if (rowCount == 1)
                {
                    // Construye la consulta SQL para eliminar la entrada en la base de datos
                    string queryDelete = $"DELETE FROM persona WHERE Nombre = '{txt_nombreAgregar.Text}'";
                    MySqlCommand comandoDelete = new MySqlCommand(queryDelete, conexion);

                    // Ejecuta la consulta SQL para eliminar la entrada de la base de datos
                    comandoDelete.ExecuteNonQuery();

                    // Muestra un mensaje informando al usuario que la persona ha sido eliminada exitosamente
                    MessageBox.Show($"La persona con el nombre : {txt_nombreAgregar.Text} ha sido eliminada exitosamente");
                }
                else
                {
                    // Muestra un mensaje indicando que la persona no existe
                    MessageBox.Show("No se encontr� ninguna persona con ese nombre");
                }
            }
            else
            {
                // Muestra un mensaje de advertencia si el TextBox est� vac�o o contiene solo espacios en blanco
                MessageBox.Show("Faltan llenar campos");
            }

            // Limpia el contenido del TextBox txt_nombreAgregar despu�s de eliminar la entrada
            txt_nombreAgregar.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_nombreAgregar.Text))
            {
                // Construye la consulta SQL para seleccionar la persona con el nombre especificado
                string querySelect = $"SELECT COUNT(*) FROM persona WHERE Nombre = '{txt_nombreAgregar.Text}'";
                MySqlCommand comandoSelect = new MySqlCommand(querySelect, conexion);

                // Ejecuta la consulta SQL y obtiene el n�mero de filas seleccionadas (deber�a ser 1 si existe la persona)
                int rowCount = Convert.ToInt32(comandoSelect.ExecuteScalar());

                // Verifica si se encontr� exactamente una persona con el nombre especificado
                if (rowCount == 1)
                {
                    if (!string.IsNullOrWhiteSpace(txt_nuevoNombre.Text) && !string.IsNullOrWhiteSpace(txt_nuevoPais.Text))
                    {
                        // Construye la consulta SQL para actualizar la entrada en la base de datos
                        string queryUpdate = $"UPDATE persona set Nombre = '{txt_nuevoNombre.Text}', Pais = '{txt_nuevoPais.Text}' WHERE nombre = '{txt_nombreAgregar.Text}'";
                        MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, conexion);

                        // Ejecuta la consulta SQL para actualizar la entrada de la base de datos
                        comandoUpdate.ExecuteNonQuery();

                        // Muestra un mensaje informando al usuario que la persona ha sido actualizada exitosamente
                        MessageBox.Show($"La persona con el nombre : {txt_nombreAgregar.Text} ha sido actualizada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Faltan llenar campos de actualizacion");
                    }
                }
                else
                {
                    // Muestra un mensaje indicando que la persona no existe
                    MessageBox.Show("No se encontr� ninguna persona con ese nombre");
                }
            }
            else
            {
                // Muestra un mensaje de advertencia si el TextBox est� vac�o o contiene solo espacios en blanco
                MessageBox.Show("Faltan llenar campos");
            }

            // Limpia el contenido del TextBox txt_nombreAgregar despu�s de eliminar la entrada
            txt_nombreAgregar.Text = "";
            txt_nuevoNombre.Text = "";
            txt_nuevoPais.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
