using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

//recomendado por gemini
using System.Net;
using System.Net.Mail;
using System.IO;

namespace proyecto_con_base_de_datos.data
{
    internal class correo
    {
        public void enviarCorreo(string _to, string _subject, string _nombre, string _Contraseña)
        {
            // Dirección de correo electrónico del remitente
            string from = "cgarcia@itpfp.com";
            // Contraseña generada de la cuenta de correo electrónico del remitente
            string password = "mqye sngk mdcb pnne";
            // establecemos el Alias
            string alias = "ITP";


            // Cuerpo del correo electrónico
            string body;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\HTMLPage1.html");

            using (StreamReader reader = new StreamReader(filePath))
            {
                body = reader.ReadToEnd();
            }

            // Reemplazar el texto
            body = body.Replace("nn", _nombre).Replace("**", _Contraseña);

            // Configuración del mensaje
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from, alias);
            mail.To.Add(_to);
            mail.Subject = _subject;
            mail.Body = body;
            mail.IsBodyHtml = true;


            // 3. Configurar el cliente SMTP y enviar
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential(from, password);
            smtpClient.EnableSsl = true; // Establecer EnableSsl en true

            try
            {
                // Enviar el correo electrónico
                smtpClient.Send(mail);
                MessageBox.Show("Correo enviado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message);
            }

        }
    }
}
