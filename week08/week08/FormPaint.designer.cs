namespace week08
{
    partial class FormPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaint));
            this.btnline = new System.Windows.Forms.Button();
            this.btnsquare = new System.Windows.Forms.Button();
            this.btntriangle = new System.Windows.Forms.Button();
            this.btncircle = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbsize = new System.Windows.Forms.ComboBox();
            this.lblsize = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btncolor1 = new System.Windows.Forms.Button();
            this.btncolor2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnline
            // 
            this.btnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnline.Location = new System.Drawing.Point(28, 12);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(68, 66);
            this.btnline.TabIndex = 0;
            this.btnline.Text = " ";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnsquare
            // 
            this.btnsquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsquare.Location = new System.Drawing.Point(123, 12);
            this.btnsquare.Name = "btnsquare";
            this.btnsquare.Size = new System.Drawing.Size(68, 66);
            this.btnsquare.TabIndex = 1;
            this.btnsquare.Text = " ";
            this.btnsquare.UseVisualStyleBackColor = true;
            this.btnsquare.Click += new System.EventHandler(this.btnsquare_Click);
            // 
            // btntriangle
            // 
            this.btntriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntriangle.Location = new System.Drawing.Point(218, 12);
            this.btntriangle.Name = "btntriangle";
            this.btntriangle.Size = new System.Drawing.Size(68, 66);
            this.btntriangle.TabIndex = 2;
            this.btntriangle.Text = " ";
            this.btntriangle.UseVisualStyleBackColor = true;
            this.btntriangle.Click += new System.EventHandler(this.btntriangle_Click);
            // 
            // btncircle
            // 
            this.btncircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncircle.Location = new System.Drawing.Point(313, 12);
            this.btncircle.Name = "btncircle";
            this.btncircle.Size = new System.Drawing.Size(68, 66);
            this.btncircle.TabIndex = 3;
            this.btncircle.Text = " ";
            this.btncircle.UseVisualStyleBackColor = true;
            this.btncircle.Click += new System.EventHandler(this.btncircle_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cir1.png");
            this.imageList1.Images.SetKeyName(1, "cir2.png");
            this.imageList1.Images.SetKeyName(2, "line1.png");
            this.imageList1.Images.SetKeyName(3, "line2.png");
            this.imageList1.Images.SetKeyName(4, "sq1.png");
            this.imageList1.Images.SetKeyName(5, "sq2.png");
            this.imageList1.Images.SetKeyName(6, "tri1.png");
            this.imageList1.Images.SetKeyName(7, "tri2.png");
            // 
            // cmbsize
            // 
            this.cmbsize.FormattingEnabled = true;
            this.cmbsize.Location = new System.Drawing.Point(408, 57);
            this.cmbsize.Name = "cmbsize";
            this.cmbsize.Size = new System.Drawing.Size(68, 21);
            this.cmbsize.TabIndex = 4;
            this.cmbsize.SelectedValueChanged += new System.EventHandler(this.cmbsize_SelectedValueChanged);
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.Location = new System.Drawing.Point(404, 21);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(40, 20);
            this.lblsize.TabIndex = 5;
            this.lblsize.Text = "Size";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // btncolor1
            // 
            this.btncolor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolor1.Location = new System.Drawing.Point(503, 12);
            this.btncolor1.Name = "btncolor1";
            this.btncolor1.Size = new System.Drawing.Size(68, 66);
            this.btncolor1.TabIndex = 7;
            this.btncolor1.Text = "Pen";
            this.btncolor1.UseVisualStyleBackColor = true;
            this.btncolor1.Click += new System.EventHandler(this.btncolor1_Click);
            // 
            // btncolor2
            // 
            this.btncolor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolor2.Location = new System.Drawing.Point(598, 12);
            this.btncolor2.Name = "btncolor2";
            this.btncolor2.Size = new System.Drawing.Size(68, 66);
            this.btncolor2.TabIndex = 8;
            this.btncolor2.Text = "Back - ground";
            this.btncolor2.UseVisualStyleBackColor = true;
            this.btncolor2.Click += new System.EventHandler(this.btncolor2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(689, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 66);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Eraser";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 559);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btncolor2);
            this.Controls.Add(this.btncolor1);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.cmbsize);
            this.Controls.Add(this.btncircle);
            this.Controls.Add(this.btntriangle);
            this.Controls.Add(this.btnsquare);
            this.Controls.Add(this.btnline);
            this.Name = "FormPaint";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btnsquare;
        private System.Windows.Forms.Button btntriangle;
        private System.Windows.Forms.Button btncircle;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbsize;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btncolor1;
        private System.Windows.Forms.Button btncolor2;
        private System.Windows.Forms.Button btnXoa;
    }
}

