using System;
using Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace FG_v2
{
    public partial class inicio : Form
    {
        // static IPAddress ip = IPAddress.Parse(Data.funciones.obtenersvr("2ND"));
        static IPAddress ip = IPAddress.Parse("127.0.0.1");

        IPEndPoint ipe = new IPEndPoint(ip, 1806);
        static Socket cliente;

        public inicio()
        {
            InitializeComponent();
            cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void bt_In_Click(object sender, EventArgs e)
        {
            

            try
            {

                Mensaje d = new Mensaje();
                d.nombre = tb_correo.Text;
                d.contrasenia = tb_contra.Text;
                d.ip = Data.funciones.obtenerip();
                byte[] entrando = new byte[cliente.SendBufferSize];

                cliente.Connect(ip, 1806);

                //La cadena de string la convertimos en un arreglo de bytes para enviarla
                cliente.Send(d.toBytes());

                cliente.Receive(entrando);
                Mensaje n = new Mensaje(entrando);

                if (n.iduser > 0)
                {
                    FG main = new FG(cliente, n.iduser,tb_correo.Text);
                    main.Show();
                    Hide();
                }
                else
                {
                    cliente.Close();
                    Application.Restart();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error conectando al cliente: " + ex.ToString());
            }


        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            cliente.Connect(ip, 1806);
            registrar r = new registrar(cliente);
            r.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }
    }
}
