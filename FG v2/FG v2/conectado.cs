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
    public partial class conectado : UserControl
    {
        public EventHandler clickOn;
        public conectado()
        {
            InitializeComponent();
        }

        private void conectado_Load(object sender, EventArgs e)
        {

        }

        private void conectado_DoubleClick(object sender, EventArgs e)
        {
            clickOn(sender, e);
        }
    }
}
