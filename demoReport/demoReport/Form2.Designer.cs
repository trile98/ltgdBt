namespace demoReport
{
    partial class Form2
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
            this.crviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalrptNV1 = new demoReport.CrystalrptNV();
            this.datasetNV1 = new demoReport.datasetNV();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNV1)).BeginInit();
            this.SuspendLayout();
            // 
            // crviewer
            // 
            this.crviewer.ActiveViewIndex = 0;
            this.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crviewer.Location = new System.Drawing.Point(0, 0);
            this.crviewer.Name = "crviewer";
            this.crviewer.ReportSource = this.crystalrptNV1;
            this.crviewer.Size = new System.Drawing.Size(800, 450);
            this.crviewer.TabIndex = 0;
            this.crviewer.Load += new System.EventHandler(this.crviewer_Load);
            // 
            // datasetNV1
            // 
            this.datasetNV1.DataSetName = "datasetNV";
            this.datasetNV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crviewer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetNV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crviewer;
        private CrystalrptNV crystalrptNV1;
        private datasetNV datasetNV1;
    }
}