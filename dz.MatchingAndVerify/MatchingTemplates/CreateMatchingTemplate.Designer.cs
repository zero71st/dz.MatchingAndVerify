namespace dz.MatchingAndVerify.MatchingTemplates
{
    partial class CreateMatchingTemplate
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
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvTemplates = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFieldName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbComponentName = new System.Windows.Forms.TextBox();
            this.tbFieldValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTemplateName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(576, 417);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(657, 417);
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(133, 68);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(597, 25);
            this.cbProduct.TabIndex = 8;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(133, 22);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(597, 25);
            this.cbCustomer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer";
            // 
            // gvTemplates
            // 
            this.gvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTemplates.Location = new System.Drawing.Point(15, 259);
            this.gvTemplates.Name = "gvTemplates";
            this.gvTemplates.Size = new System.Drawing.Size(715, 150);
            this.gvTemplates.TabIndex = 9;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(574, 223);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 25);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(655, 223);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 25);
            this.btRemove.TabIndex = 11;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sample Job";
            // 
            // cbJob
            // 
            this.cbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(133, 109);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(597, 25);
            this.cbJob.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Field Name";
            // 
            // cbFieldName
            // 
            this.cbFieldName.FormattingEnabled = true;
            this.cbFieldName.Location = new System.Drawing.Point(220, 223);
            this.cbFieldName.Name = "cbFieldName";
            this.cbFieldName.Size = new System.Drawing.Size(121, 25);
            this.cbFieldName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Field Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Component Name";
            // 
            // tbComponentName
            // 
            this.tbComponentName.Location = new System.Drawing.Point(15, 224);
            this.tbComponentName.Name = "tbComponentName";
            this.tbComponentName.Size = new System.Drawing.Size(156, 23);
            this.tbComponentName.TabIndex = 19;
            // 
            // tbFieldValue
            // 
            this.tbFieldValue.Location = new System.Drawing.Point(406, 224);
            this.tbFieldValue.Name = "tbFieldValue";
            this.tbFieldValue.Size = new System.Drawing.Size(162, 23);
            this.tbFieldValue.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Template Name";
            // 
            // tbTemplateName
            // 
            this.tbTemplateName.Location = new System.Drawing.Point(133, 161);
            this.tbTemplateName.Name = "tbTemplateName";
            this.tbTemplateName.Size = new System.Drawing.Size(267, 23);
            this.tbTemplateName.TabIndex = 22;
            // 
            // CreateMatchingTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 458);
            this.Controls.Add(this.tbTemplateName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFieldValue);
            this.Controls.Add(this.tbComponentName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFieldName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.gvTemplates);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateMatchingTemplate";
            this.Text = "Create Matching Template";
            this.Controls.SetChildIndex(this.btSave, 0);
            this.Controls.SetChildIndex(this.btCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbCustomer, 0);
            this.Controls.SetChildIndex(this.cbProduct, 0);
            this.Controls.SetChildIndex(this.gvTemplates, 0);
            this.Controls.SetChildIndex(this.btAdd, 0);
            this.Controls.SetChildIndex(this.btRemove, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbJob, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbFieldName, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbComponentName, 0);
            this.Controls.SetChildIndex(this.tbFieldValue, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbTemplateName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvTemplates;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFieldName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbComponentName;
        private System.Windows.Forms.TextBox tbFieldValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTemplateName;
    }
}