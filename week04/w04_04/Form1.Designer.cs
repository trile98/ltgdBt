namespace w04_04
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownNam = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThang = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNgay = new System.Windows.Forms.NumericUpDown();
            this.btnXem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblthang = new System.Windows.Forms.Label();
            this.lblngay = new System.Windows.Forms.Label();
            this.lblthu = new System.Windows.Forms.Label();
            this.grplich = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNgay)).BeginInit();
            this.grplich.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn Ngày:";
            // 
            // numericUpDownNam
            // 
            this.numericUpDownNam.Location = new System.Drawing.Point(275, 99);
            this.numericUpDownNam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownNam.Name = "numericUpDownNam";
            this.numericUpDownNam.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownNam.TabIndex = 3;
            this.numericUpDownNam.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownNam.ValueChanged += new System.EventHandler(this.numericUpDownNam_ValueChanged);
            // 
            // numericUpDownThang
            // 
            this.numericUpDownThang.Location = new System.Drawing.Point(275, 144);
            this.numericUpDownThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThang.Name = "numericUpDownThang";
            this.numericUpDownThang.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownThang.TabIndex = 4;
            this.numericUpDownThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThang.ValueChanged += new System.EventHandler(this.numericUpDownThang_ValueChanged);
            // 
            // numericUpDownNgay
            // 
            this.numericUpDownNgay.Location = new System.Drawing.Point(275, 189);
            this.numericUpDownNgay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNgay.Name = "numericUpDownNgay";
            this.numericUpDownNgay.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownNgay.TabIndex = 5;
            this.numericUpDownNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNgay.ValueChanged += new System.EventHandler(this.numericUpDownNgay_ValueChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(225, 246);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem Lịch";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(147, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 232);
            this.label4.TabIndex = 7;
            this.label4.Text = " ";
            // 
            // lblthang
            // 
            this.lblthang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblthang.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthang.Location = new System.Drawing.Point(3, 16);
            this.lblthang.Name = "lblthang";
            this.lblthang.Size = new System.Drawing.Size(245, 22);
            this.lblthang.TabIndex = 8;
            this.lblthang.Text = " ";
            this.lblthang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblngay
            // 
            this.lblngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblngay.Location = new System.Drawing.Point(52, 58);
            this.lblngay.Name = "lblngay";
            this.lblngay.Size = new System.Drawing.Size(147, 106);
            this.lblngay.TabIndex = 9;
            this.lblngay.Text = " ";
            this.lblngay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblthu
            // 
            this.lblthu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblthu.Location = new System.Drawing.Point(3, 205);
            this.lblthu.Name = "lblthu";
            this.lblthu.Size = new System.Drawing.Size(245, 24);
            this.lblthu.TabIndex = 10;
            this.lblthu.Text = " ";
            this.lblthu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grplich
            // 
            this.grplich.Controls.Add(this.lblthu);
            this.grplich.Controls.Add(this.lblngay);
            this.grplich.Controls.Add(this.lblthang);
            this.grplich.Location = new System.Drawing.Point(508, 66);
            this.grplich.Name = "grplich";
            this.grplich.Size = new System.Drawing.Size(251, 232);
            this.grplich.TabIndex = 11;
            this.grplich.TabStop = false;
            this.grplich.Text = "Lịch Năm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grplich);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.numericUpDownNgay);
            this.Controls.Add(this.numericUpDownThang);
            this.Controls.Add(this.numericUpDownNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNgay)).EndInit();
            this.grplich.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownNam;
        private System.Windows.Forms.NumericUpDown numericUpDownThang;
        private System.Windows.Forms.NumericUpDown numericUpDownNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblthang;
        private System.Windows.Forms.Label lblngay;
        private System.Windows.Forms.Label lblthu;
        private System.Windows.Forms.GroupBox grplich;
    }
}

