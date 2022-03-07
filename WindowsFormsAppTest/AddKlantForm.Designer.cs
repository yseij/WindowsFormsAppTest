
namespace WindowsFormsAppTest
{
    partial class AddKlantForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.NewKlantNaamTxtBx = new System.Windows.Forms.TextBox();
            this.AddKlantBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // NewKlantNaamTxtBx
            // 
            this.NewKlantNaamTxtBx.Location = new System.Drawing.Point(53, 6);
            this.NewKlantNaamTxtBx.Name = "NewKlantNaamTxtBx";
            this.NewKlantNaamTxtBx.Size = new System.Drawing.Size(397, 20);
            this.NewKlantNaamTxtBx.TabIndex = 11;
            this.NewKlantNaamTxtBx.TextChanged += new System.EventHandler(this.NewSecurityIdTextBox_TextChanged);
            // 
            // AddKlantBttn
            // 
            this.AddKlantBttn.Location = new System.Drawing.Point(323, 30);
            this.AddKlantBttn.Name = "AddKlantBttn";
            this.AddKlantBttn.Size = new System.Drawing.Size(127, 34);
            this.AddKlantBttn.TabIndex = 9;
            this.AddKlantBttn.Text = "Add klant";
            this.AddKlantBttn.UseVisualStyleBackColor = true;
            this.AddKlantBttn.Click += new System.EventHandler(this.AddKlantBttn_Click);
            // 
            // AddKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 74);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewKlantNaamTxtBx);
            this.Controls.Add(this.AddKlantBttn);
            this.Name = "AddKlantForm";
            this.Text = "AddKlantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddKlantBttn;
        private System.Windows.Forms.TextBox NewKlantNaamTxtBx;
    }
}