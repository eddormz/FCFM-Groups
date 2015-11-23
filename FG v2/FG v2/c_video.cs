using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System.Net.Sockets;
using Data;
using System.Net;
using System.Threading;
using System.IO;

namespace FG_v2
{
    public partial class c_video : UserControl
    {
        Socket vc;
        public c_video() { }
        Image v_i;
        bool proceso=true;

        public c_video(IPAddress ip)
        {
            InitializeComponent();
            vc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
            Dispo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in Dispo)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
            fuente = new VideoCaptureDevice(Dispo[comboBox1.SelectedIndex].MonikerString);
            //INICIALIZAR EL CONTROL 
            vSP.VideoSource = fuente;
            vSP.Start();

            vc.Connect(ip,1818);
            Thread h = new Thread(video2);
            h.Start();
        }

        public c_video(Socket c,int i)
        {
            try {
                InitializeComponent();
                vc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 1818);
                vc.Bind(ipe);

                Dispo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo x in Dispo)
                {
                    comboBox1.Items.Add(x.Name);
                }
                comboBox1.SelectedIndex = 0;
                fuente = new VideoCaptureDevice(Dispo[comboBox1.SelectedIndex].MonikerString);
                //INICIALIZAR EL CONTROL 
                vSP.VideoSource = fuente;
                vSP.Start();

                Mensaje m = new Mensaje();
                m.tipoo = Mensaje.tipo.video;
                m.idDestino = i;
                IPAddress ip = funciones.obtenerip();
                m.ip = ip;
                c.Send(m.toBytes());
                Thread h = new Thread(video);
                h.Start();
            }
            catch(Exception F)
            {

            }


        }

        private void video()
        {
            int readbytes;
            vc.Listen(0);
            Socket s = vc.Accept();
            byte[] entrando = new byte[s.SendBufferSize];
            while (proceso)
            {
                readbytes = s.Receive(entrando);
                if (readbytes > 0)
                {
                    Mensaje M = new Mensaje(entrando);

                    if (M.tipoo == Mensaje.tipo.imagen)
                    {

                        MemoryStream ms = M.MM;
                        v_cliente.Image = Image.FromStream(ms);
                        Image i = v_i;
                        i.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                        M.MM = ms;
                        vc.Send(M.toBytes());
                        ms.Close();
                    }
                }
            }
        }

        private void video2()
        {
            int readbytes;
           
            byte[] entrando = new byte[vc.SendBufferSize];
            while (proceso)
            {
                try {
                    readbytes = vc.Receive(entrando);
                    if (readbytes > 0)
                    {
                        Mensaje M=new Mensaje(entrando);

                        if (M.tipoo == Mensaje.tipo.imagen) {

                            MemoryStream ms = M.MM;
                            v_cliente.Image = Image.FromStream(ms);
                            Image i = v_i;
                            i.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                            M.MM = ms;
                            vc.Send(M.toBytes());
                            ms.Close();
                        }
                    }
                }
                catch(Exception e)
                {

                }
            }
        }

        private FilterInfoCollection Dispo;
        private VideoCaptureDevice fuente;

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            proceso = false;
            vSP.SignalToStop();
        }

        private void vSP_NewFrame(object sender, ref Bitmap image)
        {
            v_i = image;
        }

    }
}
