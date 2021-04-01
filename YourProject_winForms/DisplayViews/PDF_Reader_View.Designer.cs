using System.Drawing;
using System.Windows.Forms;

namespace YourProject_winForms
{
    partial class PDF_Reader_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_Reader_View));
            this.axAcroPDF_Viewer = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF_Viewer
            // 
            this.axAcroPDF_Viewer.Enabled = true;
            this.axAcroPDF_Viewer.Location = new System.Drawing.Point(12, 12);
            this.axAcroPDF_Viewer.Name = "axAcroPDF_Viewer";
            this.axAcroPDF_Viewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_Viewer.OcxState")));
            this.axAcroPDF_Viewer.Size = new System.Drawing.Size(971, 647);
            this.axAcroPDF_Viewer.TabIndex = 2;
            // 
            // PDF_Reader_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 822);
            this.Controls.Add(this.axAcroPDF_Viewer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1342, 869);
            this.MinimumSize = new System.Drawing.Size(1342, 869);
            this.Name = "PDF_Reader_View";
            this.Text = "PDF_Reader_View";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PDF_Reader_View_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PDF_Reader_View_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_Viewer)).EndInit();
            this.ResumeLayout(false);
                       
        }

        #endregion
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_Viewer;
    }
}