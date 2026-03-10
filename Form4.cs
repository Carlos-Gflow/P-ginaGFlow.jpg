using MySql.Data.MySqlClient;
using proyecto_con_base_de_datos.data;
using System;
using System.Data;
using System.Windows.Forms;

namespace proyecto_con_base_de_datos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Esto hace que la tabla se cargue sola al abrir
            this.Load += new EventHandler(Form4_Load);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                Connection.connOpen();
                string query = "SELECT nombre, primer_apellido, correo, dni, telefono FROM usuario";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connection.connMaster);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { Connection.connClose(); }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("nombre LIKE '{0}%'", textBox8.Text);
            }
        }

        // --- SOLO TIENES QUE AÑADIR ESTO DE AQUÍ ABAJO ---

        // BOTÓN EDITAR: Pasa los datos de la tabla a los cuadros 1-7
        public void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Usamos los nombres exactos de tus columnas (con Mayúscula)
                textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();

                textBox7.Enabled = false;
            }
        }

        // BOTÓN ELIMINAR: Borra de la base de datos
        public void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Corregido: "Correo" con C mayúscula
                var valorCelda = dataGridView1.CurrentRow.Cells["Correo"].Value;

                if (valorCelda != null)
                {
                    string correo = valorCelda.ToString();

                    if (MessageBox.Show("¿Borrar a " + correo + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            Connection.connOpen();
                            // Aquí usamos "correo" en minúscula porque es el nombre en MySQL
                            string sql = "DELETE FROM usuario WHERE correo = '" + correo + "'";
                            MySqlCommand cmd = new MySqlCommand(sql, Connection.connMaster);
                            cmd.ExecuteNonQuery();
                            CargarDatos();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally { Connection.connClose(); }
                    }
                }
            }
        }

        // BOTÓN GUARDAR: Actualiza los datos
        public void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connOpen();
                // Actualizamos nombre y apellido usando el correo como filtro
                string sql = "UPDATE usuario SET nombre='" + textBox1.Text + "', primer_apellido='" + textBox2.Text + "' WHERE correo='" + textBox7.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.connMaster);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario Actualizado");
                textBox7.Enabled = true;
                CargarDatos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Connection.connClose(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}