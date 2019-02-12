namespace week03
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.lblsotc = new System.Windows.Forms.Label();
            this.lblsomon = new System.Windows.Forms.Label();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.btndk = new System.Windows.Forms.Button();
            this.listBoxds = new System.Windows.Forms.ListBox();
            this.combomh = new System.Windows.Forms.ComboBox();
            this.lbltong = new System.Windows.Forms.Label();
            this.lblds = new System.Windows.Forms.Label();
            this.lblmh = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblthongbao1 = new System.Windows.Forms.Label();
            this.btndk1 = new System.Windows.Forms.Button();
            this.listboxdachon = new System.Windows.Forms.ListBox();
            this.listboxmon = new System.Windows.Forms.ListBox();
            this.lbltongtien1 = new System.Windows.Forms.Label();
            this.lblsotc1 = new System.Windows.Forms.Label();
            this.lblsomon1 = new System.Windows.Forms.Label();
            this.lbltong1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(47, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbltongtien);
            this.tabPage1.Controls.Add(this.lblsotc);
            this.tabPage1.Controls.Add(this.lblsomon);
            this.tabPage1.Controls.Add(this.lblthongbao);
            this.tabPage1.Controls.Add(this.btndk);
            this.tabPage1.Controls.Add(this.listBoxds);
            this.tabPage1.Controls.Add(this.combomh);
            this.tabPage1.Controls.Add(this.lbltong);
            this.tabPage1.Controls.Add(this.lblds);
            this.tabPage1.Controls.Add(this.lblmh);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(98, 226);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(58, 13);
            this.lbltongtien.TabIndex = 9;
            this.lbltongtien.Text = "Tổng tiền: ";
            // 
            // lblsotc
            // 
            this.lblsotc.AutoSize = true;
            this.lblsotc.Location = new System.Drawing.Point(98, 190);
            this.lblsotc.Name = "lblsotc";
            this.lblsotc.Size = new System.Drawing.Size(57, 13);
            this.lblsotc.TabIndex = 8;
            this.lblsotc.Text = "số tín chỉ: ";
            // 
            // lblsomon
            // 
            this.lblsomon.AutoSize = true;
            this.lblsomon.Location = new System.Drawing.Point(98, 154);
            this.lblsomon.Name = "lblsomon";
            this.lblsomon.Size = new System.Drawing.Size(47, 13);
            this.lblsomon.TabIndex = 7;
            this.lblsomon.Text = "số môn: ";
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblthongbao.ForeColor = System.Drawing.Color.Red;
            this.lblthongbao.Location = new System.Drawing.Point(98, 39);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(10, 13);
            this.lblthongbao.TabIndex = 6;
            this.lblthongbao.Text = " ";
            // 
            // btndk
            // 
            this.btndk.Location = new System.Drawing.Point(410, 13);
            this.btndk.Name = "btndk";
            this.btndk.Size = new System.Drawing.Size(75, 23);
            this.btndk.TabIndex = 5;
            this.btndk.Text = "Đăng Ký";
            this.btndk.UseVisualStyleBackColor = true;
            this.btndk.Click += new System.EventHandler(this.btndk_Click);
            // 
            // listBoxds
            // 
            this.listBoxds.FormattingEnabled = true;
            this.listBoxds.Location = new System.Drawing.Point(101, 61);
            this.listBoxds.Name = "listBoxds";
            this.listBoxds.ScrollAlwaysVisible = true;
            this.listBoxds.Size = new System.Drawing.Size(293, 82);
            this.listBoxds.TabIndex = 4;
            // 
            // combomh
            // 
            this.combomh.FormattingEnabled = true;
            this.combomh.Location = new System.Drawing.Point(101, 15);
            this.combomh.Name = "combomh";
            this.combomh.Size = new System.Drawing.Size(293, 21);
            this.combomh.TabIndex = 3;
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Location = new System.Drawing.Point(24, 154);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(32, 13);
            this.lbltong.TabIndex = 2;
            this.lbltong.Text = "Tổng";
            // 
            // lblds
            // 
            this.lblds.Location = new System.Drawing.Point(24, 61);
            this.lblds.Name = "lblds";
            this.lblds.Size = new System.Drawing.Size(70, 46);
            this.lblds.TabIndex = 1;
            this.lblds.Text = "Danh Sách Môn Học Đăng Ký";
            // 
            // lblmh
            // 
            this.lblmh.AutoSize = true;
            this.lblmh.Location = new System.Drawing.Point(24, 18);
            this.lblmh.Name = "lblmh";
            this.lblmh.Size = new System.Drawing.Size(51, 13);
            this.lblmh.TabIndex = 0;
            this.lblmh.Text = "Môn Học";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblthongbao1);
            this.tabPage2.Controls.Add(this.btndk1);
            this.tabPage2.Controls.Add(this.listboxdachon);
            this.tabPage2.Controls.Add(this.listboxmon);
            this.tabPage2.Controls.Add(this.lbltongtien1);
            this.tabPage2.Controls.Add(this.lblsotc1);
            this.tabPage2.Controls.Add(this.lblsomon1);
            this.tabPage2.Controls.Add(this.lbltong1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblthongbao1
            // 
            this.lblthongbao1.AutoSize = true;
            this.lblthongbao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblthongbao1.ForeColor = System.Drawing.Color.Red;
            this.lblthongbao1.Location = new System.Drawing.Point(139, 128);
            this.lblthongbao1.Name = "lblthongbao1";
            this.lblthongbao1.Size = new System.Drawing.Size(10, 13);
            this.lblthongbao1.TabIndex = 17;
            this.lblthongbao1.Text = " ";
            // 
            // btndk1
            // 
            this.btndk1.Location = new System.Drawing.Point(189, 62);
            this.btndk1.Name = "btndk1";
            this.btndk1.Size = new System.Drawing.Size(75, 23);
            this.btndk1.TabIndex = 16;
            this.btndk1.Text = "Đăng Ký";
            this.btndk1.UseVisualStyleBackColor = true;
            this.btndk1.Click += new System.EventHandler(this.btndk1_Click);
            // 
            // listboxdachon
            // 
            this.listboxdachon.FormattingEnabled = true;
            this.listboxdachon.Location = new System.Drawing.Point(270, 17);
            this.listboxdachon.Name = "listboxdachon";
            this.listboxdachon.Size = new System.Drawing.Size(226, 108);
            this.listboxdachon.TabIndex = 15;
            // 
            // listboxmon
            // 
            this.listboxmon.FormattingEnabled = true;
            this.listboxmon.Location = new System.Drawing.Point(13, 17);
            this.listboxmon.Name = "listboxmon";
            this.listboxmon.Size = new System.Drawing.Size(159, 108);
            this.listboxmon.TabIndex = 14;
            // 
            // lbltongtien1
            // 
            this.lbltongtien1.AutoSize = true;
            this.lbltongtien1.Location = new System.Drawing.Point(114, 228);
            this.lbltongtien1.Name = "lbltongtien1";
            this.lbltongtien1.Size = new System.Drawing.Size(58, 13);
            this.lbltongtien1.TabIndex = 13;
            this.lbltongtien1.Text = "Tổng tiền: ";
            // 
            // lblsotc1
            // 
            this.lblsotc1.AutoSize = true;
            this.lblsotc1.Location = new System.Drawing.Point(114, 192);
            this.lblsotc1.Name = "lblsotc1";
            this.lblsotc1.Size = new System.Drawing.Size(57, 13);
            this.lblsotc1.TabIndex = 12;
            this.lblsotc1.Text = "số tín chỉ: ";
            // 
            // lblsomon1
            // 
            this.lblsomon1.AutoSize = true;
            this.lblsomon1.Location = new System.Drawing.Point(114, 156);
            this.lblsomon1.Name = "lblsomon1";
            this.lblsomon1.Size = new System.Drawing.Size(47, 13);
            this.lblsomon1.TabIndex = 11;
            this.lblsomon1.Text = "số môn: ";
            // 
            // lbltong1
            // 
            this.lbltong1.AutoSize = true;
            this.lbltong1.Location = new System.Drawing.Point(40, 156);
            this.lbltong1.Name = "lbltong1";
            this.lbltong1.Size = new System.Drawing.Size(32, 13);
            this.lbltong1.TabIndex = 10;
            this.lbltong1.Text = "Tổng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 325);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btndk;
        private System.Windows.Forms.ListBox listBoxds;
        private System.Windows.Forms.ComboBox combomh;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label lblds;
        private System.Windows.Forms.Label lblmh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label lblsotc;
        private System.Windows.Forms.Label lblsomon;
        private System.Windows.Forms.ListBox listboxdachon;
        private System.Windows.Forms.ListBox listboxmon;
        private System.Windows.Forms.Label lbltongtien1;
        private System.Windows.Forms.Label lblsotc1;
        private System.Windows.Forms.Label lblsomon1;
        private System.Windows.Forms.Label lbltong1;
        private System.Windows.Forms.Button btndk1;
        private System.Windows.Forms.Label lblthongbao1;
    }
}

