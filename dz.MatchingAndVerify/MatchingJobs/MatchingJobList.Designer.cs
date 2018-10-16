namespace dz.MatchingAndVerify.MatchingJobs
{
    partial class MatchingJobList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.gvJobs = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 52);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Match And Verify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(12, 12);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(89, 32);
            this.btCreate.TabIndex = 0;
            this.btCreate.Text = "Create Job";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // gvJobs
            // 
            this.gvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvJobs.Location = new System.Drawing.Point(0, 52);
            this.gvJobs.Name = "gvJobs";
            this.gvJobs.Size = new System.Drawing.Size(579, 289);
            this.gvJobs.TabIndex = 1;
            // 
            // MatchingJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 341);
            this.Controls.Add(this.gvJobs);
            this.Controls.Add(this.panel1);
            this.Name = "MatchingJobList";
            this.Text = "Matching Jobs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.DataGridView gvJobs;
        private System.Windows.Forms.Button button1;
    }
}