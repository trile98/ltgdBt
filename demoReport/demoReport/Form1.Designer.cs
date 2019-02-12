namespace demoReport
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
            this.crpNV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalrptNV1 = new demoReport.CrystalrptNV();
            this.datasetNV1 = new demoReport.datasetNV();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNV1)).BeginInit();
            this.SuspendLayout();
            // 
            // crpNV
            // 
            this.crpNV.ActiveViewIndex = -1;
            this.crpNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpNV.Location = new System.Drawing.Point(0, 0);
            this.crpNV.Name = "crpNV";
            this.crpNV.Size = new System.Drawing.Size(800, 450);
            this.crpNV.TabIndex = 0;
            this.crpNV.Load += new System.EventHandler(this.crpNV_Load);
            // 
            // datasetNV1
            // 
            this.datasetNV1.DataSetName = "datasetNV";
            this.datasetNV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crpNV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetNV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpNV;
        private CrystalrptNV crystalrptNV1;
        private datasetNV datasetNV1;
    }
}

