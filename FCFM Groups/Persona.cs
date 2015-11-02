using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFM_Groups
{
    public partial class Persona : Form
    {
        public Persona(String nombre)
        {
            InitializeComponent();
            label1.Text = nombre;
        }
    }
}
