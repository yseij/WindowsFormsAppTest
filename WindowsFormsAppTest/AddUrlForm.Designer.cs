
namespace WindowsFormsAppTest
{
    partial class AddUrlForm
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
            this.AddUrlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewSecurityIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewUrlTextBox = new System.Windows.Forms.TextBox();
            this.WebServiceCmbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KlantCmbBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddUrlButton
            // 
            this.AddUrlButton.Location = new System.Drawing.Point(348, 122);
            this.AddUrlButton.Name = "AddUrlButton";
            this.AddUrlButton.Size = new System.Drawing.Size(127, 34);
            this.AddUrlButton.TabIndex = 0;
            this.AddUrlButton.Text = "Add url";
            this.AddUrlButton.UseVisualStyleBackColor = true;
            this.AddUrlButton.Click += new System.EventHandler(this.AddUrlButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // NewSecurityIdTextBox
            // 
            this.NewSecurityIdTextBox.Location = new System.Drawing.Point(78, 13);
            this.NewSecurityIdTextBox.Name = "NewSecurityIdTextBox";
            this.NewSecurityIdTextBox.Size = new System.Drawing.Size(397, 20);
            this.NewSecurityIdTextBox.TabIndex = 2;
            this.NewSecurityIdTextBox.TextChanged += new System.EventHandler(this.NewSecurityIdTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SecutiryID";
            // 
            // NewUrlTextBox
            // 
            this.NewUrlTextBox.Location = new System.Drawing.Point(78, 40);
            this.NewUrlTextBox.Name = "NewUrlTextBox";
            this.NewUrlTextBox.Size = new System.Drawing.Size(397, 20);
            this.NewUrlTextBox.TabIndex = 4;
            this.NewUrlTextBox.TextChanged += new System.EventHandler(this.NewUrlTextBox_TextChanged);
            // 
            // WebServiceCmbx
            // 
            this.WebServiceCmbx.FormattingEnabled = true;
            this.WebServiceCmbx.Location = new System.Drawing.Point(78, 66);
            this.WebServiceCmbx.Name = "WebServiceCmbx";
            this.WebServiceCmbx.Size = new System.Drawing.Size(397, 21);
            this.WebServiceCmbx.TabIndex = 5;
            this.WebServiceCmbx.SelectedIndexChanged += new System.EventHandler(this.WebServiceCmbx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Webservice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Klant";
            // 
            // KlantCmbBx
            // 
            this.KlantCmbBx.FormattingEnabled = true;
            this.KlantCmbBx.Location = new System.Drawing.Point(78, 93);
            this.KlantCmbBx.Name = "KlantCmbBx";
            this.KlantCmbBx.Size = new System.Drawing.Size(397, 21);
            this.KlantCmbBx.TabIndex = 7;
            this.KlantCmbBx.SelectedIndexChanged += new System.EventHandler(this.KlantCmbBx_SelectedIndexChanged);
            // 
            // AddUrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 168);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KlantCmbBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WebServiceCmbx);
            this.Controls.Add(this.NewUrlTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewSecurityIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUrlButton);
            this.Name = "AddUrlForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddUrlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUrlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewSecurityIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewUrlTextBox;
        private System.Windows.Forms.ComboBox WebServiceCmbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KlantCmbBx;
    }
}