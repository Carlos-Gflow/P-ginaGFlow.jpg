using MySql.Data.MySqlClient;
using proyecto_con_base_de_datos.data; // Tu carpeta con la clase Connection
using System;
using System.Windows.Forms;

namespace proyecto_con_base_de_datos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Importante: Suscribir el evento Load si no lo hiciste desde el diseño
            this.Load += new System.EventHandler(this.Form3_Load);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connOpen(); // Quitamos el "Data."
                string query = $"UPDATE usuario SET nombre='{textBox1.Text}', primer_apellido='{textBox2.Text}', segundo_apellido='{textBox3.Text}', dni='{textBox4.Text}', telefono='{textBox5.Text}', Dirección='{textBox6.Text}' WHERE correo='{Connection.UsuarioLogueado}'";

                MySqlCommand cmd = new MySqlCommand(query, Connection.connMaster);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
            finally
            {
                Connection.connClose();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.connOpen();
                string query = $"SELECT * FROM usuario WHERE correo = '{Connection.UsuarioLogueado}'";
                MySqlCommand cmd = new MySqlCommand(query, Connection.connMaster);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["nombre"].ToString();
                    textBox2.Text = reader["primer_apellido"].ToString();
                    textBox3.Text = reader["segundo_apellido"].ToString();
                    textBox4.Text = reader["dni"].ToString();
                    textBox5.Text = reader["telefono"].ToString();
                    textBox6.Text = reader["Dirección"].ToString();
                    textBox7.Text = reader["correo"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                Connection.connClose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Preguntamos para evitar accidentes
            DialogResult result = MessageBox.Show("¿Seguro que quieres BORRAR tu cuenta? No podrás volver a entrar.", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Connection.connOpen();
                    // Usamos DELETE para eliminar la fila de la tabla
                    string query = $"DELETE FROM usuario WHERE correo = '{Connection.UsuarioLogueado}'";

                    MySqlCommand cmd = new MySqlCommand(query, Connection.connMaster);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente");
                        // Al no existir ya el usuario, limpiamos la variable y salimos
                        Connection.UsuarioLogueado = "";
                        Application.Exit(); // O volver al Form1
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el usuario: " + ex.Message);
                }
                finally
                {
                    Connection.connClose();
                }
            }
        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            // 1. Limpiamos la variable global para que el sistema "olvide" quién entró
            Connection.UsuarioLogueado = "";

            // 2. Creamos el Form1 y lo mostramos
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();

            // 3. Cerramos definitivamente el Form3
            this.Close();
        }
    }
}