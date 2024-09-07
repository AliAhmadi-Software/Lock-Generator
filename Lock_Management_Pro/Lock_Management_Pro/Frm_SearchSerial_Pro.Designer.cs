namespace Lock_Management_Pro
{
    partial class Frm_SearchSerial_Pro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grd_software = new System.Windows.Forms.DataGridView();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_num2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.txt_FindBySer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_lock_gen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grd_software)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_software
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            this.grd_software.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_software.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_software.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_software.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.soft_id,
            this.soft_name,
            this.soft_date,
            this.soft_serial,
            this.fix_num1,
            this.fix_num2});
            this.grd_software.ContextMenuStrip = this.contextMenuStrip1;
            this.grd_software.Location = new System.Drawing.Point(4, 73);
            this.grd_software.MultiSelect = false;
            this.grd_software.Name = "grd_software";
            this.grd_software.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_software.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_software.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd_software.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_software.Size = new System.Drawing.Size(609, 322);
            this.grd_software.TabIndex = 6;
            this.grd_software.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grd_software_CellFormatting);
            // 
            // radif
            // 
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            this.radif.Width = 50;
            // 
            // soft_id
            // 
            this.soft_id.DataPropertyName = "ID";
            this.soft_id.HeaderText = "کد";
            this.soft_id.Name = "soft_id";
            this.soft_id.Width = 60;
            // 
            // soft_name
            // 
            this.soft_name.DataPropertyName = "ProName";
            this.soft_name.HeaderText = "نرم افزار";
            this.soft_name.Name = "soft_name";
            this.soft_name.Width = 115;
            // 
            // soft_date
            // 
            this.soft_date.DataPropertyName = "ProDate";
            this.soft_date.HeaderText = "تاریخ تولید";
            this.soft_date.Name = "soft_date";
            this.soft_date.Width = 80;
            // 
            // soft_serial
            // 
            this.soft_serial.DataPropertyName = "ProSerial";
            this.soft_serial.HeaderText = "سریال";
            this.soft_serial.Name = "soft_serial";
            this.soft_serial.Width = 115;
            // 
            // fix_num1
            // 
            this.fix_num1.DataPropertyName = "Fix_num1";
            this.fix_num1.HeaderText = "شماره ثابت1";
            this.fix_num1.Name = "fix_num1";
            this.fix_num1.Width = 70;
            // 
            // fix_num2
            // 
            this.fix_num2.DataPropertyName = "Fix_num2";
            this.fix_num2.HeaderText = "شماره ثابت2";
            this.fix_num2.Name = "fix_num2";
            this.fix_num2.Width = 70;
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowAll.Location = new System.Drawing.Point(233, 28);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(106, 23);
            this.btn_ShowAll.TabIndex = 8;
            this.btn_ShowAll.Text = "نمایش همه";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // txt_FindBySer
            // 
            this.txt_FindBySer.Location = new System.Drawing.Point(372, 30);
            this.txt_FindBySer.Name = "txt_FindBySer";
            this.txt_FindBySer.Size = new System.Drawing.Size(158, 20);
            this.txt_FindBySer.TabIndex = 9;
            this.txt_FindBySer.TextChanged += new System.EventHandler(this.txt_FindBySer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(536, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "شماره سریال : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_lock_gen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 54);
            // 
            // ctm_lock_gen
            // 
            this.ctm_lock_gen.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctm_lock_gen.Image = global::Lock_Management_Pro.Properties.Resources.tiny_HID;
            this.ctm_lock_gen.Name = "ctm_lock_gen";
            this.ctm_lock_gen.Size = new System.Drawing.Size(152, 28);
            this.ctm_lock_gen.Text = "صدور قفل";
            this.ctm_lock_gen.Click += new System.EventHandler(this.ctm_lock_gen_Click);
            // 
            // Frm_SearchSerial_Pro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(632, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FindBySer);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.grd_software);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SearchSerial_Pro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جست و جوی سریال محصولات";
            ((System.ComponentModel.ISupportInitialize)(this.grd_software)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_software;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.TextBox txt_FindBySer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_num2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_lock_gen;
    }
}