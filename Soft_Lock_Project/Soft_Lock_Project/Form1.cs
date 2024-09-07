using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resolution_changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void change_desktop_pic()
        {
            try
            {
                GetDiskInfo.DiskInfo df = new GetDiskInfo.DiskInfo();
                GetDiskInfo.HDiskInfo.GetDriveInfo(0, ref df);
                string sn;
                sn = df.SerialNumber;
                if (sn == "")
                {
                    GetDiskInfo.HDiskInfo.GetDriveInfo(1, ref df);
                    sn = df.SerialNumber;
                    if (sn == "")
                    {
                        GetDiskInfo.HDiskInfo.GetDriveInfo(2, ref df);
                        sn = df.SerialNumber;
                        if (sn == "")
                        {
                            GetDiskInfo.HDiskInfo.GetDriveInfo(3, ref df);
                            sn = df.SerialNumber;
                            if (sn == "")
                            {
                                sn = "555";
                            }
                        }
                    }
                }
                txt_Serial.Text = sn;
                txt_Model.Text = df.ModelNumber;
                //---------------------------------
                txt_sub.Text = txt_Serial.Text.Substring(0, 4);
                txt_length.Text = txt_Serial.Text.Length.ToString();
                //--------------------------------
                int len = txt_Serial.Text.Length;
                string lst;
                for (int i = 0; i < len; i++)
                {
                    lst = txt_Serial.Text.Substring(i, 1);
                    listBox1.Items.Add(lst);
                }
                //------------ascii calc area--------------------------
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    lst = listBox1.Items[i].ToString();
                    char c = char.Parse(lst);
                    int ascii = Convert.ToInt32(c);
                    ascii_listbox.Items.Add(ascii);
                }
                //-----------------------------------------------------

                //---------------ascii sum area------------------------
                Int64 s = 0;
                for (int i = 0; i < ascii_listbox.Items.Count; i++)
                {
                    lst = ascii_listbox.Items[i].ToString();
                    Int64 j = int.Parse(lst);
                    s += j;
                }
                txt_Num_identity.Text = (s * 12).ToString();
            }
            catch
            {
                txt_Num_identity.Text = "555";
            }
        }

        resolution_changer.comm_files.resolution_files ff = new resolution_changer.comm_files.resolution_files();
        private void button1_Click(object sender, EventArgs e)
        {
            //1174641
            //1174896
            if (txt_Num_lock.Text=="")
            {
                MessageBox.Show("لطفا شماره قفل را وارد نمایید");
                txt_Num_lock.Focus();
                return;
            }
            int ii;
            int.TryParse(txt_Num_lock.Text, out ii);
            if(ii==0)
            {
                MessageBox.Show("قفل را به صورت صحیح وارد نکرده اید","ورودی نا معتبر",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_Num_lock.Focus();
                txt_Num_lock.SelectAll();
                return;
            }
            int n1, n2;
            int.TryParse(lbl_n1.Text, out n1);
            int.TryParse(lbl_n2.Text, out n2);
            string p = ff.hh(txt_Num_identity.Text,n1,n2);

            if (txt_Num_lock.Text==p)
            {
                INIAccess ini = new INIAccess();
                string ini_filename = Application.StartupPath + "\\" + lbl_fname.Text.Trim();
                ini.INIWrite(ini_filename, "my_info", "uln", txt_Num_lock.Text);
                MessageBox.Show("قفل وارد شده صحیح است");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("قفل وارد شده صحیح نیست","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_Num_lock.Text = "";
                txt_Num_lock.Focus();
            }
        }

        private void txt_Serial_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    char ch;
            //    ch = char.Parse(txt_Serial.Text);
            //    this.Text = Convert.ToInt32(ch).ToString();
            //}
            //catch 
            //{ 
            //}

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Num_lock.Focus();
            change_desktop_pic();
            //===============================
            INIAccess ini = new INIAccess();
            int n1, n2;
            int.TryParse(lbl_n1.Text, out n1);
            int.TryParse(lbl_n2.Text, out n2);

            string h = ff.hh(txt_Num_identity.Text,n1,n2);
            string ini_filename = Application.StartupPath + "\\" + lbl_fname.Text.Trim();
           string a = ini.INIRead(ini_filename, "my_info", "uln"); 
            if(h==a)
            {
                this.DialogResult = DialogResult.OK;
            } 
            else
            {
                this.Visible = true;

            }          

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
