using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace FCFM_Groups
{
    public partial class Form1 : Form
    {
        v_chat chat;
        Persona contacto;
        Persona otra;

        public Form1(Socket cliente, int iduser)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chat = new v_chat();
            chat.MdiParent = this;
            chat.Show();
            
            contacto = new Persona("hola");
            contacto.MdiParent = this;
            contacto.Show();

            otra = new Persona("Dos");
            otra.MdiParent = this;
            otra.Show();

            flowLayoutPanel2.Controls.Add(contacto);
            flowLayoutPanel2.Controls.Add(otra);
        }
    }
}
