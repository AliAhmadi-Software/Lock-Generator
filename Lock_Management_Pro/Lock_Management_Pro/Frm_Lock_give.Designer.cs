namespace Lock_Management_Pro
{
    partial class Frm_Lock_give
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
            this.grd_lock_list = new System.Windows.Forms.DataGridView();
            this.btn_today = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txt_lock_date = new System.Windows.Forms.MaskedTextBox();
            this.txt_serial_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cuName = new System.Windows.Forms.TextBox();
            this.txt_cuMobile = new System.Windows.Forms.TextBox();
            this.txt_Identity_num = new System.Windows.Forms.TextBox();
            this.txt_Lock_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fix_num1 = new System.Windows.Forms.TextBox();
            this.txt_fix_num2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lock_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lock_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cu_mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identity_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lock_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lock_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_num2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lock_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_lock_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            this.grd_lock_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_lock_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_lock_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_lock_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.lock_count,
            this.lock_id,
            this.cu_name,
            this.cu_mobile,
            this.serial_num,
            this.identity_num,
            this.lock_num,
            this.lock_date,
            this.fix_num1,
            this.fix_num2});
            this.grd_lock_list.Location = new System.Drawing.Point(14, 310);
            this.grd_lock_list.MultiSelect = false;
            this.grd_lock_list.Name = "grd_lock_list";
            this.grd_lock_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_lock_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grd_lock_list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd_lock_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_lock_list.Size = new System.Drawing.Size(609, 225);
            this.grd_lock_list.TabIndex = 6;
            this.grd_lock_list.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grd_lock_list_CellFormatting);
            // 
            // btn_today
            // 
            this.btn_today.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_today.Location = new System.Drawing.Point(213, 90);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(47, 23);
            this.btn_today.TabIndex = 1;
            this.btn_today.TabStop = false;
            this.btn_today.Text = "امروز";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(395, 95);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "تاریخ قفل :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(328, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_lock_date
            // 
            this.txt_lock_date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_lock_date.Location = new System.Drawing.Point(266, 92);
            this.txt_lock_date.Mask = "1300/00/00";
            this.txt_lock_date.Name = "txt_lock_date";
            this.txt_lock_date.Size = new System.Drawing.Size(123, 21);
            this.txt_lock_date.TabIndex = 0;
            // 
            // txt_serial_num
            // 
            this.txt_serial_num.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_serial_num.Location = new System.Drawing.Point(213, 234);
            this.txt_serial_num.Name = "txt_serial_num";
            this.txt_serial_num.ReadOnly = true;
            this.txt_serial_num.Size = new System.Drawing.Size(176, 21);
            this.txt_serial_num.TabIndex = 5;
            this.txt_serial_num.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(399, 237);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "سریال نرم افزار :";
            // 
            // txt_cuName
            // 
            this.txt_cuName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_cuName.Location = new System.Drawing.Point(213, 124);
            this.txt_cuName.Name = "txt_cuName";
            this.txt_cuName.Size = new System.Drawing.Size(176, 21);
            this.txt_cuName.TabIndex = 2;
            this.txt_cuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_cuMobile
            // 
            this.txt_cuMobile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_cuMobile.Location = new System.Drawing.Point(213, 151);
            this.txt_cuMobile.Name = "txt_cuMobile";
            this.txt_cuMobile.Size = new System.Drawing.Size(176, 21);
            this.txt_cuMobile.TabIndex = 3;
            // 
            // txt_Identity_num
            // 
            this.txt_Identity_num.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Identity_num.Location = new System.Drawing.Point(213, 178);
            this.txt_Identity_num.Name = "txt_Identity_num";
            this.txt_Identity_num.Size = new System.Drawing.Size(176, 21);
            this.txt_Identity_num.TabIndex = 4;
            this.txt_Identity_num.TextChanged += new System.EventHandler(this.txt_Identity_num_TextChanged);
            this.txt_Identity_num.Leave += new System.EventHandler(this.txt_Identity_num_Leave);
            // 
            // txt_Lock_num
            // 
            this.txt_Lock_num.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Lock_num.Location = new System.Drawing.Point(213, 205);
            this.txt_Lock_num.Name = "txt_Lock_num";
            this.txt_Lock_num.ReadOnly = true;
            this.txt_Lock_num.Size = new System.Drawing.Size(176, 21);
            this.txt_Lock_num.TabIndex = 4;
            this.txt_Lock_num.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(393, 127);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "نام مشتری : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(393, 156);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "شماره موبایل : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(398, 183);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "شماره شناسایی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(395, 211);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "شماره قفل : ";
            // 
            // txt_fix_num1
            // 
            this.txt_fix_num1.Location = new System.Drawing.Point(715, 80);
            this.txt_fix_num1.Name = "txt_fix_num1";
            this.txt_fix_num1.Size = new System.Drawing.Size(76, 20);
            this.txt_fix_num1.TabIndex = 24;
            this.txt_fix_num1.TabStop = false;
            // 
            // txt_fix_num2
            // 
            this.txt_fix_num2.Location = new System.Drawing.Point(715, 112);
            this.txt_fix_num2.Name = "txt_fix_num2";
            this.txt_fix_num2.Size = new System.Drawing.Size(76, 20);
            this.txt_fix_num2.TabIndex = 25;
            this.txt_fix_num2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(648, 83);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = ": fix_num1 ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(648, 119);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = ": fix_num2 ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // radif
            // 
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            this.radif.Width = 50;
            // 
            // lock_count
            // 
            this.lock_count.DataPropertyName = "lock_count";
            this.lock_count.HeaderText = "تعداد قفل";
            this.lock_count.Name = "lock_count";
            this.lock_count.Visible = false;
            // 
            // lock_id
            // 
            this.lock_id.DataPropertyName = "ID";
            this.lock_id.HeaderText = "کد";
            this.lock_id.Name = "lock_id";
            this.lock_id.Width = 60;
            // 
            // cu_name
            // 
            this.cu_name.DataPropertyName = "cu_name";
            this.cu_name.HeaderText = "نام مشتری";
            this.cu_name.Name = "cu_name";
            this.cu_name.Width = 115;
            // 
            // cu_mobile
            // 
            this.cu_mobile.DataPropertyName = "cu_mobile";
            this.cu_mobile.HeaderText = "موبایل";
            this.cu_mobile.Name = "cu_mobile";
            this.cu_mobile.Width = 80;
            // 
            // serial_num
            // 
            this.serial_num.DataPropertyName = "serial_num";
            this.serial_num.HeaderText = "سریال نرم افزار";
            this.serial_num.Name = "serial_num";
            this.serial_num.Width = 115;
            // 
            // identity_num
            // 
            this.identity_num.DataPropertyName = "identity_num";
            this.identity_num.HeaderText = "ش شناسایی";
            this.identity_num.Name = "identity_num";
            // 
            // lock_num
            // 
            this.lock_num.DataPropertyName = "lock_num";
            this.lock_num.HeaderText = "ش قفل";
            this.lock_num.Name = "lock_num";
            // 
            // lock_date
            // 
            this.lock_date.DataPropertyName = "lock_date";
            this.lock_date.HeaderText = "تاریخ قفل";
            this.lock_date.Name = "lock_date";
            // 
            // fix_num1
            // 
            this.fix_num1.DataPropertyName = "fix_num1";
            this.fix_num1.HeaderText = "شماره ثابت1";
            this.fix_num1.Name = "fix_num1";
            this.fix_num1.Width = 70;
            // 
            // fix_num2
            // 
            this.fix_num2.DataPropertyName = "fix_num2";
            this.fix_num2.HeaderText = "شماره ثابت2";
            this.fix_num2.Name = "fix_num2";
            this.fix_num2.Width = 70;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(201, 16);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_msg.Size = new System.Drawing.Size(33, 28);
            this.lbl_msg.TabIndex = 28;
            this.lbl_msg.Text = "---";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.lbl_msg);
            this.groupBox1.Location = new System.Drawing.Point(103, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 59);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // Frm_Lock_give
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(640, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_fix_num2);
            this.Controls.Add(this.txt_fix_num1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lock_num);
            this.Controls.Add(this.txt_Identity_num);
            this.Controls.Add(this.txt_cuMobile);
            this.Controls.Add(this.txt_cuName);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_lock_date);
            this.Controls.Add(this.txt_serial_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_lock_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Lock_give";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صدور شماره قفل به مشتریان";
            this.Load += new System.EventHandler(this.Frm_Lock_give_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_lock_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_lock_list;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox txt_lock_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cuName;
        private System.Windows.Forms.TextBox txt_cuMobile;
        private System.Windows.Forms.TextBox txt_Identity_num;
        private System.Windows.Forms.TextBox txt_Lock_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_serial_num;
        public System.Windows.Forms.TextBox txt_fix_num1;
        public System.Windows.Forms.TextBox txt_fix_num2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn lock_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn lock_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cu_mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn identity_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn lock_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn lock_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_num2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_msg;
    }
}