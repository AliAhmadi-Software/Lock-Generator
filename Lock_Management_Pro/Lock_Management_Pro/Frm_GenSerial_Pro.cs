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
using Stimulsoft.Report;
using System.Data.Entity;

namespace Lock_Management_Pro
{
    public partial class Frm_GenSerial_Pro : Form
    {
        public Frm_GenSerial_Pro()
        {
            InitializeComponent();
        }
        Lock_ProDBEntities database = new Lock_ProDBEntities();
        public void load_soft()
        {
            var load = (from a in database.tbl_Software select a);
            cmb_software.DisplayMember = "ProName";
            cmb_software.ValueMember = "ID";
            cmb_software.DataSource = load.ToList();
        }
        public string today()
        {
            string day;
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            day = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");
            return day;
        }
        public void bind_grid()
        {
            var query = (from a in database.tbl_ProSerial select a);
            grd_software.DataSource = query.ToList();
        }
        private void Frm_GenSerial_Pro_Load(object sender, EventArgs e)
        {
            load_soft();
            bind_grid();
        }

        private void cmb_software_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            int.TryParse(cmb_software.SelectedValue.ToString(), out id);
            var selected = (from rows in database.tbl_Software where rows.ID == id select rows).ToList();
            //----------------
            cmb_fixNum1.DisplayMember = "Fix_num1";
            cmb_fixNum1.ValueMember = "Fix_num1";
            //----------------
            cmb_fixNum2.DisplayMember = "Fix_num2";
            cmb_fixNum2.ValueMember = "Fix_num2";
            //----------------
            cmb_fixNum1.DataSource = selected;
            cmb_fixNum2.DataSource = selected;
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            txt_pro_date.Text = today();
        }

        private void btn_genSerial_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string s;
            s = rnd.Next(12500000, 20000000).ToString();
            int q = (from a in database.tbl_ProSerial where a.ProSerial == s select a).Count();
            if(q==0)
            {
                txt_ProSerial.Text = s;
            }
            else
            {
                btn_genSerial_Click(sender, e);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ProSerial.Text))
            {
                errorProvider1.SetError(txt_ProSerial, "سریال نرم افزار را تولید کنید");
                return;
            }
            else
            {
                errorProvider1.Clear();
                tbl_ProSerial tb_proserial = new tbl_ProSerial()
                {
                    ProDate = txt_pro_date.Text,
                    ProName=cmb_software.Text,
                    ProSerial=txt_ProSerial.Text,
                    Fix_num1=Convert.ToInt32( cmb_fixNum1.SelectedValue),
                    Fix_num2 = Convert.ToInt32(cmb_fixNum2.SelectedValue),
                };
                database.tbl_ProSerial.Add(tb_proserial);
                database.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت ذخیره گردید","موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);
                bind_grid();
                //------------------------
                txt_pro_date.Mask = "1300/00/00";
                txt_ProSerial.Clear();
                cmb_software.SelectedIndex = 0;

            }

        }

        private void grd_software_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grd_software.Rows[e.RowIndex].Cells["radif"].Value = e.RowIndex + 1;
        }
        public StiReport report = new StiReport();
        public void printdata(StiReport report)
        {
            using (Lock_ProDBEntities database=new Lock_ProDBEntities())
            {
                var query = (from a in database.tbl_ProSerial select a).ToList();
                report.RegData("serial_pro", query);
            }
        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + "\\report\\Rpt_SerialPro.mrt");
            printdata(report);
            Application.DoEvents();
            report.Show();
        }
    }
}
