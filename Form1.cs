using MySql.Data.MySqlClient;
using proyecto_con_base_de_datos.data;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Text;

namespace proyecto_con_base_de_datos
{
    public partial class Form1 : Form
    {
        string HashPassword(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Abrir la conexión
                Connection.connOpen();

                string correo = textBox1.Text;
                string passHasheada = HashPassword(textBox2.Text);


                string query = $"SELECT rol FROM usuario WHERE correo = '{correo}' AND contraseña = '{passHasheada}'";
                MySqlCommand cmd = new MySqlCommand(query, Connection.connMaster);

                // ExecuteScalar devuelve un solo valor
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    int rol = Convert.ToInt32(resultado);
                    data.Connection.UsuarioLogueado = correo;

                    if (rol == 1)
                    {
                        Form4 f4 = new Form4();
                        this.Hide();
                        f4.ShowDialog();
                    }
                    else
                    {
                        Form3 f3 = new Form3();
                        this.Hide();
                        f3.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                Connection.connClose();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }
    }
}
