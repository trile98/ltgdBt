namespace week2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.radioCong = new System.Windows.Forms.RadioButton();
            this.radioTru = new System.Windows.Forms.RadioButton();
            this.radioNhan = new System.Windows.Forms.RadioButton();
            this.radioChia = new System.Windows.Forms.RadioButton();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl1.Location = new System.Drawing.Point(135, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Số 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl2.Location = new System.Drawing.Point(138, 140);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 21);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Số 2";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt1.Location = new System.Drawing.Point(238, 55);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(351, 29);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt2.Location = new System.Drawing.Point(238, 140);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(351, 29);
            this.txt2.TabIndex = 3;
            // 
            // radioCong
            // 
            this.radioCong.AutoSize = true;
            this.radioCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioCong.Location = new System.Drawing.Point(128, 252);
            this.radioCong.Name = "radioCong";
            this.radioCong.Size = new System.Drawing.Size(69, 25);
            this.radioCong.TabIndex = 4;
            this.radioCong.TabStop = true;
            this.radioCong.Text = "Cộng";
            this.radioCong.UseVisualStyleBackColor = true;
            this.radioCong.CheckedChanged += new System.EventHandler(this.radioCong_CheckedChanged);
            // 
            // radioTru
            // 
            this.radioTru.AutoSize = true;
            this.radioTru.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioTru.Location = new System.Drawing.Point(255, 252);
            this.radioTru.Name = "radioTru";
            this.radioTru.Size = new System.Drawing.Size(55, 25);
            this.radioTru.TabIndex = 5;
            this.radioTru.TabStop = true;
            this.radioTru.Text = "Trừ";
            this.radioTru.UseVisualStyleBackColor = true;
            this.radioTru.CheckedChanged += new System.EventHandler(this.radioTru_CheckedChanged);
            // 
            // radioNhan
            // 
            this.radioNhan.AutoSize = true;
            this.radioNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioNhan.Location = new System.Drawing.Point(383, 252);
            this.radioNhan.Name = "radioNhan";
            this.radioNhan.Size = new System.Drawing.Size(67, 25);
            this.radioNhan.TabIndex = 6;
            this.radioNhan.TabStop = true;
            this.radioNhan.Text = "Nhân";
            this.radioNhan.UseVisualStyleBackColor = true;
            this.radioNhan.CheckedChanged += new System.EventHandler(this.radioNhan_CheckedChanged);
            // 
            // radioChia
            // 
            this.radioChia.AutoSize = true;
            this.radioChia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioChia.Location = new System.Drawing.Point(518, 252);
            this.radioChia.Name = "radioChia";
            this.radioChia.Size = new System.Drawing.Size(62, 25);
            this.radioChia.TabIndex = 7;
            this.radioChia.TabStop = true;
            this.radioChia.Text = "Chia";
            this.radioChia.UseVisualStyleBackColor = true;
            this.radioChia.CheckedChanged += new System.EventHandler(this.radioChia_CheckedChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl3.Location = new System.Drawing.Point(138, 346);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(72, 21);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Kết quả:";
            // 
            // txtKq
            // 
            this.txtKq.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKq.Location = new System.Drawing.Point(238, 338);
            this.txtKq.Name = "txtKq";
            this.txtKq.ReadOnly = true;
            this.txtKq.Size = new System.Drawing.Size(351, 29);
            this.txtKq.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.radioChia);
            this.Controls.Add(this.radioNhan);
            this.Controls.Add(this.radioTru);
            this.Controls.Add(this.radioCong);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RadioButton radioCong;
        private System.Windows.Forms.RadioButton radioTru;
        private System.Windows.Forms.RadioButton radioNhan;
        private System.Windows.Forms.RadioButton radioChia;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtKq;
    }
}

