﻿using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
    delegate void SetZumbido(bool q);
    delegate void iniciarVideo(IPAddress ip);

    public partial class FG : Form
    {
        List<Chat> Ventanas;
        static public Socket conectado;
        private string email;
        private int id;
        bool hilo = true;
        SoundPlayer player;



        static IPAddress ip = IPAddress.Parse(Data.funciones.obtenersvr("2ND"));
        //static IPAddress ip = IPAddress.Parse("127.0.0.1");

        static Socket actua;

        public FG()
        {
            InitializeComponent();
        }

        public FG(Socket cliente, int iduser, String nom)
        {
            Ventanas = new List<Chat>();
            conectado = cliente;
            this.email = nom;
            this.id = iduser;
            InitializeComponent();
            Thread cs = new Thread(escuchar);
            cs.Start();
            actua= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            actua.Connect(ip,1807);
            Thread ac = new Thread(actualiza);
            ac.Start();
            player = new SoundPlayer("TD4W.wav");




        }

        public void escuchar()
        {
            int readbytes;

            while (hilo)
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

                            Mensaje zumba = new Mensaje();
                            zumba.mensaje = "Zumbido";
                            bool existz = false;

                            if (d.idDestino == 0)
                            {
                                
                                for (int i = 0; i < Ventanas.Count; i++)
                                {
                                    if (Ventanas[i].tipo == "Publico")
                                    {
                                        Ventanas[i].MensajeEntrando(d);
                                        existz = true;
                                    }
                                }
                                if (!existz)
                                {
                                    try
                                    {
                                        entrante dd = new entrante(newChat);

                                        this.Invoke(dd, new object[] { d });
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Error al Crear zumb Chat, Intentelo Nuevamente");
                                    }
                                }

                                #region Zumbido
                                
                                try
                                {
                                    SetZumbido dd = new SetZumbido(zumbido);

                                    this.Invoke(dd, new object[] { true });
                                }
                                catch
                                {
                                    MessageBox.Show("Error al recibir Zumbido, Intentelo Nuevamente");
                                }
                                break;
                                #endregion

                            }


                            break;

                        case Mensaje.tipo.video:

                            

                            iniciarVideo a = new iniciarVideo(vvf);
                            this.Invoke(a, new object[] { d.ip });

                            break;

                    }


                }

            }
            MessageBox.Show("Socket no conectado");
        }

        public void vvf(IPAddress i)
        {
            c_video c = new c_video(i);
            this.Controls.Add(c);
        }

        public void actualiza()
        {
            int readbytes;
            while (conectado.Connected)
            {
                try {
                    byte[] reciveBuffer = new byte[actua.SendBufferSize];

                    readbytes = actua.Receive(reciveBuffer);

                    if (readbytes > 0 && hilo == true)
                    {
                        lista_usuarios d = new lista_usuarios(reciveBuffer);

                        actualizacion a = new actualizacion(actualiza2step);
                        this.Invoke(a, new object[] { d });
                    }
                }
                catch
                {

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
            
            if (flp_chats.Controls.Count < 3)
            {
                Ventanas.Add(s);
                flp_chats.Controls.Add(s);
                s.MensajeEntrando(d);
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
                if (Ventanas.Count > 0)
                {
                    flp_chats.Visible = true;
                }
                else
                {
                    flp_chats.Visible = false;
                }
            }
            else
            {
                flp_chats.Visible = false;
            }
        }

        private void FG_Load(object sender, EventArgs e)
        {
            c_Publicacion p = new c_Publicacion();
            flp_publicacion.Controls.Add(p);

            for (int i = 0; i < 10; i++)
            {
                c_desplegar c = new c_desplegar("nombre"+i, "Toda la publicacion aqui", 1);

                for (int j = 0; j < 10; j++)
                {
                    Label l = new Label();
                    l.Text = "comentario"+j;
                    c.flp_comentarios.Controls.Add(l);
                }
                flp_publicacion.Controls.Add(c);
            } 
            
        }

        private void zumbido(bool n)
        {
            player.Play();
        }

        private void FG_FormClosed(object sender, FormClosedEventArgs e)
        {
            hilo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);

            c_video c = new c_video(conectado,N);
            c.BringToFront();
            flp_publicacion.SendToBack();
            Controls.Add(c);
            
        }

        private void rb_conectado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_conectado.Checked == true)
            {
                Mensaje m = new Mensaje();
                m.tipoo = Mensaje.tipo.estado;
                m.mensaje = "Conectado";
                conectado.Send(m.toBytes());
            }
        }

        private void rb_ausente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ausente.Checked == true)
            {
                Mensaje m = new Mensaje();
                m.tipoo = Mensaje.tipo.estado;
                m.mensaje = "Ausente";
                conectado.Send(m.toBytes());
            }
        }

        private void rb_desconectado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_desconectado.Checked == true)
            {
                Mensaje m = new Mensaje();
                m.tipoo = Mensaje.tipo.estado;
                m.mensaje = "Desconectado";
                conectado.Send(m.toBytes());
            }
        }
    }
}