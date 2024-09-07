using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Lock_Management_Pro
{
    public partial class Frm_Lock_give : Form
    {
        Lock_ProDBEntities database = new Lock_ProDBEntities();
        public Frm_Lock_give()
        {
            InitializeComponent();
        }
        public string today()
        {
            string day;
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            day = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");
            return day;
        }
        public void load_data()
        {
            string serial=txt_serial_num.Text;
            var query = (from a in database.tbl_LockList where a.serial_num == serial select a).ToList();
            grd_lock_list.DataSource = query;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cuName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_cuName, "نام کامل مشتری را وارد نمایید");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_cuMobile.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_cuMobile, "شماره موبایل مشتری را وارد نمایید");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Identity_num.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Identity_num, "شماره شناسایی را وارد نمایید");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Lock_num.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Lock_num, "شماره قفل تولید نشده است");
                return;
            }
            else
            {
                errorProvider1.Clear();
                string ser_num = txt_serial_num.Text;
                var q = (from a in database.tbl_LockList orderby a.ID descending where a.serial_num == ser_num select a).FirstOrDefault();
                if (q != null)   // اگر قبلا قفل گرفته است
                {
                    if (q.lock_count < 3)  // ---- اگر تعداد قفل گرفته شده کمتر از3 باشد بتواند قفل دریافت کند
                    {
                        int Lock_Count = (int)q.lock_count + 1;
                        tbl_LockList table = new tbl_LockList()
                        {
                            cu_mobile = txt_cuMobile.Text,
                            cu_name = txt_cuName.Text,
                            fix_num1 = Convert.ToInt32(txt_fix_num1.Text),
                            fix_num2 = Convert.ToInt32(txt_fix_num2.Text),
                            identity_num = Convert.ToInt32(txt_Identity_num.Text),
                            lock_count = Lock_Count,
                            lock_date = txt_lock_date.Text,
                            serial_num = txt_serial_num.Text,
                            lock_num = txt_Lock_num.Text,
                        };
                        database.tbl_LockList.Add(table);
                        database.SaveChanges();
                        load_data();
                        MessageBox.Show("اطلاعات با موفقیت ذخیره گردید","موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        valid_lock_count();

                    }
                }
                else   // در غیر این صورت داره اولین قفل رو میگیره
                {
                    tbl_LockList table = new tbl_LockList()
                    {
                        cu_mobile = txt_cuMobile.Text,
                        cu_name = txt_cuName.Text,
                        fix_num1 = Convert.ToInt32(txt_fix_num1.Text),
                        fix_num2 = Convert.ToInt32(txt_fix_num2.Text),
                        identity_num = Convert.ToInt32(txt_Identity_num.Text),
                        lock_count = 1,
                        lock_date = txt_lock_date.Text,
                        serial_num = txt_serial_num.Text,
                        lock_num = txt_Lock_num.Text,
                    };
                    database.tbl_LockList.Add(table);
                    database.SaveChanges();
                    load_data();
                    valid_lock_count();
                    MessageBox.Show("اطلاعات با موفقیت ذخیره گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            txt_lock_date.Text = today();
        }

        private void Frm_Lock_give_Load(object sender, EventArgs e)
        {
            load_data();
            valid_lock_count();



        }

        private void grd_lock_list_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grd_lock_list.Rows[e.RowIndex].Cells["radif"].Value = e.RowIndex + 1;
        }

        public void valid_lock_count()
        {
            string ser_num = txt_serial_num.Text;
            var q = (from a in database.tbl_LockList orderby a.ID descending where a.serial_num == ser_num select a).FirstOrDefault();
            if (q != null)
            {
                if (q.lock_count < 3)
                {
                    int number =3;
                    int result =Convert.ToInt32(number - q.lock_count);
                    this.lbl_msg.Text = "تعداد قفل باقی مانده : " + result + " عدد";

                }
                else
                {
                    lbl_msg.Text = "این محصول 3 بار قفل گرفته است";
                    btnSave.Enabled = false;
                }
            }
            else  //---- برای اولین بار میخواد قفل رو بگیره
            {
                this.lbl_msg.Text = "تعداد قفل باقی مانده : 3 عدد "; 
            }
        }

        private void txt_Identity_num_TextChanged(object sender, EventArgs e)
        {
            int n1, n2;
            int.TryParse(txt_fix_num1.Text, out n1);
            int.TryParse(txt_fix_num2.Text, out n2);

            txt_Lock_num.Text = hh(txt_Identity_num.Text, n1, n2);

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

        private void txt_Identity_num_Leave(object sender, EventArgs e)
        {
        
        }
    }
}
