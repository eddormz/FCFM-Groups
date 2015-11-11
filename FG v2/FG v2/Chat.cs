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

namespace FG_v2
{
    public partial class Chat : UserControl
    {
        public static int id;
        public bool cerrar;
        public String tipo;
        Socket local;
        string correo;
        Mensaje d;

        public Chat(Socket c,String correo)
        {
            local = c;
            this.correo = correo;
            cerrar=false;
            InitializeComponent();
        }

        public void btn_cerrar_Click(object sender, EventArgs e)
        {
            cerrar = true;
        }

        public void MensajeEntrando(Mensaje m)
        {
            d = m;
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
            if (d != null)
            {
                txt_recibido.Text += "\n" + d.mensaje;
                d = null;
            }
        }
    }
}
