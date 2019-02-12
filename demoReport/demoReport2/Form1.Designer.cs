namespace demoReport2
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
            this.viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReport21 = new demoReport2.CrystalReport2();
            this.datasetdemoreport1 = new demoReport2.datasetdemoreport();
            this.crystalReport11 = new demoReport2.CrystalReport1();
            this.rptestgroup1 = new demoReport2.rptestgroup();
            this.rptestgroup2 = new demoReport2.rptestgroup();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datasetdemoreport1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewer
            // 
            this.viewer.ActiveViewIndex = -1;
            this.viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewer.Location = new System.Drawing.Point(0, 87);
            this.viewer.Name = "viewer";
            this.viewer.Size = new System.Drawing.Size(800, 322);
            this.viewer.TabIndex = 0;
            // 
            // datasetdemoreport1
            // 
            this.datasetdemoreport1.DataSetName = "datasetdemoreport";
            this.datasetdemoreport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.viewer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetdemoreport1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewer;
        private CrystalReport2 crystalReport21;
        private datasetdemoreport datasetdemoreport1;
        private CrystalReport1 crystalReport11;
        private rptestgroup rptestgroup1;
        private rptestgroup rptestgroup2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

