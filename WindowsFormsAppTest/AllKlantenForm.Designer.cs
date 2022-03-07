
namespace WindowsFormsAppTest
{
    partial class AllKlantenForm
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
            this.DeleteKlantBttn = new System.Windows.Forms.Button();
            this.AllKlantLstBx = new System.Windows.Forms.ListBox();
            this.KlantTxtBx = new System.Windows.Forms.TextBox();
            this.PasKlantAanBtn = new System.Windows.Forms.Button();
            this.AddUrlBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UrlsByKlantLstBx = new System.Windows.Forms.ListBox();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.UrlTxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasUrlAanBtn = new System.Windows.Forms.Button();
            this.AddUrlByKlantBttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KlantCmbBx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WebServiceCmbx = new System.Windows.Forms.ComboBox();
            this.SecurityIdTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteKlantBttn
            // 
            this.DeleteKlantBttn.BackColor = System.Drawing.Color.Red;
            this.DeleteKlantBttn.Location = new System.Drawing.Point(6, 96);
            this.DeleteKlantBttn.Name = "DeleteKlantBttn";
            this.DeleteKlantBttn.Size = new System.Drawing.Size(100, 44);
            this.DeleteKlantBttn.TabIndex = 47;
            this.DeleteKlantBttn.Text = "Klant verwijderen";
            this.DeleteKlantBttn.UseVisualStyleBackColor = false;
            this.DeleteKlantBttn.Click += new System.EventHandler(this.DeleteKlantBttn_Click);
            // 
            // AllKlantLstBx
            // 
            this.AllKlantLstBx.FormattingEnabled = true;
            this.AllKlantLstBx.Location = new System.Drawing.Point(12, 34);
            this.AllKlantLstBx.Name = "AllKlantLstBx";
            this.AllKlantLstBx.Size = new System.Drawing.Size(402, 147);
            this.AllKlantLstBx.TabIndex = 39;
            this.AllKlantLstBx.SelectedIndexChanged += new System.EventHandler(this.AllKlantLstBx_SelectedIndexChanged);
            // 
            // KlantTxtBx
            // 
            this.KlantTxtBx.Location = new System.Drawing.Point(67, 14);
            this.KlantTxtBx.Multiline = true;
            this.KlantTxtBx.Name = "KlantTxtBx";
            this.KlantTxtBx.Size = new System.Drawing.Size(300, 53);
            this.KlantTxtBx.TabIndex = 45;
            this.KlantTxtBx.TextChanged += new System.EventHandler(this.UrlTxtBx_TextChanged);
            // 
            // PasKlantAanBtn
            // 
            this.PasKlantAanBtn.BackColor = System.Drawing.Color.Green;
            this.PasKlantAanBtn.Location = new System.Drawing.Point(259, 70);
            this.PasKlantAanBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PasKlantAanBtn.Name = "PasKlantAanBtn";
            this.PasKlantAanBtn.Size = new System.Drawing.Size(108, 56);
            this.PasKlantAanBtn.TabIndex = 41;
            this.PasKlantAanBtn.Text = "Pas de gegevens aan";
            this.PasKlantAanBtn.UseVisualStyleBackColor = false;
            this.PasKlantAanBtn.Click += new System.EventHandler(this.PasKlantAanBtn_Click);
            // 
            // AddUrlBtn
            // 
            this.AddUrlBtn.BackColor = System.Drawing.Color.Green;
            this.AddUrlBtn.Location = new System.Drawing.Point(110, 96);
            this.AddUrlBtn.Name = "AddUrlBtn";
            this.AddUrlBtn.Size = new System.Drawing.Size(108, 44);
            this.AddUrlBtn.TabIndex = 42;
            this.AddUrlBtn.Text = "Klant toevoegen";
            this.AddUrlBtn.UseVisualStyleBackColor = false;
            this.AddUrlBtn.Click += new System.EventHandler(this.AddUrlBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Klanten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Urls bij de gekozen klant";
            // 
            // UrlsByKlantLstBx
            // 
            this.UrlsByKlantLstBx.FormattingEnabled = true;
            this.UrlsByKlantLstBx.Location = new System.Drawing.Point(12, 210);
            this.UrlsByKlantLstBx.Name = "UrlsByKlantLstBx";
            this.UrlsByKlantLstBx.Size = new System.Drawing.Size(402, 225);
            this.UrlsByKlantLstBx.TabIndex = 49;
            this.UrlsByKlantLstBx.SelectedIndexChanged += new System.EventHandler(this.UrlsByKlantLstBx_SelectedIndexChanged);
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.Red;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(9, 170);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(100, 44);
            this.DeleteUrlBttn.TabIndex = 56;
            this.DeleteUrlBttn.Text = "Url verwijderen";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            this.DeleteUrlBttn.Click += new System.EventHandler(this.DeleteUrlBttn_Click);
            // 
            // UrlTxtBx
            // 
            this.UrlTxtBx.Location = new System.Drawing.Point(67, 65);
            this.UrlTxtBx.Multiline = true;
            this.UrlTxtBx.Name = "UrlTxtBx";
            this.UrlTxtBx.Size = new System.Drawing.Size(295, 39);
            this.UrlTxtBx.TabIndex = 55;
            this.UrlTxtBx.TextChanged += new System.EventHandler(this.UrlTxtBx_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "SecurityId";
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.BackColor = System.Drawing.Color.Green;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(254, 170);
            this.PasUrlAanBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.Size = new System.Drawing.Size(108, 44);
            this.PasUrlAanBtn.TabIndex = 52;
            this.PasUrlAanBtn.Text = "Pas de gegevens aan";
            this.PasUrlAanBtn.UseVisualStyleBackColor = false;
            this.PasUrlAanBtn.Click += new System.EventHandler(this.PasUrlAanBtn_Click);
            // 
            // AddUrlByKlantBttn
            // 
            this.AddUrlByKlantBttn.BackColor = System.Drawing.Color.Green;
            this.AddUrlByKlantBttn.Location = new System.Drawing.Point(115, 170);
            this.AddUrlByKlantBttn.Name = "AddUrlByKlantBttn";
            this.AddUrlByKlantBttn.Size = new System.Drawing.Size(108, 44);
            this.AddUrlByKlantBttn.TabIndex = 53;
            this.AddUrlByKlantBttn.Text = "Url toevoegen";
            this.AddUrlByKlantBttn.UseVisualStyleBackColor = false;
            this.AddUrlByKlantBttn.Click += new System.EventHandler(this.AddUrlByKlantBttn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.KlantTxtBx);
            this.groupBox1.Controls.Add(this.PasKlantAanBtn);
            this.groupBox1.Controls.Add(this.DeleteKlantBttn);
            this.groupBox1.Controls.Add(this.AddUrlBtn);
            this.groupBox1.Location = new System.Drawing.Point(427, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 147);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klant bewerken";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Naam";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.KlantCmbBx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.WebServiceCmbx);
            this.groupBox2.Controls.Add(this.SecurityIdTxtBx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.UrlTxtBx);
            this.groupBox2.Controls.Add(this.PasUrlAanBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DeleteUrlBttn);
            this.groupBox2.Controls.Add(this.AddUrlByKlantBttn);
            this.groupBox2.Location = new System.Drawing.Point(427, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 224);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Url bewerken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Klant";
            // 
            // KlantCmbBx
            // 
            this.KlantCmbBx.FormattingEnabled = true;
            this.KlantCmbBx.Location = new System.Drawing.Point(67, 137);
            this.KlantCmbBx.Name = "KlantCmbBx";
            this.KlantCmbBx.Size = new System.Drawing.Size(295, 21);
            this.KlantCmbBx.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Webservice";
            // 
            // WebServiceCmbx
            // 
            this.WebServiceCmbx.FormattingEnabled = true;
            this.WebServiceCmbx.Location = new System.Drawing.Point(67, 110);
            this.WebServiceCmbx.Name = "WebServiceCmbx";
            this.WebServiceCmbx.Size = new System.Drawing.Size(295, 21);
            this.WebServiceCmbx.TabIndex = 59;
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.Location = new System.Drawing.Point(67, 19);
            this.SecurityIdTxtBx.Multiline = true;
            this.SecurityIdTxtBx.Name = "SecurityIdTxtBx";
            this.SecurityIdTxtBx.Size = new System.Drawing.Size(295, 40);
            this.SecurityIdTxtBx.TabIndex = 58;
            this.SecurityIdTxtBx.TextChanged += new System.EventHandler(this.SecurityIdTxtBx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Naam";
            // 
            // AllKlantenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UrlsByKlantLstBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllKlantLstBx);
            this.Name = "AllKlantenForm";
            this.Text = "AllKlantenForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteKlantBttn;
        private System.Windows.Forms.ListBox AllKlantLstBx;
        private System.Windows.Forms.TextBox KlantTxtBx;
        private System.Windows.Forms.Button PasKlantAanBtn;
        private System.Windows.Forms.Button AddUrlBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox UrlsByKlantLstBx;
        private System.Windows.Forms.Button DeleteUrlBttn;
        private System.Windows.Forms.TextBox UrlTxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PasUrlAanBtn;
        private System.Windows.Forms.Button AddUrlByKlantBttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SecurityIdTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox KlantCmbBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox WebServiceCmbx;
    }
}