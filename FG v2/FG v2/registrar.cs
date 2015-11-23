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
            Mensaje h = new Mensaje();
            h.tipoo = Mensaje.tipo.registrar;
            h.nombre = tb_correo.Text;
            h.contrasenia = tb_correo.Text;
            h.idGrupo = 1;//Convert.ToInt32(cb_carrera.SelectedValue);
            local.Send(h.toBytes());

           /* //ejemplo
            String correo = tb_correo.Text;
            String contra = tb_contra.Text;
            int grupo = Convert.ToInt32(cb_carrera.SelectedValue.ToString());
            String ipusua = Data.funciones.obtenerip().ToString();

            Usuario usua = new Usuario();
            usua.correo = correo;
            usua.contrasenia = contra;
            usua.idGrupo = grupo;
            usua.ip = ipusua;

            usuarios usuario = new usuarios();
            usuario.agregarUsuario(usua); */

        }

        private void registrar_Load(object sender, EventArgs e)
        {
            /* grupos grupo = new grupos();
            List<Grupo> gpo = grupo.obtenerGrupos();
            cb_carrera.DisplayMember = "nombreGrupo";
            cb_carrera.ValueMember = "idGrupo";
            cb_carrera.DataSource = gpo;
            tb_nombreUsuario.Focus(); */
        }
    }
}
