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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_con_base_de_datos
{
    public partial class Form5 : Form
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
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                string correo = textBox1.Text; // El campo donde pone su correo

                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("Por favor, introduce tu correo.");
                    return;
                }

                Connection.connOpen();

                // 1. Verificamos si el usuario existe
                string consultaExiste = $"SELECT COUNT(*) FROM usuario WHERE correo = '{correo}'";
                MySqlCommand cmdCheck = new MySqlCommand(consultaExiste, Connection.connMaster);
                int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (existe > 0)
                {
                    // 2. Generamos la contraseña nueva y la hasheamos
                    string nuevaPassword = GenerarContraseñaAleatoria(8);
                    string passwordHasheada = HashPassword(nuevaPassword);

                    // 3. Actualizamos en la base de datos (usando 'contraseña' como en tu SQL)
                    string queryUpdate = $"UPDATE usuario SET contraseña = '{passwordHasheada}' WHERE correo = '{correo}'";
                    MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, Connection.connMaster);
                    cmdUpdate.ExecuteNonQuery();

                    // 4. Enviamos el correo (clase data.correo)
                    data.correo emailService = new data.correo();
                    emailService.enviarCorreo(correo, "Nueva contraseña", "Usuario", nuevaPassword);

                    MessageBox.Show("Se ha generado una nueva contraseña y se ha enviado a tu correo.");
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario no está registrado");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar: " + ex.Message);
            }
            finally
            {
                Connection.connClose();
            }

        }
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
    }
}
