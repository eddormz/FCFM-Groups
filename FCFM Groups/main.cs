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
using System.Threading;
using Data;

namespace FCFM_Groups
{
    delegate void entrante(Mensaje d);

    public partial class Form1 : Form
    {
        public v_chat todos;
        Persona publico;
        Socket conectado;
        int id;
        string email;

        public Form1(Socket cliente, int iduser,String nom)
        {
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

                            if (Application.OpenForms["todos"]!=null)
                            {
                                    todos.MensajeLlego(d);
                            }
                            else
                            {
                                try
                                {
                                    entrante dd = new entrante(instanciaEntrante);

                                    this.Invoke(dd, new object[] { d });
                                }
                                catch
                                {
                                    MessageBox.Show("Error al Escribir mensaje en archivo, Intentelo Nuevamente");
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
        }
        
        private void instanciaEntrante(Mensaje d)
        {
            todos = new v_chat(conectado,email);
            todos.MdiParent = this;
            todos.Text = "Fcfm Groups";
            todos.Show();
            todos.MensajeLlego(d);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            publico = new Persona("Publico");
            publico.MdiParent = this;
            publico.Show();

            listView1.Controls.Add(publico);

            //flowLayoutPanel2.Controls.Add(publico);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
