using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FG_v2
{
    public partial class c_conectado : UserControl
    {
        public int id;
        string nombre;
        string estado;
        
        public c_conectado()
        {
            InitializeComponent();
        }
        

        public c_conectado(string estado, int id, string nombre)
        {
            InitializeComponent();
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;
            txt_nombreConectado.Text = this.nombre+" - "+id;

            if (this.estado == "Conectado")
            {
                pb_estatus.Image = System.Drawing.Image.FromFile("conectado.png");
            }
            if (this.estado == "Desconectado")
            {
                pb_estatus.Image = System.Drawing.Image.FromFile("desconectado.png");
            }
            if (this.estado == "Ausente")
            {
                pb_estatus.Image = System.Drawing.Image.FromFile("ausente.png");
            }

        }


        private void conectado_Load(object sender, EventArgs e)
        {

        }

        private void conectado_DoubleClick(object sender, EventArgs e)
        {
            //FG.nuevochat(this.id);   
        }
    }
}
