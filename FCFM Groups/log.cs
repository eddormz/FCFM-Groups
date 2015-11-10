using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Data;

namespace FCFM_Groups
{
    public partial class log : Form
    {
        static IPAddress ip = IPAddress.Parse(obtenersvr("2ND"));
        IPEndPoint ipe = new IPEndPoint(ip, 1806);
      static Socket cliente;
      

        public log()
        {
            InitializeComponent();
            cliente=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {

                Mensaje d = new Mensaje();
                d.nombre = txtUsuario.Text;
                d.contrasenia = txtContra.Text;
                d.ip = obtenerip();
                byte[] entrando = new byte[cliente.SendBufferSize];

                cliente.Connect(ip, 1806);

                //La cadena de string la convertimos en un arreglo de bytes para enviarla
                cliente.Send(d.toBytes());
                
                cliente.Receive(entrando);
                Mensaje n = new Mensaje(entrando);

                if (n.iduser > 0)
                {
                      
                    Form1 form1 = new Form1(cliente, n.iduser,txtUsuario.Text);
                    form1.Show();
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

        public static string obtenersvr(string host)

        {

            try

            {

                IPAddress[] ips = Dns.GetHostAddresses(host);

                foreach (IPAddress i in ips)

                {

                    if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)

                    {

                        return i.ToString();

                    }

                }



                return "127.0.0.1";

            }

            catch

            {

                //("Error al tratar de obtener IP de Servidor, Intentelo mas tarde");

                return null;

            }

        }

        public static IPAddress obtenerip()

        {

            try

            {

                IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());

                foreach (IPAddress i in ips)

                {

                    if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)

                    {

                        return i;

                    }

                }

                return IPAddress.Parse("127.0.0.1");

            }

            catch

            {

                //("Error al tratar de obtener IP, Intentelo mas tarde");

                return null;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
