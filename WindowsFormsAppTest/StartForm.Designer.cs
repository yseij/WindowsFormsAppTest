
namespace WindowsFormsAppTest
{
    partial class StartForm
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
            this.OpenTest1UrlBtn = new System.Windows.Forms.Button();
            this.OpenTestWebserviceBtn = new System.Windows.Forms.Button();
            this.OpenTestWebserviceByKlantBtn = new System.Windows.Forms.Button();
            this.UrlsBtn = new System.Windows.Forms.Button();
            this.KlantenBtn = new System.Windows.Forms.Button();
            this.SoapTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenTest1UrlBtn
            // 
            this.OpenTest1UrlBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenTest1UrlBtn.Name = "OpenTest1UrlBtn";
            this.OpenTest1UrlBtn.Size = new System.Drawing.Size(123, 106);
            this.OpenTest1UrlBtn.TabIndex = 0;
            this.OpenTest1UrlBtn.Text = "Test 1 url";
            this.OpenTest1UrlBtn.UseVisualStyleBackColor = true;
            this.OpenTest1UrlBtn.Click += new System.EventHandler(this.OpenTest1UrlBtn_Click);
            // 
            // OpenTestWebserviceBtn
            // 
            this.OpenTestWebserviceBtn.Location = new System.Drawing.Point(151, 12);
            this.OpenTestWebserviceBtn.Name = "OpenTestWebserviceBtn";
            this.OpenTestWebserviceBtn.Size = new System.Drawing.Size(127, 106);
            this.OpenTestWebserviceBtn.TabIndex = 1;
            this.OpenTestWebserviceBtn.Text = "Test Webservice";
            this.OpenTestWebserviceBtn.UseVisualStyleBackColor = true;
            this.OpenTestWebserviceBtn.Click += new System.EventHandler(this.OpenTestWebserviceBtn_Click);
            // 
            // OpenTestWebserviceByKlantBtn
            // 
            this.OpenTestWebserviceByKlantBtn.Location = new System.Drawing.Point(299, 12);
            this.OpenTestWebserviceByKlantBtn.Name = "OpenTestWebserviceByKlantBtn";
            this.OpenTestWebserviceByKlantBtn.Size = new System.Drawing.Size(127, 106);
            this.OpenTestWebserviceByKlantBtn.TabIndex = 2;
            this.OpenTestWebserviceByKlantBtn.Text = "Test Webservice By Klant";
            this.OpenTestWebserviceByKlantBtn.UseVisualStyleBackColor = true;
            this.OpenTestWebserviceByKlantBtn.Click += new System.EventHandler(this.OpenTestWebserviceByKlantBtn_Click);
            // 
            // UrlsBtn
            // 
            this.UrlsBtn.Location = new System.Drawing.Point(12, 124);
            this.UrlsBtn.Name = "UrlsBtn";
            this.UrlsBtn.Size = new System.Drawing.Size(201, 32);
            this.UrlsBtn.TabIndex = 3;
            this.UrlsBtn.Text = "Bekijk alle urls";
            this.UrlsBtn.UseVisualStyleBackColor = true;
            this.UrlsBtn.Click += new System.EventHandler(this.UrlsBtn_Click);
            // 
            // KlantenBtn
            // 
            this.KlantenBtn.Location = new System.Drawing.Point(219, 124);
            this.KlantenBtn.Name = "KlantenBtn";
            this.KlantenBtn.Size = new System.Drawing.Size(207, 32);
            this.KlantenBtn.TabIndex = 4;
            this.KlantenBtn.Text = "Bekijk alle klanten met urls";
            this.KlantenBtn.UseVisualStyleBackColor = true;
            this.KlantenBtn.Click += new System.EventHandler(this.KlantenBtn_Click);
            // 
            // SoapTestBtn
            // 
            this.SoapTestBtn.Location = new System.Drawing.Point(115, 164);
            this.SoapTestBtn.Name = "SoapTestBtn";
            this.SoapTestBtn.Size = new System.Drawing.Size(201, 32);
            this.SoapTestBtn.TabIndex = 5;
            this.SoapTestBtn.Text = "Soap Testen";
            this.SoapTestBtn.UseVisualStyleBackColor = true;
            this.SoapTestBtn.Click += new System.EventHandler(this.SoapTestBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 212);
            this.Controls.Add(this.SoapTestBtn);
            this.Controls.Add(this.KlantenBtn);
            this.Controls.Add(this.UrlsBtn);
            this.Controls.Add(this.OpenTestWebserviceByKlantBtn);
            this.Controls.Add(this.OpenTestWebserviceBtn);
            this.Controls.Add(this.OpenTest1UrlBtn);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenTest1UrlBtn;
        private System.Windows.Forms.Button OpenTestWebserviceBtn;
        private System.Windows.Forms.Button OpenTestWebserviceByKlantBtn;
        private System.Windows.Forms.Button UrlsBtn;
        private System.Windows.Forms.Button KlantenBtn;
        private System.Windows.Forms.Button SoapTestBtn;
    }
}