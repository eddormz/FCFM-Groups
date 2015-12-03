using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//necesarias para el envio de correo por SMTP
using System.Web;
using System.Net;
using System.Net.Mail;

namespace FG_v2
{
    public partial class correo : Form
    {
        public correo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sendMail();
        }

        public void sendMail()
        {
            String from = txtCorreo.Text;
            //String to = txtPara.Text;
            String to = "a";
            String subject = txtAsunto.Text;
            String body = rtxtContenido.Text;
            String smtpClient = "smtp.gmail.com";
            String username = from;
            String password = txtContra.Text;

            if (from == "" || to == "" || subject == "" || body == "" || username == "" || password == "")
            {
                MessageBox.Show("Faltan Campos");
                return;
            }

            try
            {
                MailMessage mail = new MailMessage(from, to, subject, body);
                //Ej: smtp.gmail.com por el puerto 507
                SmtpClient client = new SmtpClient(smtpClient, 587);
                //Ej: paco@gmail.com 12345
                client.Credentials = new NetworkCredential(username, password);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Correo Enviado!", "El correo se ha enviado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
