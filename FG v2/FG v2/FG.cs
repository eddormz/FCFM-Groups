using Data;
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
    delegate void entrantep(Mensaje d,int t);
    delegate void actualizacion(lista_usuarios l);
    delegate void SetZumbido(bool q);
    delegate void clickconectado(int id);



    public partial class FG : Form
    {
        List<Chat> Ventanas;
        public Socket conectado;
        public string email;
        private int id;
        bool hilo = true;
        SoundPlayer player;
        Chat s;
        c_subgrupos subgrup;
        public int idGrupo;

       // static IPAddress ip = IPAddress.Parse(Data.funciones.obtenersvr("2ND"));
        static IPAddress ip = IPAddress.Parse("127.0.0.1");

        static Socket actua;

        c_conectado c = null;
        public FG()
        {
            InitializeComponent();
        }

        public FG(Socket cliente, int iduser, String nom, int idGrupo)
        {
            Ventanas = new List<Chat>();
            conectado = cliente;
            this.email = nom;
            this.id = iduser;
            this.idGrupo = idGrupo;
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

                            foreach(Chat cha in Ventanas)
                            {
                                if (cha.idgrupo == d.idGrupo)
                                {
                                    cha.MensajeEntrando(d);
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

                            bool existechat = false;
                            int usar;
                            if (d.iduser == id)
                            {
                                usar = d.idDestino;
                            }
                            else
                            {
                                usar = d.iduser;
                            }


                            foreach (Chat chat in Ventanas)
                            {
                                if (chat.id == usar)
                                {
                                    chat.MensajeEntrando(d);
                                    existechat = true;
                                }
                            }
                            if (!existechat)
                            {
                                try
                                {
                                    entrantep dd = new entrantep(newChatPrivado);

                                    this.Invoke(dd, new object[] { d,usar });
                                }
                                catch
                                {
                                    MessageBox.Show("Error al Crear Nuevo Chat, Intentelo Nuevamente");
                                }
                            }
                            break;

                        case Mensaje.tipo.zumbido:

                            Mensaje zumba = new Mensaje();
                            zumba.tipoo = Mensaje.tipo.zumbido;
                            zumba.mensaje = "Zumbido";
                            bool existz = false;

                            if (d.idDestino == 0)
                            {
                                foreach (Chat cha in Ventanas)
                                {
                                    if (cha.idgrupo == d.idGrupo)
                                    {
                                        cha.MensajeEntrando(zumba);
                                        existz = true;
                                        zumbidoactivar();
                                    }
                                }
                                if (!existz)
                                {
                                    try
                                    {
                                        entrante dd = new entrante(newChat);

                                        this.Invoke(dd, new object[] { zumba });
                                        zumbidoactivar();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Error al Crear zumb Chat, Intentelo Nuevamente");
                                    }
                                }


                                break;
                                

                            }
                            else
                            {
                                bool existechatz = false;
                                foreach (Chat chat in Ventanas)
                                {
                                    if (chat.id == d.iduser)
                                    {
                                        chat.MensajeEntrando(zumba);
                                        existechat = true;
                                        zumbidoactivar();
                                    }
                                }
                                if (!existechatz)
                                {
                                    try
                                    {
                                        entrantep dd = new entrantep(newChatPrivado);

                                        this.Invoke(dd, new object[] { zumba, d.iduser });
                                        zumbidoactivar();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Error al Crear Nuevo Chat, Intentelo Nuevamente");
                                    }
                                }
                            }


                            break;

                        
                        case Mensaje.tipo.archivo:

                            if (d.idDestino == 0){

                                bool exista = false;

                                foreach(Chat f in Ventanas)
                                {
                                    if (f.idgrupo == d.idGrupo)
                                    {
                                        f.MensajeEntrando(d);
                                        exista = true;
                                    }
                                }
                                
                                if (!exista)
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

                            }
                            else
                            {
                                bool existechatz = false;
                                foreach (Chat chat in Ventanas)
                                {
                                    if (chat.id == d.iduser)
                                    {
                                        chat.MensajeEntrando(d);
                                        existechat = true;
                                    }
                                }
                                if (!existechatz)
                                {
                                    try
                                    {
                                        entrantep dd = new entrantep(newChatPrivado);

                                        this.Invoke(dd, new object[] { d, d.iduser });
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Error al Crear Nuevo Chat, Intentelo Nuevamente");
                                    }
                                }
                            }
                            

                            break;

                        case Mensaje.tipo.cerrar:
                            hilo = false;

                            break;

                        case Data.Mensaje.tipo.solicitudArchivo:

                            d.archi.ByteArrayToFile();
                            MessageBox.Show("Mensaje Recibido " + d.archi.j);

                            break;


                    }


                }

            }
            actua.Shutdown(SocketShutdown.Both);

            Application.Exit();
        }
        
        public void actualiza()
        {
            int readbytes;
            while (hilo)
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
                    c = new c_conectado(i[0], int.Parse(i[1]), i[2]);
                    c.Click += new EventHandler(clickconectado);
                    c.pb_estatus.Click+= new EventHandler(clickconectado);
                    c.txt_nombreConectado.Click += new EventHandler(clickconectado);
                    flp_conectados.Controls.Add(c);
                }
            }
        }

        private void newChat(Mensaje d)
        {
            s = new Chat(idGrupo,id,conectado, email);
            s.btn_cerrar.Click += new EventHandler(clickcerrar);
            if (flp_chats.Controls.Count < 3)
            {
                Ventanas.Add(s);
                flp_chats.Controls.Add(s);
                s.MensajeEntrando(d);
            }
        }

        private void newChatPrivado(Mensaje d,int u)
        {
            Chat s = new Chat(conectado, email,u,id,idGrupo);
            if (flp_chats.Controls.Count < 3)
            {
                Ventanas.Add(s);
                flp_chats.Controls.Add(s);
                s.MensajeEntrando(d);
            }
        }

        private void test_Click(object sender, EventArgs e)
        { bool existe = false;
            s = new Chat(idGrupo, id, conectado, email);
            s.btn_cerrar.Click += new EventHandler(clickcerrar);

            foreach (Chat chats in Ventanas)
            {
                if (chats.idgrupo == idGrupo)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                if (flp_chats.Controls.Count < 3)
                {
                    Ventanas.Add(s);
                    flp_chats.Controls.Add(s);
                }
            }
        }
        
        private void clock_Tick(object sender, EventArgs e)
        {
            //if (Ventanas != null)
            //{
            //    for (int i = 0; i < Ventanas.Count; i++)
            //    {
            //        if (Ventanas[i].cerrar == true)
            //        {
            //            flp_chats.Controls.Remove(Ventanas[i]);
            //            Ventanas[i].Dispose();
            //            Ventanas.Remove(Ventanas[i]);

            //        }
            //    }
            //    if (Ventanas.Count > 0)
            //    {
            //        flp_chats.Visible = true;
            //    }
            //    else
            //    {
            //        flp_chats.Visible = false;
            //    }
            //}
            //else
            //{
            //    flp_chats.Visible = false;
            //}

            if (flp_chats.Controls.Count > 0)
            {
                flp_chats.Visible = true;

                switch (flp_chats.Controls.Count)
                {
                    case 1:
                        flp_chats.Width = 1*286;
                        break;
                    case 2:
                        flp_chats.Width = 2* 286;
                        break;
                    case 3:
                        flp_chats.Width = 3 * 286;
                        break;

                }

            }
            else
            {
                flp_chats.Visible = false;
            }

        }

        private void FG_Load(object sender, EventArgs e)
        {
            publicaciones(id, idGrupo, conectado, flp_publicacion);
        }

        public void publicaciones(int id, int idGrupo, Socket conectado, FlowLayoutPanel flp_publicacion)
        {
            DataSourcePOI dsp = new DataSourcePOI();

            c_Publicacion p = new c_Publicacion(id, idGrupo, conectado, flp_publicacion);
            flp_publicacion.Controls.Add(p);

            DataTable dt = dsp.getPublicacion(idGrupo);
            c_desplegar c = null;



            tarea t = new tarea(idGrupo, id);
            t.Location = new Point(12, 354);
            this.Controls.Add(t);

            subgrup = new c_subgrupos(id, idGrupo);
            subgrup.Location = new Point(0, 0);
            subgrup.lstSubgrupos.SelectedIndexChanged += new EventHandler(chatsub);
            this.Controls.Add(subgrup);


            bool isExistsFile = false;

            int temp = 0;

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // c_desplegar c = new c_desplegar("nombre"+i, "Toda la publicacion aqui", 1);

                    string comprar = dt.Rows[i][5].ToString();

                    if (!"".Equals(comprar))
                    {
                        isExistsFile = true;
                    }

                    c = new c_desplegar(dt.Rows[i][4] + "", dt.Rows[i][1] + "", int.Parse(dt.Rows[i][0].ToString()), idGrupo, id, isExistsFile, dt.Rows[i][5].ToString(), conectado);

                    DataTable dtc = dsp.getComentario(int.Parse(dt.Rows[i][0].ToString()));

                    temp = int.Parse(dt.Rows[i][0].ToString());


                    if (dtc != null)
                    {
                        for (int j = 0; j < dtc.Rows.Count; j++)
                        {
                            int temp2 = int.Parse(dtc.Rows[j][1].ToString());
                            if (temp == temp2)
                            {
                                Label l = new Label();
                                l.Text = dtc.Rows[j][0].ToString();
                                c.flp_comentarios.Controls.Add(l);
                            }
                        }
                    }
                    flp_publicacion.Controls.Add(c);
                    isExistsFile = false;
                }
            }
        }

        #region Zumbido

        private void zumbido(bool n)
        {
            player.Play();
        }

        public void zumbidoactivar()
        {
            try
            {
                SetZumbido dd = new SetZumbido(zumbido);

                this.Invoke(dd, new object[] { true });
            }
            catch
            {
                MessageBox.Show("Error al recibir Zumbido, Intentelo Nuevamente");
            }
        }

        #endregion

        private void FG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mensaje m = new Mensaje();
            m.tipoo = Mensaje.tipo.cerrar;
            conectado.Send(m.toBytes());
            hilo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        #region cambio de estado
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

#endregion

        public void clickconectado(object sender, EventArgs e)
        {
            bool existechat = false;
                foreach (Chat chat in Ventanas)
            {
                if (chat.id == c.id)
                {
                    existechat = true;
                }
            }
            if (!existechat)
            {
                Chat s = new Chat(conectado, email, c.id,id,idGrupo);
                if (flp_chats.Controls.Count < 3)
                {
                    Ventanas.Add(s);
                    flp_chats.Controls.Add(s);
                }
            }
        }

        public void clickcerrar(object sender, EventArgs e)
        {
            flp_chats.Controls.Remove(s);
            Ventanas.Remove(s);
            s.Dispose();
            
        }

        public void chatsub(object sender, EventArgs e) {
            string[] spl = subgrup.lstSubgrupos.SelectedItems[0].Text.Split('-');

            s = new Chat(int.Parse(spl[0]), id, conectado, email);
            s.btn_cerrar.Click += new EventHandler(clickcerrar);
            if (flp_chats.Controls.Count < 3)
            {
                Ventanas.Add(s);
                flp_chats.Controls.Add(s);
            }

        }

    }
}