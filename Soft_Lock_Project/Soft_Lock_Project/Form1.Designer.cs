namespace resolution_changer
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Serial = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ascii_listbox = new System.Windows.Forms.ListBox();
            this.txt_Num_identity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Num_lock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_lock = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(104, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "ذخیره شماره قفل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Serial
            // 
            this.txt_Serial.Location = new System.Drawing.Point(485, 244);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.ReadOnly = true;
            this.txt_Serial.Size = new System.Drawing.Size(64, 20);
            this.txt_Serial.TabIndex = 1;
            this.txt_Serial.TabStop = false;
            this.txt_Serial.TextChanged += new System.EventHandler(this.txt_Serial_TextChanged);
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(485, 275);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.ReadOnly = true;
            this.txt_Model.Size = new System.Drawing.Size(64, 20);
            this.txt_Model.TabIndex = 2;
            this.txt_Model.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "serial : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "model : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "sub string : ";
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(485, 304);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.ReadOnly = true;
            this.txt_sub.Size = new System.Drawing.Size(64, 20);
            this.txt_sub.TabIndex = 5;
            this.txt_sub.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "length :";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(485, 334);
            this.txt_length.Name = "txt_length";
            this.txt_length.ReadOnly = true;
            this.txt_length.Size = new System.Drawing.Size(64, 20);
            this.txt_length.TabIndex = 7;
            this.txt_length.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(453, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(54, 147);
            this.listBox1.TabIndex = 9;
            this.listBox1.TabStop = false;
            // 
            // ascii_listbox
            // 
            this.ascii_listbox.FormattingEnabled = true;
            this.ascii_listbox.Location = new System.Drawing.Point(516, 84);
            this.ascii_listbox.Name = "ascii_listbox";
            this.ascii_listbox.Size = new System.Drawing.Size(55, 147);
            this.ascii_listbox.TabIndex = 10;
            this.ascii_listbox.TabStop = false;
            // 
            // txt_Num_identity
            // 
            this.txt_Num_identity.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Num_identity.Location = new System.Drawing.Point(12, 22);
            this.txt_Num_identity.Name = "txt_Num_identity";
            this.txt_Num_identity.ReadOnly = true;
            this.txt_Num_identity.Size = new System.Drawing.Size(151, 33);
            this.txt_Num_identity.TabIndex = 11;
            this.txt_Num_identity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Num_identity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 78);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(186, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "شماره شناسایی شما : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Num_lock
            // 
            this.txt_Num_lock.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Num_lock.Location = new System.Drawing.Point(13, 103);
            this.txt_Num_lock.MaxLength = 10;
            this.txt_Num_lock.Name = "txt_Num_lock";
            this.txt_Num_lock.Size = new System.Drawing.Size(151, 33);
            this.txt_Num_lock.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(187, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "شماره قفل دریافتی : ";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(13, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-3, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 1);
            this.panel2.TabIndex = 16;
            // 
            // lbl_lock
            // 
            this.lbl_lock.AutoSize = true;
            this.lbl_lock.Location = new System.Drawing.Point(593, 134);
            this.lbl_lock.Name = "lbl_lock";
            this.lbl_lock.Size = new System.Drawing.Size(35, 13);
            this.lbl_lock.TabIndex = 17;
            this.lbl_lock.Text = "label7";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(313, 355);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(37, 13);
            this.lbl_n1.TabIndex = 18;
            this.lbl_n1.Text = "12345";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(325, 383);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(13, 13);
            this.lbl_n2.TabIndex = 19;
            this.lbl_n2.Text = "2";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(420, 413);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(91, 13);
            this.lbl_fname.TabIndex = 20;
            this.lbl_fname.Text = "music_player.mp3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(405, 226);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.lbl_lock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Num_lock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ascii_listbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Serial);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "وارد کردن کد فعال سازی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Serial;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox ascii_listbox;
        private System.Windows.Forms.TextBox txt_Num_identity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Num_lock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_lock;
        public System.Windows.Forms.Label lbl_n1;
        public System.Windows.Forms.Label lbl_n2;
        public System.Windows.Forms.Label lbl_fname;
    }
}

