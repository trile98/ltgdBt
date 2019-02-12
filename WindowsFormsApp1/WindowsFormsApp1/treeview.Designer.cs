namespace WindowsFormsApp1
{
    partial class treeview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(treeview));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDc = new System.Windows.Forms.TextBox();
            this.datetimeNS = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.treeviewSV = new System.Windows.Forms.TreeView();
            this.ctms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rename = new System.Windows.Forms.ToolStripMenuItem();
            this.deletenode = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteall = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ctms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(28, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(28, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lớp";
            // 
            // btncapnhat
            // 
            this.btncapnhat.AutoSize = true;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncapnhat.Location = new System.Drawing.Point(43, 311);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(77, 27);
            this.btncapnhat.TabIndex = 7;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.AutoSize = true;
            this.btntaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntaomoi.Location = new System.Drawing.Point(156, 311);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(75, 27);
            this.btntaomoi.TabIndex = 8;
            this.btntaomoi.Text = "Tạo Mới";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AutoSize = true;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(269, 311);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 27);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMa.Location = new System.Drawing.Point(110, 83);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(217, 23);
            this.txtMa.TabIndex = 10;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(110, 123);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(217, 23);
            this.txtTen.TabIndex = 11;
            // 
            // txtDc
            // 
            this.txtDc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDc.Location = new System.Drawing.Point(110, 163);
            this.txtDc.Name = "txtDc";
            this.txtDc.Size = new System.Drawing.Size(217, 23);
            this.txtDc.TabIndex = 12;
            // 
            // datetimeNS
            // 
            this.datetimeNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.datetimeNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNS.Location = new System.Drawing.Point(110, 200);
            this.datetimeNS.Name = "datetimeNS";
            this.datetimeNS.Size = new System.Drawing.Size(217, 23);
            this.datetimeNS.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLop);
            this.groupBox1.Controls.Add(this.datetimeNS);
            this.groupBox1.Controls.Add(this.txtDc);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btntaomoi);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(466, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 450);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin SV";
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B",
            "Lớp C",
            "Lớp D",
            "Lớp E",
            "Lớp F"});
            this.cmbLop.Location = new System.Drawing.Point(110, 245);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(217, 21);
            this.cmbLop.TabIndex = 15;
            // 
            // treeviewSV
            // 
            this.treeviewSV.ContextMenuStrip = this.ctms;
            this.treeviewSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeviewSV.ImageIndex = 0;
            this.treeviewSV.ImageList = this.imageList1;
            this.treeviewSV.LabelEdit = true;
            this.treeviewSV.Location = new System.Drawing.Point(149, 0);
            this.treeviewSV.Name = "treeviewSV";
            this.treeviewSV.SelectedImageIndex = 0;
            this.treeviewSV.Size = new System.Drawing.Size(311, 450);
            this.treeviewSV.TabIndex = 16;
            // 
            // ctms
            // 
            this.ctms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rename,
            this.deletenode,
            this.deleteall});
            this.ctms.Name = "ctms";
            this.ctms.Size = new System.Drawing.Size(140, 70);
            this.ctms.Text = "Rename";
            // 
            // rename
            // 
            this.rename.Image = ((System.Drawing.Image)(resources.GetObject("rename.Image")));
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(139, 22);
            this.rename.Text = "Rename";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // deletenode
            // 
            this.deletenode.Image = ((System.Drawing.Image)(resources.GetObject("deletenode.Image")));
            this.deletenode.Name = "deletenode";
            this.deletenode.Size = new System.Drawing.Size(139, 22);
            this.deletenode.Text = "Delete Node";
            this.deletenode.Click += new System.EventHandler(this.deletenode_Click);
            // 
            // deleteall
            // 
            this.deleteall.Name = "deleteall";
            this.deleteall.Size = new System.Drawing.Size(139, 22);
            this.deleteall.Text = "Delete All";
            this.deleteall.Click += new System.EventHandler(this.deleteall_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "crown.png");
            // 
            // treeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.treeviewSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "treeview";
            this.Text = "treeview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDc;
        private System.Windows.Forms.DateTimePicker datetimeNS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeviewSV;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ContextMenuStrip ctms;
        private System.Windows.Forms.ToolStripMenuItem rename;
        private System.Windows.Forms.ToolStripMenuItem deletenode;
        private System.Windows.Forms.ToolStripMenuItem deleteall;
        private System.Windows.Forms.ImageList imageList1;
    }
}