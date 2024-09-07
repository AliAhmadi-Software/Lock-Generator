namespace Lock_Management_Pro
{
    partial class Frm_GenSerial_Pro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ProSerial = new System.Windows.Forms.TextBox();
            this.txt_pro_date = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmb_software = new System.Windows.Forms.ComboBox();
            this.grd_software = new System.Windows.Forms.DataGridView();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soft_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_num2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_genSerial = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.cmb_fixNum1 = new System.Windows.Forms.ComboBox();
            this.cmb_fixNum2 = new System.Windows.Forms.ComboBox();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.btn_report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_software)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(372, 100);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سریال : ";
            // 
            // txt_ProSerial
            // 
            this.txt_ProSerial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProSerial.Location = new System.Drawing.Point(238, 97);
            this.txt_ProSerial.Name = "txt_ProSerial";
            this.txt_ProSerial.ReadOnly = true;
            this.txt_ProSerial.Size = new System.Drawing.Size(126, 21);
            this.txt_ProSerial.TabIndex = 1;
            // 
            // txt_pro_date
            // 
            this.txt_pro_date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_pro_date.Location = new System.Drawing.Point(240, 22);
            this.txt_pro_date.Mask = "1300/00/00";
            this.txt_pro_date.Name = "txt_pro_date";
            this.txt_pro_date.Size = new System.Drawing.Size(126, 21);
            this.txt_pro_date.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(291, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb_software
            // 
            this.cmb_software.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_software.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_software.FormattingEnabled = true;
            this.cmb_software.Location = new System.Drawing.Point(240, 59);
            this.cmb_software.Name = "cmb_software";
            this.cmb_software.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_software.Size = new System.Drawing.Size(124, 21);
            this.cmb_software.TabIndex = 4;
            this.cmb_software.SelectedIndexChanged += new System.EventHandler(this.cmb_software_SelectedIndexChanged);
            // 
            // grd_software
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
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
            this.grd_software.Location = new System.Drawing.Point(12, 171);
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
            this.grd_software.Size = new System.Drawing.Size(584, 227);
            this.grd_software.TabIndex = 5;
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
            this.soft_name.Width = 110;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(372, 25);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "تاریخ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(372, 62);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "نام نرم افزار :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btn_genSerial
            // 
            this.btn_genSerial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_genSerial.Location = new System.Drawing.Point(183, 96);
            this.btn_genSerial.Name = "btn_genSerial";
            this.btn_genSerial.Size = new System.Drawing.Size(47, 23);
            this.btn_genSerial.TabIndex = 8;
            this.btn_genSerial.Text = "تولید";
            this.btn_genSerial.UseVisualStyleBackColor = true;
            this.btn_genSerial.Click += new System.EventHandler(this.btn_genSerial_Click);
            // 
            // btn_today
            // 
            this.btn_today.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_today.Location = new System.Drawing.Point(183, 22);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(47, 23);
            this.btn_today.TabIndex = 9;
            this.btn_today.Text = "امروز";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // cmb_fixNum1
            // 
            this.cmb_fixNum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fixNum1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_fixNum1.FormattingEnabled = true;
            this.cmb_fixNum1.Location = new System.Drawing.Point(619, 48);
            this.cmb_fixNum1.Name = "cmb_fixNum1";
            this.cmb_fixNum1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_fixNum1.Size = new System.Drawing.Size(73, 21);
            this.cmb_fixNum1.TabIndex = 10;
            // 
            // cmb_fixNum2
            // 
            this.cmb_fixNum2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fixNum2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_fixNum2.FormattingEnabled = true;
            this.cmb_fixNum2.Location = new System.Drawing.Point(619, 85);
            this.cmb_fixNum2.Name = "cmb_fixNum2";
            this.cmb_fixNum2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_fixNum2.Size = new System.Drawing.Size(73, 21);
            this.cmb_fixNum2.TabIndex = 11;
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "cfd2eca6ed364ebc84bfd8d1e2e55b95";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_report.Location = new System.Drawing.Point(183, 139);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 12;
            this.btn_report.Text = "گزارش";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Frm_GenSerial_Pro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(608, 411);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.cmb_fixNum2);
            this.Controls.Add(this.cmb_fixNum1);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.btn_genSerial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grd_software);
            this.Controls.Add(this.cmb_software);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_pro_date);
            this.Controls.Add(this.txt_ProSerial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_GenSerial_Pro";
            this.Text = "صدور سریال محصولات";
            this.Load += new System.EventHandler(this.Frm_GenSerial_Pro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_software)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProSerial;
        private System.Windows.Forms.MaskedTextBox txt_pro_date;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmb_software;
        private System.Windows.Forms.DataGridView grd_software;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.Button btn_genSerial;
        private System.Windows.Forms.ComboBox cmb_fixNum2;
        private System.Windows.Forms.ComboBox cmb_fixNum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn soft_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_num2;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.Button btn_report;
    }
}

