namespace week04
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.radioBo = new System.Windows.Forms.RadioButton();
            this.radioIt = new System.Windows.Forms.RadioButton();
            this.radioBoth = new System.Windows.Forms.RadioButton();
            this.radioRe = new System.Windows.Forms.RadioButton();
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioCenter = new System.Windows.Forms.RadioButton();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Align = new System.Windows.Forms.GroupBox();
            this.numericUpDownsize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Align.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsize)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltitle.ForeColor = System.Drawing.Color.Red;
            this.lbltitle.Location = new System.Drawing.Point(154, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(572, 78);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Dai Hoc Hoa Sen";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioBo
            // 
            this.radioBo.AutoSize = true;
            this.radioBo.Location = new System.Drawing.Point(24, 66);
            this.radioBo.Name = "radioBo";
            this.radioBo.Size = new System.Drawing.Size(46, 17);
            this.radioBo.TabIndex = 1;
            this.radioBo.TabStop = true;
            this.radioBo.Text = "Bold";
            this.radioBo.UseVisualStyleBackColor = true;
            this.radioBo.CheckedChanged += new System.EventHandler(this.radioBo_CheckedChanged);
            // 
            // radioIt
            // 
            this.radioIt.AutoSize = true;
            this.radioIt.Location = new System.Drawing.Point(24, 113);
            this.radioIt.Name = "radioIt";
            this.radioIt.Size = new System.Drawing.Size(47, 17);
            this.radioIt.TabIndex = 2;
            this.radioIt.TabStop = true;
            this.radioIt.Text = "Italic";
            this.radioIt.UseVisualStyleBackColor = true;
            this.radioIt.CheckedChanged += new System.EventHandler(this.radioIt_CheckedChanged);
            // 
            // radioBoth
            // 
            this.radioBoth.AutoSize = true;
            this.radioBoth.Location = new System.Drawing.Point(24, 160);
            this.radioBoth.Name = "radioBoth";
            this.radioBoth.Size = new System.Drawing.Size(92, 17);
            this.radioBoth.TabIndex = 3;
            this.radioBoth.TabStop = true;
            this.radioBoth.Text = "Bold and Italic";
            this.radioBoth.UseVisualStyleBackColor = true;
            this.radioBoth.CheckedChanged += new System.EventHandler(this.radioBoth_CheckedChanged);
            // 
            // radioRe
            // 
            this.radioRe.AutoSize = true;
            this.radioRe.Location = new System.Drawing.Point(24, 19);
            this.radioRe.Name = "radioRe";
            this.radioRe.Size = new System.Drawing.Size(62, 17);
            this.radioRe.TabIndex = 4;
            this.radioRe.TabStop = true;
            this.radioRe.Text = "Regular";
            this.radioRe.UseVisualStyleBackColor = true;
            this.radioRe.CheckedChanged += new System.EventHandler(this.radioRe_CheckedChanged);
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Location = new System.Drawing.Point(25, 19);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(74, 17);
            this.radioAuto.TabIndex = 5;
            this.radioAuto.TabStop = true;
            this.radioAuto.Text = "Auto Color";
            this.radioAuto.UseVisualStyleBackColor = true;
            this.radioAuto.CheckedChanged += new System.EventHandler(this.radioAuto_CheckedChanged);
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(25, 113);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(54, 17);
            this.radioGreen.TabIndex = 6;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioGreen_CheckedChanged);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(25, 160);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(46, 17);
            this.radioBlue.TabIndex = 7;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(25, 66);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(45, 17);
            this.radioRed.TabIndex = 8;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioCenter
            // 
            this.radioCenter.AutoSize = true;
            this.radioCenter.Location = new System.Drawing.Point(24, 113);
            this.radioCenter.Name = "radioCenter";
            this.radioCenter.Size = new System.Drawing.Size(56, 17);
            this.radioCenter.TabIndex = 9;
            this.radioCenter.TabStop = true;
            this.radioCenter.Text = "Center";
            this.radioCenter.UseVisualStyleBackColor = true;
            this.radioCenter.CheckedChanged += new System.EventHandler(this.radioCenter_CheckedChanged);
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(24, 19);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(43, 17);
            this.radioLeft.TabIndex = 10;
            this.radioLeft.TabStop = true;
            this.radioLeft.Text = "Left";
            this.radioLeft.UseVisualStyleBackColor = true;
            this.radioLeft.CheckedChanged += new System.EventHandler(this.radioLeft_CheckedChanged);
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(24, 66);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(50, 17);
            this.radioRight.TabIndex = 11;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Right";
            this.radioRight.UseVisualStyleBackColor = true;
            this.radioRight.CheckedChanged += new System.EventHandler(this.radioRight_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioRe);
            this.groupBox1.Controls.Add(this.radioBoth);
            this.groupBox1.Controls.Add(this.radioIt);
            this.groupBox1.Controls.Add(this.radioBo);
            this.groupBox1.Location = new System.Drawing.Point(149, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 195);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Style";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRed);
            this.groupBox2.Controls.Add(this.radioBlue);
            this.groupBox2.Controls.Add(this.radioGreen);
            this.groupBox2.Controls.Add(this.radioAuto);
            this.groupBox2.Location = new System.Drawing.Point(370, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 195);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // Align
            // 
            this.Align.Controls.Add(this.radioRight);
            this.Align.Controls.Add(this.radioLeft);
            this.Align.Controls.Add(this.radioCenter);
            this.Align.Location = new System.Drawing.Point(591, 162);
            this.Align.Name = "Align";
            this.Align.Size = new System.Drawing.Size(135, 195);
            this.Align.TabIndex = 14;
            this.Align.TabStop = false;
            this.Align.Text = "Align";
            // 
            // numericUpDownsize
            // 
            this.numericUpDownsize.Location = new System.Drawing.Point(206, 115);
            this.numericUpDownsize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownsize.Name = "numericUpDownsize";
            this.numericUpDownsize.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownsize.TabIndex = 15;
            this.numericUpDownsize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownsize.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Font Size:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(651, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownsize);
            this.Controls.Add(this.Align);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Align.ResumeLayout(false);
            this.Align.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.RadioButton radioBo;
        private System.Windows.Forms.RadioButton radioIt;
        private System.Windows.Forms.RadioButton radioBoth;
        private System.Windows.Forms.RadioButton radioRe;
        private System.Windows.Forms.RadioButton radioAuto;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioCenter;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Align;
        private System.Windows.Forms.NumericUpDown numericUpDownsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

