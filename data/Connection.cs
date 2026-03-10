using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_con_base_de_datos.data
{
    class Connection
    {
        public static string UsuarioLogueado;

        public static MySqlConnection connMaster = new MySqlConnection();

        public static string Server = "127.0.0.1";
        public static string Data = "login";
        public static string User = "root";
        public static string Password = "";




        public static MySqlConnection DataSource() {
            

            string conectionString = $"server={Server};database={Data};user={User};password={Password}";
            
            connMaster = new MySqlConnection(conectionString);
            
            return connMaster;
        
        }

        public static void connOpen() {

            try
            {

                DataSource();
                connMaster.Open();
                MessageBox.Show("conexión exitosa");

            }
            catch (Exception ex) { 
                
                MessageBox.Show("conexion fallida");
            }
        
        }

        public static void connClose() {

            DataSource();
            connMaster.Close();

        }
    }

}
