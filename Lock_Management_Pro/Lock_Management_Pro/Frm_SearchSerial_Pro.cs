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
    public partial class Frm_SearchSerial_Pro : Form
    {
        Lock_ProDBEntities database = new Lock_ProDBEntities();
        public Frm_SearchSerial_Pro()
        {
            InitializeComponent();
        }
     
        private void grd_software_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grd_software.Rows[e.RowIndex].Cells["radif"].Value = e.RowIndex + 1;

        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            var list = (from a in database.tbl_ProSerial select a).ToList();
            grd_software.DataSource = list;
        }

        private void txt_FindBySer_TextChanged(object sender, EventArgs e)
        {
            var search = database.tbl_ProSerial.Where(c => c.ProSerial.Contains(txt_FindBySer.Text.Trim())).ToList();
            grd_software.DataSource = search;
        }

        private void ctm_lock_gen_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(grd_software.SelectedRows[0].Cells["soft_id"].Value.ToString(),out id);
            var Selected = (from rows in database.tbl_ProSerial
                            where rows.ID == id
                            select rows).First();

            Frm_Lock_give f = new Frm_Lock_give();
            f.txt_serial_num.Text = Selected.ProSerial;
            f.txt_fix_num1.Text = Selected.Fix_num1.ToString();
            f.txt_fix_num2.Text = Selected.Fix_num2.ToString();
            f.ShowDialog();
        }
    }
}
