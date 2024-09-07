using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Lock_Project
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            resolution_changer.Form1 f = new resolution_changer.Form1();
            f.Visible = false;
            f.lbl_n1.Text = "587193";
            f.lbl_n2.Text = "2";
            f.lbl_fname.Text = "music_player.mp3";
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("از اینکه ما را انتخاب کرده اید متشکریم", "خدانگهدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
       
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
