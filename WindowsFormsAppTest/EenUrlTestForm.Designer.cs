
namespace WindowsFormsAppTest
{
    partial class EenUrlTestForm
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
            this.UrlLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UrlsCmbx = new System.Windows.Forms.ComboBox();
            this.PasUrlAanBttn = new System.Windows.Forms.Button();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxKraanDLL = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanIni = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanDatabase = new System.Windows.Forms.CheckBox();
            this.textBoxWebservice = new System.Windows.Forms.TextBox();
            this.WebserviceLbl = new System.Windows.Forms.Label();
            this.AddUrlButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SecurityEditLbl = new System.Windows.Forms.Label();
            this.UrlEditLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UrlChangeTxtBx = new System.Windows.Forms.TextBox();
            this.SecurityChangeTxtBx = new System.Windows.Forms.TextBox();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.TestRouteBtn = new System.Windows.Forms.Button();
            this.HttpCmbx = new System.Windows.Forms.ComboBox();
            this.PrgrsBrTestUrl = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrlLbl
            // 
            this.UrlLbl.AutoSize = true;
            this.UrlLbl.Location = new System.Drawing.Point(13, 9);
            this.UrlLbl.Name = "UrlLbl";
            this.UrlLbl.Size = new System.Drawing.Size(29, 13);
            this.UrlLbl.TabIndex = 2;
            this.UrlLbl.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // UrlsCmbx
            // 
            this.UrlsCmbx.FormattingEnabled = true;
            this.UrlsCmbx.Location = new System.Drawing.Point(205, 25);
            this.UrlsCmbx.Name = "UrlsCmbx";
            this.UrlsCmbx.Size = new System.Drawing.Size(453, 21);
            this.UrlsCmbx.TabIndex = 7;
            this.UrlsCmbx.SelectedIndexChanged += new System.EventHandler(this.UrlsCmbBx_SelectedIndexChanged);
            // 
            // PasUrlAanBttn
            // 
            this.PasUrlAanBttn.BackColor = System.Drawing.Color.Green;
            this.PasUrlAanBttn.Location = new System.Drawing.Point(676, 205);
            this.PasUrlAanBttn.Margin = new System.Windows.Forms.Padding(0);
            this.PasUrlAanBttn.Name = "PasUrlAanBttn";
            this.PasUrlAanBttn.Size = new System.Drawing.Size(108, 56);
            this.PasUrlAanBttn.TabIndex = 8;
            this.PasUrlAanBttn.Text = "Pas de gegevens aan";
            this.PasUrlAanBttn.UseVisualStyleBackColor = false;
            this.PasUrlAanBttn.Click += new System.EventHandler(this.PasUrlAanBttn_Click);
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Location = new System.Drawing.Point(16, 205);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResponseTextBox.Size = new System.Drawing.Size(642, 195);
            this.ResponseTextBox.TabIndex = 6;
            // 
            // checkBoxKraanDLL
            // 
            this.checkBoxKraanDLL.AutoSize = true;
            this.checkBoxKraanDLL.Location = new System.Drawing.Point(8, 47);
            this.checkBoxKraanDLL.Name = "checkBoxKraanDLL";
            this.checkBoxKraanDLL.Size = new System.Drawing.Size(74, 17);
            this.checkBoxKraanDLL.TabIndex = 10;
            this.checkBoxKraanDLL.Text = "KraanDLL";
            this.checkBoxKraanDLL.UseVisualStyleBackColor = true;
            this.checkBoxKraanDLL.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
            // 
            // checkBoxKraanIni
            // 
            this.checkBoxKraanIni.AutoSize = true;
            this.checkBoxKraanIni.Location = new System.Drawing.Point(8, 70);
            this.checkBoxKraanIni.Name = "checkBoxKraanIni";
            this.checkBoxKraanIni.Size = new System.Drawing.Size(65, 17);
            this.checkBoxKraanIni.TabIndex = 11;
            this.checkBoxKraanIni.Text = "KraanIni";
            this.checkBoxKraanIni.UseVisualStyleBackColor = true;
            this.checkBoxKraanIni.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
            // 
            // checkBoxKraanDatabase
            // 
            this.checkBoxKraanDatabase.AutoSize = true;
            this.checkBoxKraanDatabase.Location = new System.Drawing.Point(8, 93);
            this.checkBoxKraanDatabase.Name = "checkBoxKraanDatabase";
            this.checkBoxKraanDatabase.Size = new System.Drawing.Size(100, 17);
            this.checkBoxKraanDatabase.TabIndex = 12;
            this.checkBoxKraanDatabase.Text = "KraanDatabase";
            this.checkBoxKraanDatabase.UseVisualStyleBackColor = true;
            this.checkBoxKraanDatabase.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
            // 
            // textBoxWebservice
            // 
            this.textBoxWebservice.Location = new System.Drawing.Point(114, 14);
            this.textBoxWebservice.Name = "textBoxWebservice";
            this.textBoxWebservice.ReadOnly = true;
            this.textBoxWebservice.Size = new System.Drawing.Size(217, 20);
            this.textBoxWebservice.TabIndex = 13;
            // 
            // WebserviceLbl
            // 
            this.WebserviceLbl.AutoSize = true;
            this.WebserviceLbl.Location = new System.Drawing.Point(10, 17);
            this.WebserviceLbl.Name = "WebserviceLbl";
            this.WebserviceLbl.Size = new System.Drawing.Size(98, 13);
            this.WebserviceLbl.TabIndex = 14;
            this.WebserviceLbl.Text = "Webservice versie:";
            // 
            // AddUrlButton
            // 
            this.AddUrlButton.Location = new System.Drawing.Point(676, 267);
            this.AddUrlButton.Name = "AddUrlButton";
            this.AddUrlButton.Size = new System.Drawing.Size(214, 44);
            this.AddUrlButton.TabIndex = 15;
            this.AddUrlButton.Text = "Add url";
            this.AddUrlButton.UseVisualStyleBackColor = true;
            this.AddUrlButton.Click += new System.EventHandler(this.AddUrlBttn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.WebserviceLbl);
            this.groupBox1.Controls.Add(this.textBoxWebservice);
            this.groupBox1.Controls.Add(this.checkBoxKraanDatabase);
            this.groupBox1.Controls.Add(this.checkBoxKraanIni);
            this.groupBox1.Controls.Add(this.checkBoxKraanDLL);
            this.groupBox1.Location = new System.Drawing.Point(16, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // SecurityEditLbl
            // 
            this.SecurityEditLbl.AutoSize = true;
            this.SecurityEditLbl.Location = new System.Drawing.Point(752, 24);
            this.SecurityEditLbl.Name = "SecurityEditLbl";
            this.SecurityEditLbl.Size = new System.Drawing.Size(56, 13);
            this.SecurityEditLbl.TabIndex = 18;
            this.SecurityEditLbl.Text = "SecurityID";
            // 
            // UrlEditLbl
            // 
            this.UrlEditLbl.AutoSize = true;
            this.UrlEditLbl.Location = new System.Drawing.Point(769, 118);
            this.UrlEditLbl.Name = "UrlEditLbl";
            this.UrlEditLbl.Size = new System.Drawing.Size(29, 13);
            this.UrlEditLbl.TabIndex = 19;
            this.UrlEditLbl.Text = "URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Log";
            // 
            // UrlChangeTxtBx
            // 
            this.UrlChangeTxtBx.Location = new System.Drawing.Point(676, 134);
            this.UrlChangeTxtBx.Multiline = true;
            this.UrlChangeTxtBx.Name = "UrlChangeTxtBx";
            this.UrlChangeTxtBx.Size = new System.Drawing.Size(214, 65);
            this.UrlChangeTxtBx.TabIndex = 21;
            this.UrlChangeTxtBx.TextChanged += new System.EventHandler(this.UrlChangeTxtBx_TextChanged);
            // 
            // SecurityChangeTxtBx
            // 
            this.SecurityChangeTxtBx.Location = new System.Drawing.Point(676, 40);
            this.SecurityChangeTxtBx.Multiline = true;
            this.SecurityChangeTxtBx.Name = "SecurityChangeTxtBx";
            this.SecurityChangeTxtBx.Size = new System.Drawing.Size(214, 65);
            this.SecurityChangeTxtBx.TabIndex = 22;
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.Red;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(790, 205);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(100, 56);
            this.DeleteUrlBttn.TabIndex = 23;
            this.DeleteUrlBttn.Text = "Delete Url";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            this.DeleteUrlBttn.Click += new System.EventHandler(this.DeleteUrlButton_Click);
            // 
            // TestRouteBtn
            // 
            this.TestRouteBtn.Location = new System.Drawing.Point(676, 317);
            this.TestRouteBtn.Name = "TestRouteBtn";
            this.TestRouteBtn.Size = new System.Drawing.Size(214, 44);
            this.TestRouteBtn.TabIndex = 24;
            this.TestRouteBtn.Text = "Test route";
            this.TestRouteBtn.UseVisualStyleBackColor = true;
            this.TestRouteBtn.Click += new System.EventHandler(this.TestRouteBtn_Click);
            // 
            // HttpCmbx
            // 
            this.HttpCmbx.FormattingEnabled = true;
            this.HttpCmbx.Location = new System.Drawing.Point(16, 24);
            this.HttpCmbx.Name = "HttpCmbx";
            this.HttpCmbx.Size = new System.Drawing.Size(164, 21);
            this.HttpCmbx.TabIndex = 25;
            this.HttpCmbx.SelectedIndexChanged += new System.EventHandler(this.HttpCmbx_SelectedIndexChanged);
            // 
            // PrgrsBrTestUrl
            // 
            this.PrgrsBrTestUrl.Location = new System.Drawing.Point(676, 367);
            this.PrgrsBrTestUrl.Name = "PrgrsBrTestUrl";
            this.PrgrsBrTestUrl.Size = new System.Drawing.Size(214, 33);
            this.PrgrsBrTestUrl.Step = 1;
            this.PrgrsBrTestUrl.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "SSLCertificaat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 410);
            this.Controls.Add(this.PrgrsBrTestUrl);
            this.Controls.Add(this.HttpCmbx);
            this.Controls.Add(this.TestRouteBtn);
            this.Controls.Add(this.DeleteUrlBttn);
            this.Controls.Add(this.SecurityChangeTxtBx);
            this.Controls.Add(this.UrlChangeTxtBx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UrlEditLbl);
            this.Controls.Add(this.SecurityEditLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddUrlButton);
            this.Controls.Add(this.PasUrlAanBttn);
            this.Controls.Add(this.UrlsCmbx);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrlLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UrlLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UrlsCmbx;
        private System.Windows.Forms.Button PasUrlAanBttn;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.TextBox textBoxWebservice;
        private System.Windows.Forms.Label WebserviceLbl;
        private System.Windows.Forms.Button AddUrlButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SecurityEditLbl;
        private System.Windows.Forms.Label UrlEditLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UrlChangeTxtBx;
        private System.Windows.Forms.TextBox SecurityChangeTxtBx;
        private System.Windows.Forms.CheckBox checkBoxKraanIni;
        private System.Windows.Forms.CheckBox checkBoxKraanDatabase;
        private System.Windows.Forms.CheckBox checkBoxKraanDLL;
        private System.Windows.Forms.Button DeleteUrlBttn;
        private System.Windows.Forms.Button TestRouteBtn;
        private System.Windows.Forms.ComboBox HttpCmbx;
        private System.Windows.Forms.ProgressBar PrgrsBrTestUrl;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

