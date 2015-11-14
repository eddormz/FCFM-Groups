using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FG_v2
{
    delegate void entrante(Mensaje d);
    delegate void actualizacion(lista_usuarios l);

    public partial class FG : Form
    {
        List<Chat> Ventanas;
        private Socket conectado;
        private string email;
        private int id;

        EventHandler u;



        static IPAddress ip = IPAddress.Parse(Data.funciones.obtenersvr("2ND"));
        
        static Socket actua;

        public FG()
        {
            InitializeComponent();
        }

        public FG(Socket cliente, int iduser, String nom)
        {
            Ventanas = new List<Chat>();
            this.conectado = cliente;
            this.email = nom;
            this.id = iduser;
            InitializeComponent();
            Thread cs = new Thread(escuchar);
            cs.Start();
            actua= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            actua.Connect(ip,1807);
            Thread ac = new Thread(actualiza);
            ac.Start();

            



        }

        public void escuchar()
        {
            int readbytes;

            while (conectado.Connected)
            {
                Thread.Sleep(10);
                byte[] reciveBuffer = new byte[conectado.SendBufferSize];

                readbytes = conectado.Receive(reciveBuffer);

                if (readbytes > 0)
                {
                    Mensaje d = new Mensaje(reciveBuffer);


                    switch (d.tipoo)
                    {
                        case Mensaje.tipo.mensaje:
                            bool exist = false;
                                for (int i = 0; i < Ventanas.Count; i++) {
                                if (Ventanas[i].tipo == "Publico")
                                {
                                    Ventanas[i].MensajeEntrando(d);
                                    exist = true;
                                }
                                }
                            if (!exist)
                            {
                                try
                                {
                                    entrante dd = new entrante(newChat);

                                    this.Invoke(dd, new object[] { d });
                                }
                                catch
                                {
                                    MessageBox.Show("Error al Crear Nuevo Chat, Intentelo Nuevamente");
                                }
                            }

                            break;

                        case Mensaje.tipo.mensajeprivado:

                            break;

                        case Mensaje.tipo.zumbido:

                            break;

                        case Mensaje.tipo.video:

                            c_video c = new c_video(d.ip);
                            this.Controls.Add(c);

                            break;

                    }


                }

            }
            MessageBox.Show("Socket no conectado");
        }

        public void actualiza()
        {
            int readbytes;
            while (true)
            {
                byte[] reciveBuffer = new byte[actua.SendBufferSize];

                readbytes = actua.Receive(reciveBuffer);

                if (readbytes > 0)
                {
                    lista_usuarios d = new lista_usuarios(reciveBuffer);

                    actualizacion a = new actualizacion(actualiza2step);
                    this.Invoke(a, new object[] { d });
                }
            }
        }

        public void actualiza2step(lista_usuarios d)
        {
            flp_conectados.Controls.Clear();
            foreach (string[]i in d.lista)
            {
                if (int.Parse(i[1]) != this.id)
                {
                    c_conectado c = new c_conectado(i[0], int.Parse(i[1]), i[2]);
                    flp_conectados.Controls.Add(c);
                }
            }
        }

        private void newChat(Mensaje d)
        {
            Chat s = new Chat(conectado, email);
            s.tipo = "Publico";
            s.MensajeEntrando(d);
            if (flp_chats.Controls.Count < 3)
            {
                Ventanas.Add(s);
                flp_chats.Controls.Add(s);
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            Chat s = new Chat(conectado,email);
            s.tipo = "Publico";
            if (flp_chats.Controls.Count < 3){
                Ventanas.Add(s);
                flp_chats.Controls.Add(s);
             }
        }
        

        private void clock_Tick(object sender, EventArgs e)
        {
            if (Ventanas != null)
            {
                for (int i = 0; i < Ventanas.Count; i++)
                {
                    if (Ventanas[i].cerrar == true)
                    {
                        flp_chats.Controls.Remove(Ventanas[i]);
                        Ventanas[i].Dispose();
                        Ventanas.Remove(Ventanas[i]);

                    }
                }
            }
        }

        private void FG_Load(object sender, EventArgs e)
        {
            
        }
    }
}