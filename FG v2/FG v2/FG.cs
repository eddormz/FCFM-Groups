using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FG_v2
{
    public partial class FG : Form
    {
        List<Chat> Ventanas;

        public FG()
        {
            InitializeComponent();
            Ventanas = new List<Chat>();
        }

        private void test_Click(object sender, EventArgs e)
        {
            Chat s = new Chat();
            if (flp_chats.Controls.Count < 3){
                Ventanas.Add(s);
            flp_chats.Controls.Add(s);
             }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            for(int i=0; i<Ventanas.Count;i++)
            {
                if(Ventanas[i].cerrar== true){
                    flp_chats.Controls.Remove(Ventanas[i]);
                   Ventanas[i].Dispose();
                    Ventanas.Remove(Ventanas[i]);
                    
                }
            }


        }
    }
}