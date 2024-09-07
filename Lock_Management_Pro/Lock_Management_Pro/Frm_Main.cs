using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lock_Management_Pro
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_SearchSerial_Pro f = new Frm_SearchSerial_Pro();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_GenSerial_Pro f = new Frm_GenSerial_Pro();
            f.ShowDialog();
        }
    }
}
