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
        CheckBox chkUsuario = null;
        List<CheckBox> chkUsuarios = new List<CheckBox>();

        public correo(int idGrupo, int id, String mail)
        {
            InitializeComponent();
            txtCorreo.Text = mail;
            DataSourcePOI dsp = new DataSourcePOI();
            DataTable dt = dsp.getUsuariosMail(idGrupo, id);

            if (dt != null)
            {
                for (int bc = 0; bc < dt.Rows.Count; bc++)
                {
                    chkUsuario = new CheckBox();
                    chkUsuario.Text = dt.Rows[bc][0].ToString();

                    chkUsuario.AutoSize = true;
                    chkUsuario.CheckedChanged += new EventHandler(chkUsuarioSeleccionados);
                    flowLayoutPanel1.Controls.Add(chkUsuario);

                }
            }

        }

        public void chkUsuarioSeleccionados(object sender, EventArgs e)
        {
            chkUsuario = (CheckBox)sender;
            if (chkUsuario.Checked)
                chkUsuarios.Add((CheckBox)sender);
            else
                chkUsuarios.Remove(chkUsuario);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           sendMail();
        }

        public void sendMail()
        {
            String to = "";
            for (int bc = 0; bc < chkUsuarios.Count(); bc++)
            {
                to += chkUsuarios[bc].Text;
                if (chkUsuarios.Count() - 1 != bc)
                    to += "; ";
            }
                String from = txtCorreo.Text;
                
                String subject = txtAsunto.Text;
                String body = rtxtContenido.Text;
                String smtpClient = "smtp.gmail.com";
                String username = "pro.papw@gmail.com";
                String password = "#queonda";

                if (from == "" || to == "" || subject == "" || body == "" || username == "" || password == "")
                {
                    MessageBox.Show("Faltan Campos");
                    return;
                }

                try
                {
                    MailMessage mail = new MailMessage(from, to, subject, body);
                    SmtpClient client = new SmtpClient(smtpClient, 587);
                    client.Credentials = new NetworkCredential(username, password);
                    client.EnableSsl = true;
                    client.Send(mail);
                    MessageBox.Show("El correo se ha enviado exitosamente", "Correo Enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAsunto.Text = "";
                rtxtContenido.Text = "";
                }
                catch (Exception ex)
                {
                }
            
        }
    }
}
