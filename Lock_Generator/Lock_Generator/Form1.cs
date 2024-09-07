using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lock_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string hh(string ss, int n1, int n2)
        {
            ListBox l1 = new ListBox();
            ListBox l2 = new ListBox();
            //-------------------------جدا کردن ارقام شماره شناسایی و افرودن به لیست باکس
            string a;
            l1.Items.Clear();
            l2.Items.Clear();
            for (int i = 0; i < ss.Length; i++)
            {
                a = ss.Substring(i, 1);
                l1.Items.Add(a);
            }
            //------------ascii calc area----------------تبدیل شماره شناسایی جدا شده به کد اسکی
            for (int i = 0; i < l1.Items.Count; i++)
            {
                a = l1.Items[i].ToString();
                char c = char.Parse(a);
                int ascii = Convert.ToInt32(c);
                l2.Items.Add(ascii);
            }
            //---------------ascii sum area------------جمع زدن کدهای اسکی و تولید شماره قفل
            Int64 s = 0;
            for (int i = 0; i < l2.Items.Count; i++)
            {
                a = l2.Items[i].ToString();
                Int64 j = int.Parse(a);
                s += j;
            }
            Int64 k;
            string b;
            k = s;
            k = (k + n1) * n2; //587193-----افزودن عدد ثابت به قفل جهت افزایش امنیت 
            b = k.ToString();
            return b;

            //------------------------------------

        }


        private void btn_Generate_Click(object sender, EventArgs e)
        {
            int n1, n2;
            int.TryParse(num1_listBox.Text, out n1);
            int.TryParse(num2_listbox.Text, out n2);

            txtNum_lock.Text= hh(txtNum_identity.Text,n1,n2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            num1_listBox.SelectedIndex = comboBox1.SelectedIndex;
            num2_listbox.SelectedIndex = comboBox1.SelectedIndex;
        }
    }
}
