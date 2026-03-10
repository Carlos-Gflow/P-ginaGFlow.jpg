using MySql.Data.MySqlClient;
using proyecto_con_base_de_datos.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_con_base_de_datos
{

    public partial class Form2 : Form
    {
        //hago un hash de la contraseña
        string HashPassword(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //confirmo que el nombre y el correo no están vacíos
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("Por favor, rellena al menos el Nombre y el Correo.");
                    return; // Detiene el código aquí para que no intente hacer el INSERT ni que haya problemas 
                }

                // Abrir la conexión
                Connection.connOpen();

                // Obtener el texto del campo de texto
                string nombre = textBox1.Text;
                string primer_apellido = textBox2.Text;
                string segundo_apellido = textBox3.Text;
                string DNI = textBox4.Text;
                string telefono = textBox5.Text;
                string Direccion = textBox6.Text;
                string correo = textBox7.Text;
                int rol = checkBox1.Checked ? 1 : 0;
                string GenerarContraseña = GenerarContraseñaAleatoria(8);


                string consultaExiste = $"SELECT COUNT(*) FROM usuario WHERE correo = '{correo}'";
                MySqlCommand cmdCheck = new MySqlCommand(consultaExiste, Connection.connMaster);

                // ExecuteScalar devuelve un solo valor (en este caso, el número de filas encontradas)
                int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                //confirmamos que no existe y seguimos con el codigo
                if (existe > 0)
                {
                    MessageBox.Show("Este correo ya está registrado. Por favor, usa otro.");
                    return; // Detenemos el proceso aquí
                }

                // Crear la consulta SQL
                string query = $"INSERT INTO usuario (nombre, primer_apellido, segundo_apellido, DNI, correo, Dirección, telefono, contraseña, rol) VALUES ('{nombre}','{primer_apellido}','{segundo_apellido}','{DNI}','{correo}','{Direccion}','{telefono}','{HashPassword(GenerarContraseña)}',{rol})";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, Connection.connMaster);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Texto guardado correctamente en la base de datos"); // Ejecutar la consulta SQL
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se han insertado los datos correctamente" + ex.Message);
                    return;
                }
                try
                {
                    data.correo newEmail = new data.correo();
                    newEmail.enviarCorreo(correo, "Alta " + nombre, nombre, GenerarContraseña);
                    MessageBox.Show("correo enviado de manera exitosa");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el correo: " + ex.Message);
                    return;
                }


                //borro todos los campos de texto
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                checkBox1.Checked = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el texto en la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                Connection.connClose();
            }
        }//funcion boton


        // Función para crear la contraseña aleatoria
        public string GenerarContraseñaAleatoria(int longitud)
        {
            try
            {
                //contraseña aleatoria con ese banco de caracteres
                const string caracteres = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789";
                Random rnd = new Random();
                char[] resultado = new char[longitud];
                for (int i = 0; i < longitud; i++)
                {
                    resultado[i] = caracteres[rnd.Next(caracteres.Length)];
                }
                MessageBox.Show("contraseña aleatoria generada correctamente");
                //aquí se crea la contraseña
                return new string(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("la contraseña no se ha generado correctamente por: " + ex.Message);
                return "";
            }
        }//funcion generar contraseña

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }


    }//clase form 2
}//nameSpace