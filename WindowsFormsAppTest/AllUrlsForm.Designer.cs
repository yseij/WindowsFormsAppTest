
namespace WindowsFormsAppTest
{
    partial class AllUrlsForm
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
            this.AllUrlsLstBx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlTxtBx = new System.Windows.Forms.TextBox();
            this.PasUrlAanBtn = new System.Windows.Forms.Button();
            this.AddUrlBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecurityIdTxtBx = new System.Windows.Forms.TextBox();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.KlantCmbBx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WebServiceCmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AllUrlsLstBx
            // 
            this.AllUrlsLstBx.FormattingEnabled = true;
            this.AllUrlsLstBx.Location = new System.Drawing.Point(12, 12);
            this.AllUrlsLstBx.Name = "AllUrlsLstBx";
            this.AllUrlsLstBx.Size = new System.Drawing.Size(402, 420);
            this.AllUrlsLstBx.TabIndex = 0;
            this.AllUrlsLstBx.SelectedIndexChanged += new System.EventHandler(this.AllUrlsLstBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Url";
            // 
            // UrlTxtBx
            // 
            this.UrlTxtBx.Location = new System.Drawing.Point(488, 108);
            this.UrlTxtBx.Multiline = true;
            this.UrlTxtBx.Name = "UrlTxtBx";
            this.UrlTxtBx.Size = new System.Drawing.Size(300, 53);
            this.UrlTxtBx.TabIndex = 32;
            this.UrlTxtBx.TextChanged += new System.EventHandler(this.UrlTxtBx_TextChanged);
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.BackColor = System.Drawing.Color.Green;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(680, 218);
            this.PasUrlAanBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.Size = new System.Drawing.Size(108, 56);
            this.PasUrlAanBtn.TabIndex = 28;
            this.PasUrlAanBtn.Text = "Pas de gegevens aan";
            this.PasUrlAanBtn.UseVisualStyleBackColor = false;
            this.PasUrlAanBtn.Click += new System.EventHandler(this.PasUrlAanBtn_Click);
            // 
            // AddUrlBtn
            // 
            this.AddUrlBtn.BackColor = System.Drawing.Color.Green;
            this.AddUrlBtn.Location = new System.Drawing.Point(680, 388);
            this.AddUrlBtn.Name = "AddUrlBtn";
            this.AddUrlBtn.Size = new System.Drawing.Size(108, 44);
            this.AddUrlBtn.TabIndex = 29;
            this.AddUrlBtn.Text = "Add url";
            this.AddUrlBtn.UseVisualStyleBackColor = false;
            this.AddUrlBtn.Click += new System.EventHandler(this.AddUrlBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "SecurityID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "URL";
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.Location = new System.Drawing.Point(488, 44);
            this.SecurityIdTxtBx.Multiline = true;
            this.SecurityIdTxtBx.Name = "SecurityIdTxtBx";
            this.SecurityIdTxtBx.Size = new System.Drawing.Size(300, 56);
            this.SecurityIdTxtBx.TabIndex = 33;
            this.SecurityIdTxtBx.TextChanged += new System.EventHandler(this.SecurityIdTxtBx_TextChanged);
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.Red;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(429, 388);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(100, 44);
            this.DeleteUrlBttn.TabIndex = 34;
            this.DeleteUrlBttn.Text = "Delete Url";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            this.DeleteUrlBttn.Click += new System.EventHandler(this.DeleteUrlBttn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Klant";
            // 
            // KlantCmbBx
            // 
            this.KlantCmbBx.FormattingEnabled = true;
            this.KlantCmbBx.Location = new System.Drawing.Point(488, 194);
            this.KlantCmbBx.Name = "KlantCmbBx";
            this.KlantCmbBx.Size = new System.Drawing.Size(300, 21);
            this.KlantCmbBx.TabIndex = 37;
            this.KlantCmbBx.SelectedIndexChanged += new System.EventHandler(this.KlantCmbBx_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Webservice";
            // 
            // WebServiceCmbx
            // 
            this.WebServiceCmbx.FormattingEnabled = true;
            this.WebServiceCmbx.Location = new System.Drawing.Point(488, 167);
            this.WebServiceCmbx.Name = "WebServiceCmbx";
            this.WebServiceCmbx.Size = new System.Drawing.Size(300, 21);
            this.WebServiceCmbx.TabIndex = 35;
            this.WebServiceCmbx.SelectedIndexChanged += new System.EventHandler(this.WebServiceCmbx_SelectedIndexChanged);
            // 
            // AllUrlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KlantCmbBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WebServiceCmbx);
            this.Controls.Add(this.DeleteUrlBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecurityIdTxtBx);
            this.Controls.Add(this.AllUrlsLstBx);
            this.Controls.Add(this.UrlTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasUrlAanBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddUrlBtn);
            this.Name = "AllUrlsForm";
            this.Text = "AllUrlsForm";
            this.Load += new System.EventHandler(this.AllUrlsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllUrlsLstBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlTxtBx;
        private System.Windows.Forms.Button PasUrlAanBtn;
        private System.Windows.Forms.Button AddUrlBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecurityIdTxtBx;
        private System.Windows.Forms.Button DeleteUrlBttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KlantCmbBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WebServiceCmbx;
    }
}