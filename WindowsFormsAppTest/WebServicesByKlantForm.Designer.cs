﻿
namespace WindowsFormsAppTest
{
    partial class WebServicesByKlantForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WebserviceLbl = new System.Windows.Forms.Label();
            this.textBoxWebservice = new System.Windows.Forms.TextBox();
            this.checkBoxKraanDatabase = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanIni = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanDLL = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrVwAll = new System.Windows.Forms.TreeView();
            this.TestAllBtn = new System.Windows.Forms.Button();
            this.KlantsCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LegeUrlsTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AantalLegeUrlsTxtBx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SllCertificaatVervalDatumTxtBx = new System.Windows.Forms.TextBox();
            this.SslChckBx = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.ZetLogVastChkBx = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WebserviceLbl);
            this.groupBox1.Controls.Add(this.textBoxWebservice);
            this.groupBox1.Controls.Add(this.checkBoxKraanDatabase);
            this.groupBox1.Controls.Add(this.checkBoxKraanIni);
            this.groupBox1.Controls.Add(this.checkBoxKraanDLL);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 109);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
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
            // textBoxWebservice
            // 
            this.textBoxWebservice.Location = new System.Drawing.Point(159, 14);
            this.textBoxWebservice.Name = "textBoxWebservice";
            this.textBoxWebservice.ReadOnly = true;
            this.textBoxWebservice.Size = new System.Drawing.Size(172, 20);
            this.textBoxWebservice.TabIndex = 13;
            // 
            // checkBoxKraanDatabase
            // 
            this.checkBoxKraanDatabase.AutoSize = true;
            this.checkBoxKraanDatabase.Location = new System.Drawing.Point(13, 86);
            this.checkBoxKraanDatabase.Name = "checkBoxKraanDatabase";
            this.checkBoxKraanDatabase.Size = new System.Drawing.Size(100, 17);
            this.checkBoxKraanDatabase.TabIndex = 12;
            this.checkBoxKraanDatabase.Text = "KraanDatabase";
            this.checkBoxKraanDatabase.UseVisualStyleBackColor = true;
            this.checkBoxKraanDatabase.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
            // 
            // checkBoxKraanIni
            // 
            this.checkBoxKraanIni.AutoSize = true;
            this.checkBoxKraanIni.Location = new System.Drawing.Point(13, 63);
            this.checkBoxKraanIni.Name = "checkBoxKraanIni";
            this.checkBoxKraanIni.Size = new System.Drawing.Size(65, 17);
            this.checkBoxKraanIni.TabIndex = 11;
            this.checkBoxKraanIni.Text = "KraanIni";
            this.checkBoxKraanIni.UseVisualStyleBackColor = true;
            this.checkBoxKraanIni.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
            // 
            // checkBoxKraanDLL
            // 
            this.checkBoxKraanDLL.AutoSize = true;
            this.checkBoxKraanDLL.Location = new System.Drawing.Point(13, 40);
            this.checkBoxKraanDLL.Name = "checkBoxKraanDLL";
            this.checkBoxKraanDLL.Size = new System.Drawing.Size(74, 17);
            this.checkBoxKraanDLL.TabIndex = 10;
            this.checkBoxKraanDLL.Text = "KraanDLL";
            this.checkBoxKraanDLL.UseVisualStyleBackColor = true;
            this.checkBoxKraanDLL.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Log";
            // 
            // TrVwAll
            // 
            this.TrVwAll.Location = new System.Drawing.Point(366, 28);
            this.TrVwAll.Name = "TrVwAll";
            this.TrVwAll.Size = new System.Drawing.Size(508, 364);
            this.TrVwAll.TabIndex = 21;
            this.TrVwAll.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrVwAll_AfterSelect);
            this.TrVwAll.Click += new System.EventHandler(this.TrVwAll_Click);
            // 
            // TestAllBtn
            // 
            this.TestAllBtn.Location = new System.Drawing.Point(12, 55);
            this.TestAllBtn.Name = "TestAllBtn";
            this.TestAllBtn.Size = new System.Drawing.Size(339, 23);
            this.TestAllBtn.TabIndex = 20;
            this.TestAllBtn.Text = "Test All";
            this.TestAllBtn.UseVisualStyleBackColor = true;
            this.TestAllBtn.Click += new System.EventHandler(this.TestAllBtn_Click);
            // 
            // KlantsCmbx
            // 
            this.KlantsCmbx.FormattingEnabled = true;
            this.KlantsCmbx.Location = new System.Drawing.Point(12, 28);
            this.KlantsCmbx.Name = "KlantsCmbx";
            this.KlantsCmbx.Size = new System.Drawing.Size(339, 21);
            this.KlantsCmbx.TabIndex = 19;
            this.KlantsCmbx.SelectedIndexChanged += new System.EventHandler(this.WebServiceCmbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Klanten";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LegeUrlsTxtBx);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.AantalLegeUrlsTxtBx);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 345);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Urls die leeg waren";
            // 
            // LegeUrlsTxtBx
            // 
            this.LegeUrlsTxtBx.Location = new System.Drawing.Point(13, 39);
            this.LegeUrlsTxtBx.Multiline = true;
            this.LegeUrlsTxtBx.Name = "LegeUrlsTxtBx";
            this.LegeUrlsTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LegeUrlsTxtBx.Size = new System.Drawing.Size(318, 300);
            this.LegeUrlsTxtBx.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Aantal:";
            // 
            // AantalLegeUrlsTxtBx
            // 
            this.AantalLegeUrlsTxtBx.Location = new System.Drawing.Point(159, 13);
            this.AantalLegeUrlsTxtBx.Name = "AantalLegeUrlsTxtBx";
            this.AantalLegeUrlsTxtBx.ReadOnly = true;
            this.AantalLegeUrlsTxtBx.Size = new System.Drawing.Size(172, 20);
            this.AantalLegeUrlsTxtBx.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SllCertificaatVervalDatumTxtBx);
            this.groupBox2.Controls.Add(this.SslChckBx);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 67);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results SSL certificaat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Certificaat vervaldatum:";
            // 
            // SllCertificaatVervalDatumTxtBx
            // 
            this.SllCertificaatVervalDatumTxtBx.Location = new System.Drawing.Point(159, 36);
            this.SllCertificaatVervalDatumTxtBx.Name = "SllCertificaatVervalDatumTxtBx";
            this.SllCertificaatVervalDatumTxtBx.ReadOnly = true;
            this.SllCertificaatVervalDatumTxtBx.Size = new System.Drawing.Size(172, 20);
            this.SllCertificaatVervalDatumTxtBx.TabIndex = 13;
            // 
            // SslChckBx
            // 
            this.SslChckBx.AutoSize = true;
            this.SslChckBx.Location = new System.Drawing.Point(13, 19);
            this.SslChckBx.Name = "SslChckBx";
            this.SslChckBx.Size = new System.Drawing.Size(96, 17);
            this.SslChckBx.TabIndex = 10;
            this.SslChckBx.Text = "SSL Certificaat";
            this.SslChckBx.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(508, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Sla log op";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Location = new System.Drawing.Point(367, 398);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResponseTextBox.Size = new System.Drawing.Size(508, 216);
            this.ResponseTextBox.TabIndex = 27;
            // 
            // ZetLogVastChkBx
            // 
            this.ZetLogVastChkBx.AutoSize = true;
            this.ZetLogVastChkBx.Location = new System.Drawing.Point(12, 87);
            this.ZetLogVastChkBx.Name = "ZetLogVastChkBx";
            this.ZetLogVastChkBx.Size = new System.Drawing.Size(134, 17);
            this.ZetLogVastChkBx.TabIndex = 29;
            this.ZetLogVastChkBx.Text = "Zet alle gegevens vast";
            this.ZetLogVastChkBx.UseVisualStyleBackColor = true;
            // 
            // WebServicesByKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 649);
            this.Controls.Add(this.ZetLogVastChkBx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrVwAll);
            this.Controls.Add(this.TestAllBtn);
            this.Controls.Add(this.KlantsCmbx);
            this.Controls.Add(this.label1);
            this.Name = "WebServicesByKlantForm";
            this.Text = "WebServicesByKlantForm";
            this.Load += new System.EventHandler(this.WebServicesByKlantForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label WebserviceLbl;
        private System.Windows.Forms.TextBox textBoxWebservice;
        private System.Windows.Forms.CheckBox checkBoxKraanDatabase;
        private System.Windows.Forms.CheckBox checkBoxKraanIni;
        private System.Windows.Forms.CheckBox checkBoxKraanDLL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TrVwAll;
        private System.Windows.Forms.Button TestAllBtn;
        private System.Windows.Forms.ComboBox KlantsCmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox LegeUrlsTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AantalLegeUrlsTxtBx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SllCertificaatVervalDatumTxtBx;
        private System.Windows.Forms.CheckBox SslChckBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.CheckBox ZetLogVastChkBx;
    }
}