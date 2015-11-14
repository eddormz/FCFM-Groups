using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Data;
using System.IO;
using System.Collections;

namespace FG_v2
{
    delegate void SetTextCallback(string text);

    public partial class Chat : UserControl
    {
        public static int id;
        public bool cerrar;
        public String tipo;
        Socket local;
        string correo;
       
        private Hashtable emoticons;

        public Chat(Socket c,String correo)
        {
            local = c;
            id = 0;
            this.correo = correo;
            cerrar=false;
            InitializeComponent();
            CrearEmoticones();
        }

        public void btn_cerrar_Click(object sender, EventArgs e)
        {
            cerrar = true;
        }
         
        #region Mensaje

        public void MensajeEntrando(Mensaje m)
        {
            try
            {
                SetTextCallback dd = new SetTextCallback(escribirmsj);

                this.Invoke(dd, new object[] { m.mensaje });
            }
            catch
            {
                MessageBox.Show("Error al Escribir mensaje en archivo, Intentelo Nuevamente");
            }

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            Mensaje h = new Mensaje();
            h.tipoo = Mensaje.tipo.mensaje;
            h.mensaje = correo + ": " + txt_enviar.Text;
            local.Send(h.toBytes());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void escribirmsj(string text)
        {

            if (!Directory.Exists("historial\\"))
            {
                Directory.CreateDirectory("historial\\");
            }

            if (!File.Exists(tipo + id + ".txt"))
            {

                StreamWriter escrito = File.AppendText("historial\\" + tipo + id + ".txt");
                String contenido = text;
                //escribimos. 
                escrito.WriteLine(contenido.ToString());
                escrito.Flush();
                //Cerramos 
                escrito.Close();
                //Vaciamos 
                this.txt_recibido.Text = "";
                leer();
            }
            else
            {
                StreamWriter escrito = File.AppendText("historial\\" + tipo + id + ".txt");
                String contenido = text;
                //escribimos. 
                escrito.WriteLine(contenido.ToString());
                escrito.Flush();
                //Cerramos 
                escrito.Close();
                //Vaciamos 
                this.txt_recibido.Text = "";
                leer();
            }

        }

        private void leer()
        {
            this.txt_recibido.Clear();
            StreamReader leido = File.OpenText("historial\\" + tipo+id+".txt");
            //Variable que contendrá el archivo 
            string contenido = null;
            //Leemos todo el archivo 
            contenido = leido.ReadToEnd();
            //Lo mostramos 
            this.txt_recibido.Text = contenido.ToString();
            //Cerramos 
            leido.Close();
        }
        #endregion

        #region Emoticones
        private void txt_recibido_TextChanged(object sender, EventArgs e)
        {
            AgregarEmoticon();
        }
       
        public void CrearEmoticones()
        {
            emoticons = new Hashtable(16);
            emoticons.Add(":)", "smile");
            emoticons.Add(":D", "grin");
            emoticons.Add(":o", "surprised");
            emoticons.Add(":p", "tongue_smile");
            emoticons.Add(";)", "wink");
            emoticons.Add(":(", "sad");
            emoticons.Add(":s", "confused");
            emoticons.Add(":|", "dissapointed");
            emoticons.Add(":'(", "crying");
            emoticons.Add(":$", "shy");
            emoticons.Add("(H)", "cool");
            emoticons.Add(":@", "angry");
            emoticons.Add("(A)", "angel");
            emoticons.Add("(6)", "devil");
            emoticons.Add(":#", "dont_tell");
            emoticons.Add("8|", "teeth");
        }

        public void AgregarEmoticon()
        {
            foreach (string emoticon in emoticons.Keys)
            {
                while (txt_recibido.Text.Contains(emoticon))
                {
                    int ind = txt_recibido.Text.IndexOf(emoticon);
                    txt_recibido.Select(ind, emoticon.Length);
                    StreamReader sr = File.OpenText("emoticons/" + emoticons[emoticon] + ".rtf");
                    txt_recibido.SelectedRtf = sr.ReadToEnd();
                    sr.Close();
                    txt_recibido.SelectionStart = txt_recibido.TextLength;
                    txt_recibido.ScrollToCaret();
                }
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            if (tipo == "Publico")
            {
                btn_video.Hide();
            }
        }

        private void btn_video_Click(object sender, EventArgs e)
        {

        }

        private void btn_emoticon_Click(object sender, EventArgs e)
        {
            p_icons.Visible = true;
        }

        private void btn_tonge_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text+=":p";
        }

        private void btn_wink_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ";)";
        }

        private void btn_sot_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":#";
        }

        private void btn_dissa_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":|";
        }

        private void btn_shy_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":$";
        }

        private void btn_smile_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
        }

        private void btn_surprised_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
        }

        private void btn_teeh_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += "8|";
        }

        private void btn_crying_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":'(";
        }

        private void btn_devil_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += "(6)";
        }

        private void btn_grin_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":D";
        }

        private void btn_sad_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":(";
        }

        private void btn_angel_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += "(A)";
        }

        private void btn_angry_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":@";
        }

        private void btn_confused_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += ":s";
        }

        private void btn_cool_Click(object sender, EventArgs e)
        {
            p_icons.Visible = false;
            txt_enviar.Text += "(H)";
        }
        #endregion

    }

}
