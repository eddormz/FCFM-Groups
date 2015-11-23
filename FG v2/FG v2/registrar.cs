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
       static Socket local;

        public registrar(Socket c)
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

            //h.nombre = tb_correo.Text;
            //h.contrasenia = tb_correo.Text;
            //h.idGrupo = cb_carrera.SelectedValue;
            //local.Send(h.toBytes());

        }

        private void registrar_Load(object sender, EventArgs e)
        {
            DataSourcePOI dspoi = new DataSourcePOI();

            cb_carrera.DisplayMember = "nombreGrupo";
            cb_carrera.ValueMember = "idGrupo";
            cb_carrera.DataSource = dspoi.getGrupos();

        }
    }
}
