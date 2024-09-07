using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resolution_changer.comm_files
{
  public class resolution_files
    {
        public string hh(string ss,int n1,int n2)
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

    }
}
