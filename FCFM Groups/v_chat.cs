using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFM_Groups
{
    public partial class v_chat : Form
    {
        Socket local;
        Mensaje data;
        String nombre;
        

        public v_chat(Socket local,String g)
        {
            InitializeComponent();
            this.local = local;
            nombre = g;
        }

        public void MensajeLlego(Mensaje d) {
            data= d;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mensaje h = new Mensaje();
            h.tipoo = Mensaje.tipo.mensaje;
            h.setMsj(nombre + " " + textBox3.Text);

            local.Send(h.toBytes());


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (data!= null) {
                richTextBox3.Text += "\n"+data.getMsj();
                data = null;
            }
        }

        private void v_chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void v_chat_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
