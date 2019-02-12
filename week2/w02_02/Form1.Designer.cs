namespace w02_02
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
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRe = new System.Windows.Forms.RadioButton();
            this.radioBo = new System.Windows.Forms.RadioButton();
            this.radioIt = new System.Windows.Forms.RadioButton();
            this.radioBoth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(288, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Padding = new System.Windows.Forms.Padding(10);
            this.lbl1.Size = new System.Drawing.Size(227, 53);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Đại Học Hoa Sen";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Location = new System.Drawing.Point(35, 25);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(96, 23);
            this.radioAuto.TabIndex = 6;
            this.radioAuto.TabStop = true;
            this.radioAuto.Text = "Auto Color";
            this.radioAuto.UseVisualStyleBackColor = true;
            this.radioAuto.CheckedChanged += new System.EventHandler(this.radioAuto_CheckedChanged);
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(35, 61);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(52, 23);
            this.radioRed.TabIndex = 7;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(35, 101);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(64, 23);
            this.radioGreen.TabIndex = 8;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(35, 141);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(54, 23);
            this.radioBlue.TabIndex = 9;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBlue);
            this.groupBox2.Controls.Add(this.radioGreen);
            this.groupBox2.Controls.Add(this.radioRed);
            this.groupBox2.Controls.Add(this.radioAuto);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(453, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 217);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // radioRe
            // 
            this.radioRe.AutoSize = true;
            this.radioRe.Location = new System.Drawing.Point(23, 25);
            this.radioRe.Name = "radioRe";
            this.radioRe.Size = new System.Drawing.Size(73, 23);
            this.radioRe.TabIndex = 11;
            this.radioRe.TabStop = true;
            this.radioRe.Text = "Regular";
            this.radioRe.UseVisualStyleBackColor = true;
            this.radioRe.CheckedChanged += new System.EventHandler(this.radioRe_CheckedChanged);
            // 
            // radioBo
            // 
            this.radioBo.AutoSize = true;
            this.radioBo.Location = new System.Drawing.Point(23, 66);
            this.radioBo.Name = "radioBo";
            this.radioBo.Size = new System.Drawing.Size(56, 23);
            this.radioBo.TabIndex = 12;
            this.radioBo.TabStop = true;
            this.radioBo.Text = "Bold";
            this.radioBo.UseVisualStyleBackColor = true;
            this.radioBo.CheckedChanged += new System.EventHandler(this.radioBo_CheckedChanged);
            // 
            // radioIt
            // 
            this.radioIt.AutoSize = true;
            this.radioIt.Location = new System.Drawing.Point(23, 107);
            this.radioIt.Name = "radioIt";
            this.radioIt.Size = new System.Drawing.Size(56, 23);
            this.radioIt.TabIndex = 13;
            this.radioIt.TabStop = true;
            this.radioIt.Text = "Italic";
            this.radioIt.UseVisualStyleBackColor = true;
            this.radioIt.CheckedChanged += new System.EventHandler(this.radioIt_CheckedChanged);
            // 
            // radioBoth
            // 
            this.radioBoth.AutoSize = true;
            this.radioBoth.Location = new System.Drawing.Point(23, 148);
            this.radioBoth.Name = "radioBoth";
            this.radioBoth.Size = new System.Drawing.Size(115, 23);
            this.radioBoth.TabIndex = 14;
            this.radioBoth.TabStop = true;
            this.radioBoth.Text = "Bold and Italic";
            this.radioBoth.UseVisualStyleBackColor = true;
            this.radioBoth.CheckedChanged += new System.EventHandler(this.radioBoth_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBoth);
            this.groupBox1.Controls.Add(this.radioIt);
            this.groupBox1.Controls.Add(this.radioBo);
            this.groupBox1.Controls.Add(this.radioRe);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(235, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 210);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Style";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(488, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton radioAuto;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRe;
        private System.Windows.Forms.RadioButton radioBo;
        private System.Windows.Forms.RadioButton radioIt;
        private System.Windows.Forms.RadioButton radioBoth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

