﻿using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FG_v2
{
    delegate void entrante(Mensaje d);

    public partial class FG : Form
    {
        List<Chat> Ventanas;
        private Socket conectado;
        private string email;
        private int id;
        

        public FG()
        {
            InitializeComponent();
            Ventanas = new List<Chat>();
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

                    }


                }

            }
            MessageBox.Show("Socket no conectado");
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