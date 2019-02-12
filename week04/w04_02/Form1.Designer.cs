namespace w04_02
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioUSA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAu = new System.Windows.Forms.RadioButton();
            this.radioBrazil = new System.Windows.Forms.RadioButton();
            this.radioCam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxflag = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxflag)).BeginInit();
            this.SuspendLayout();
            // 
            // radioUSA
            // 
            this.radioUSA.AutoSize = true;
            this.radioUSA.Location = new System.Drawing.Point(31, 39);
            this.radioUSA.Name = "radioUSA";
            this.radioUSA.Size = new System.Drawing.Size(47, 17);
            this.radioUSA.TabIndex = 0;
            this.radioUSA.TabStop = true;
            this.radioUSA.Text = "USA";
            this.radioUSA.UseVisualStyleBackColor = true;
            this.radioUSA.CheckedChanged += new System.EventHandler(this.radioUSA_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country Flags ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioAu
            // 
            this.radioAu.AutoSize = true;
            this.radioAu.Location = new System.Drawing.Point(31, 83);
            this.radioAu.Name = "radioAu";
            this.radioAu.Size = new System.Drawing.Size(65, 17);
            this.radioAu.TabIndex = 2;
            this.radioAu.TabStop = true;
            this.radioAu.Text = "Australia";
            this.radioAu.UseVisualStyleBackColor = true;
            this.radioAu.CheckedChanged += new System.EventHandler(this.radioAu_CheckedChanged);
            // 
            // radioBrazil
            // 
            this.radioBrazil.AutoSize = true;
            this.radioBrazil.Location = new System.Drawing.Point(31, 127);
            this.radioBrazil.Name = "radioBrazil";
            this.radioBrazil.Size = new System.Drawing.Size(50, 17);
            this.radioBrazil.TabIndex = 3;
            this.radioBrazil.TabStop = true;
            this.radioBrazil.Text = "Brazil";
            this.radioBrazil.UseVisualStyleBackColor = true;
            this.radioBrazil.CheckedChanged += new System.EventHandler(this.radioBrazil_CheckedChanged);
            // 
            // radioCam
            // 
            this.radioCam.AutoSize = true;
            this.radioCam.Location = new System.Drawing.Point(31, 171);
            this.radioCam.Name = "radioCam";
            this.radioCam.Size = new System.Drawing.Size(72, 17);
            this.radioCam.TabIndex = 4;
            this.radioCam.TabStop = true;
            this.radioCam.Text = "Campudia";
            this.radioCam.UseVisualStyleBackColor = true;
            this.radioCam.CheckedChanged += new System.EventHandler(this.radioCam_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCam);
            this.groupBox1.Controls.Add(this.radioBrazil);
            this.groupBox1.Controls.Add(this.radioAu);
            this.groupBox1.Controls.Add(this.radioUSA);
            this.groupBox1.Location = new System.Drawing.Point(129, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country:";
            // 
            // pictureBoxflag
            // 
            this.pictureBoxflag.Location = new System.Drawing.Point(434, 130);
            this.pictureBoxflag.Name = "pictureBoxflag";
            this.pictureBoxflag.Size = new System.Drawing.Size(246, 198);
            this.pictureBoxflag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxflag.TabIndex = 6;
            this.pictureBoxflag.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "America.png");
            this.imageList1.Images.SetKeyName(1, "Australia.png");
            this.imageList1.Images.SetKeyName(2, "Brazil.png");
            this.imageList1.Images.SetKeyName(3, "Cambodia.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxflag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxflag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioUSA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAu;
        private System.Windows.Forms.RadioButton radioBrazil;
        private System.Windows.Forms.RadioButton radioCam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxflag;
        private System.Windows.Forms.ImageList imageList1;
    }
}

