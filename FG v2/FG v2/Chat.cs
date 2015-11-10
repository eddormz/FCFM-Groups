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
    public partial class Chat : UserControl
    {
        public static int id;
        public bool cerrar;

        public Chat()
        {
            cerrar=false;
            InitializeComponent();
        }

        public void btn_cerrar_Click(object sender, EventArgs e)
        {
            cerrar = true;
        }
    }
}
