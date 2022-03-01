
namespace WindowsFormsAppTest
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
            this.AddUrlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewSecurityIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewUrlTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddUrlButton
            // 
            this.AddUrlButton.Location = new System.Drawing.Point(502, 66);
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
            this.NewSecurityIdTextBox.Size = new System.Drawing.Size(551, 20);
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
            this.NewUrlTextBox.Size = new System.Drawing.Size(551, 20);
            this.NewUrlTextBox.TabIndex = 4;
            this.NewUrlTextBox.TextChanged += new System.EventHandler(this.NewUrlTextBox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 109);
            this.Controls.Add(this.NewUrlTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewSecurityIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUrlButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUrlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewSecurityIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewUrlTextBox;
    }
}