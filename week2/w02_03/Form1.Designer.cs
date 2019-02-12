namespace w02_03
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.radioAr = new System.Windows.Forms.RadioButton();
            this.radioTa = new System.Windows.Forms.RadioButton();
            this.radioCo = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl1.Location = new System.Drawing.Point(153, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nhập văn bản:";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt1.Location = new System.Drawing.Point(150, 87);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(237, 214);
            this.txt1.TabIndex = 1;
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioTime.Location = new System.Drawing.Point(466, 102);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(171, 25);
            this.radioTime.TabIndex = 2;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "Times New Roman";
            this.radioTime.UseVisualStyleBackColor = true;
            this.radioTime.CheckedChanged += new System.EventHandler(this.radioTime_CheckedChanged);
            // 
            // radioAr
            // 
            this.radioAr.AutoSize = true;
            this.radioAr.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioAr.Location = new System.Drawing.Point(466, 160);
            this.radioAr.Name = "radioAr";
            this.radioAr.Size = new System.Drawing.Size(63, 25);
            this.radioAr.TabIndex = 3;
            this.radioAr.TabStop = true;
            this.radioAr.Text = "Arial";
            this.radioAr.UseVisualStyleBackColor = true;
            this.radioAr.CheckedChanged += new System.EventHandler(this.radioAr_CheckedChanged);
            // 
            // radioTa
            // 
            this.radioTa.AutoSize = true;
            this.radioTa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioTa.Location = new System.Drawing.Point(466, 218);
            this.radioTa.Name = "radioTa";
            this.radioTa.Size = new System.Drawing.Size(88, 25);
            this.radioTa.TabIndex = 4;
            this.radioTa.TabStop = true;
            this.radioTa.Text = "Tahoma";
            this.radioTa.UseVisualStyleBackColor = true;
            this.radioTa.CheckedChanged += new System.EventHandler(this.radioTa_CheckedChanged);
            // 
            // radioCo
            // 
            this.radioCo.AutoSize = true;
            this.radioCo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioCo.Location = new System.Drawing.Point(466, 276);
            this.radioCo.Name = "radioCo";
            this.radioCo.Size = new System.Drawing.Size(123, 25);
            this.radioCo.TabIndex = 5;
            this.radioCo.TabStop = true;
            this.radioCo.Text = "Courier New";
            this.radioCo.UseVisualStyleBackColor = true;
            this.radioCo.CheckedChanged += new System.EventHandler(this.radioCo_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(308, 321);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 31);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.radioCo);
            this.Controls.Add(this.radioTa);
            this.Controls.Add(this.radioAr);
            this.Controls.Add(this.radioTime);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.RadioButton radioAr;
        private System.Windows.Forms.RadioButton radioTa;
        private System.Windows.Forms.RadioButton radioCo;
        private System.Windows.Forms.Button btnThoat;
    }
}

