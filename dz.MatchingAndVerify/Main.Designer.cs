namespace dz.MatchingAndVerify
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbMatchingJobs = new System.Windows.Forms.ToolStripButton();
            this.tsbMatchingTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMatchingJobs,
            this.tsbMatchingTemplate});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(579, 39);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbMatchingJobs
            // 
            this.tsbMatchingJobs.Image = ((System.Drawing.Image)(resources.GetObject("tsbMatchingJobs.Image")));
            this.tsbMatchingJobs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMatchingJobs.Name = "tsbMatchingJobs";
            this.tsbMatchingJobs.Size = new System.Drawing.Size(138, 36);
            this.tsbMatchingJobs.Text = "Matching Jobs";
            this.tsbMatchingJobs.Click += new System.EventHandler(this.tsbMatchingJobs_Click);
            // 
            // tsbMatchingTemplate
            // 
            this.tsbMatchingTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbMatchingTemplate.Image")));
            this.tsbMatchingTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMatchingTemplate.Name = "tsbMatchingTemplate";
            this.tsbMatchingTemplate.Size = new System.Drawing.Size(169, 36);
            this.tsbMatchingTemplate.Text = "Matching Template";
            this.tsbMatchingTemplate.Click += new System.EventHandler(this.tsbMatchingTemplate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 341);
            this.Controls.Add(this.tsMain);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Matching And Verify";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbMatchingJobs;
        private System.Windows.Forms.ToolStripButton tsbMatchingTemplate;
    }
}

