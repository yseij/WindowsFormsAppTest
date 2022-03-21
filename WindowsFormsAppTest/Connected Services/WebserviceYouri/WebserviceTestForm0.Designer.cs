
namespace Kraan.Sales.ConnectionTester
{
    partial class WebserviceTestForm0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebserviceTestForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHttpsText = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.buttonTestSecure = new System.Windows.Forms.Button();
            this.txtTestResultaat = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.TextBoxUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelHttpsText);
            this.groupBox1.Controls.Add(this.textBoxHost);
            this.groupBox1.Controls.Add(this.labelHost);
            this.groupBox1.Controls.Add(this.buttonTestSecure);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 159);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Https";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Wachtwoord";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(100, 67);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(378, 20);
            this.textBoxPassword.TabIndex = 39;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsername.Location = new System.Drawing.Point(100, 45);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(378, 20);
            this.TextBoxUsername.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Gebruikersnaam";
            // 
            // labelHttpsText
            // 
            this.labelHttpsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHttpsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHttpsText.Location = new System.Drawing.Point(6, 112);
            this.labelHttpsText.Name = "labelHttpsText";
            this.labelHttpsText.Size = new System.Drawing.Size(590, 32);
            this.labelHttpsText.TabIndex = 36;
            this.labelHttpsText.Text = "Let op!: Om verbinding te kunnen maken met Kraan Sales dient bij Message Service " +
    "versie 3.1 inlog gegevens te worden geconfigureerd.";
            this.labelHttpsText.Click += new System.EventHandler(this.labelHttpsText_Click);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHost.Location = new System.Drawing.Point(100, 21);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(376, 20);
            this.textBoxHost.TabIndex = 33;
            this.textBoxHost.Text = "https://<subdomain.domain.nl>/KraanSalesService/";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(8, 24);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(55, 13);
            this.labelHost.TabIndex = 32;
            this.labelHost.Text = "Hostname";
            // 
            // buttonTestSecure
            // 
            this.buttonTestSecure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestSecure.Image = global::Kraan.Sales.ConnectionTester.Properties.Resources.lock16;
            this.buttonTestSecure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTestSecure.Location = new System.Drawing.Point(482, 21);
            this.buttonTestSecure.Name = "buttonTestSecure";
            this.buttonTestSecure.Size = new System.Drawing.Size(114, 64);
            this.buttonTestSecure.TabIndex = 29;
            this.buttonTestSecure.Text = "Test Webservices";
            this.buttonTestSecure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTestSecure.UseVisualStyleBackColor = true;
            this.buttonTestSecure.Click += new System.EventHandler(this.buttonTestSecure_Click);
            // 
            // txtTestResultaat
            // 
            this.txtTestResultaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestResultaat.Location = new System.Drawing.Point(10, 176);
            this.txtTestResultaat.Multiline = true;
            this.txtTestResultaat.Name = "txtTestResultaat";
            this.txtTestResultaat.ReadOnly = true;
            this.txtTestResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTestResultaat.Size = new System.Drawing.Size(606, 185);
            this.txtTestResultaat.TabIndex = 36;
            // 
            // WebserviceTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(625, 371);
            this.Controls.Add(this.txtTestResultaat);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebserviceTestForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Kraan.Sales Connection Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebserviceTestForm_FormClosing);
            this.Load += new System.EventHandler(this.WebserviceTestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHttpsText;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Button buttonTestSecure;
        private System.Windows.Forms.TextBox txtTestResultaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label2;
    }
}

