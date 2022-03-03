
namespace WindowsFormsAppTest
{
    partial class WebserviceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WebServiceCmbx = new System.Windows.Forms.ComboBox();
            this.TestAllBtn = new System.Windows.Forms.Button();
            this.TrVwAll = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Webservice";
            // 
            // WebServiceCmbx
            // 
            this.WebServiceCmbx.FormattingEnabled = true;
            this.WebServiceCmbx.Location = new System.Drawing.Point(16, 30);
            this.WebServiceCmbx.Name = "WebServiceCmbx";
            this.WebServiceCmbx.Size = new System.Drawing.Size(234, 21);
            this.WebServiceCmbx.TabIndex = 1;
            this.WebServiceCmbx.SelectedIndexChanged += new System.EventHandler(this.WebServiceCmbx_SelectedIndexChanged);
            // 
            // TestAllBtn
            // 
            this.TestAllBtn.Location = new System.Drawing.Point(16, 57);
            this.TestAllBtn.Name = "TestAllBtn";
            this.TestAllBtn.Size = new System.Drawing.Size(234, 23);
            this.TestAllBtn.TabIndex = 2;
            this.TestAllBtn.Text = "Test All";
            this.TestAllBtn.UseVisualStyleBackColor = true;
            this.TestAllBtn.Click += new System.EventHandler(this.TestAllBtn_Click);
            // 
            // TrVwAll
            // 
            this.TrVwAll.Location = new System.Drawing.Point(280, 30);
            this.TrVwAll.Name = "TrVwAll";
            this.TrVwAll.Size = new System.Drawing.Size(508, 408);
            this.TrVwAll.TabIndex = 3;
            this.TrVwAll.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrVwAll_AfterSelect);
            // 
            // WebserviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrVwAll);
            this.Controls.Add(this.TestAllBtn);
            this.Controls.Add(this.WebServiceCmbx);
            this.Controls.Add(this.label1);
            this.Name = "WebserviceForm";
            this.Text = "WebserviceForm";
            this.Load += new System.EventHandler(this.WebserviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WebServiceCmbx;
        private System.Windows.Forms.Button TestAllBtn;
        private System.Windows.Forms.TreeView TrVwAll;
    }
}