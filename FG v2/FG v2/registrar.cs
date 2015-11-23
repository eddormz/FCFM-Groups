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
using Data;

namespace FG_v2
{
    public partial class registrar : Form
    {
        Socket local;
        string correo;
        string contra;
        string idgrupo;

        public registrar(Socket c, String correo, String contra, String )
        {
            local = c;
            InitializeComponent();
        }

        public registrar()
        {
            InitializeComponent();
        }

        private void bt_In_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            Mensaje h = new Mensaje();
            h.tipoo = Mensaje.tipo.registrar;
            h.nombre = tb_correo.Text;
            h.contrasenia = tb_correo.Text;
            h.idGrupo = cb_carrera.SelectedValue.ToString();
            local.Send(h.toBytes());
>>>>>>> origin/master
        }
    }
}
