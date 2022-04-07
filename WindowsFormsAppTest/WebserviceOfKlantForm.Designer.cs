
namespace WindowsFormsAppTest
{
    partial class WebserviceOfKlantForm
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
            this.TrVwAll = new System.Windows.Forms.TreeView();
            this.LblWebserviceOfKlant = new MaterialSkin.Controls.MaterialLabel();
            this.ZetLogVastChkBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxWebservice = new MaterialSkin.Controls.MaterialTextBox();
            this.checkBoxKraanDatabase = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxKraanIni = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxKraanDLL = new MaterialSkin.Controls.MaterialCheckbox();
            this.LblWebserviceVersie = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SslChckBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.SllCertificaatVervalDatumTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCertificaatVervalDatum = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LegeUrlsTxtBx = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.AantalLegeUrlsTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblAantalLegeUrls = new MaterialSkin.Controls.MaterialLabel();
            this.ResponseTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.TestAllBtn = new System.Windows.Forms.Button();
            this.WebserviceOfKlantKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrVwAll
            // 
            this.TrVwAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrVwAll.Location = new System.Drawing.Point(476, 98);
            this.TrVwAll.Name = "TrVwAll";
            this.TrVwAll.Size = new System.Drawing.Size(663, 431);
            this.TrVwAll.TabIndex = 3;
            this.TrVwAll.Click += new System.EventHandler(this.TrVwAll_Click);
            // 
            // LblWebserviceOfKlant
            // 
            this.LblWebserviceOfKlant.AutoSize = true;
            this.LblWebserviceOfKlant.Depth = 0;
            this.LblWebserviceOfKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblWebserviceOfKlant.Location = new System.Drawing.Point(22, 76);
            this.LblWebserviceOfKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblWebserviceOfKlant.Name = "LblWebserviceOfKlant";
            this.LblWebserviceOfKlant.Size = new System.Drawing.Size(81, 19);
            this.LblWebserviceOfKlant.TabIndex = 25;
            this.LblWebserviceOfKlant.Text = "Webservice";
            // 
            // ZetLogVastChkBx
            // 
            this.ZetLogVastChkBx.AutoSize = true;
            this.ZetLogVastChkBx.Depth = 0;
            this.ZetLogVastChkBx.Location = new System.Drawing.Point(19, 198);
            this.ZetLogVastChkBx.Margin = new System.Windows.Forms.Padding(0);
            this.ZetLogVastChkBx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ZetLogVastChkBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZetLogVastChkBx.Name = "ZetLogVastChkBx";
            this.ZetLogVastChkBx.ReadOnly = false;
            this.ZetLogVastChkBx.Ripple = true;
            this.ZetLogVastChkBx.Size = new System.Drawing.Size(192, 37);
            this.ZetLogVastChkBx.TabIndex = 28;
            this.ZetLogVastChkBx.Text = "Zet alle gegevens vast";
            this.ZetLogVastChkBx.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox4.Controls.Add(this.textBoxWebservice);
            this.groupBox4.Controls.Add(this.checkBoxKraanDatabase);
            this.groupBox4.Controls.Add(this.checkBoxKraanIni);
            this.groupBox4.Controls.Add(this.checkBoxKraanDLL);
            this.groupBox4.Controls.Add(this.LblWebserviceVersie);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(20, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 144);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results Webservice";
            // 
            // textBoxWebservice
            // 
            this.textBoxWebservice.AnimateReadOnly = false;
            this.textBoxWebservice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxWebservice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWebservice.Depth = 0;
            this.textBoxWebservice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxWebservice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxWebservice.LeadingIcon = null;
            this.textBoxWebservice.Location = new System.Drawing.Point(142, 19);
            this.textBoxWebservice.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxWebservice.MaximumSize = new System.Drawing.Size(500, 50);
            this.textBoxWebservice.MaxLength = 150;
            this.textBoxWebservice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxWebservice.Multiline = false;
            this.textBoxWebservice.Name = "textBoxWebservice";
            this.textBoxWebservice.ReadOnly = true;
            this.textBoxWebservice.Size = new System.Drawing.Size(282, 50);
            this.textBoxWebservice.TabIndex = 5;
            this.textBoxWebservice.Text = "";
            this.textBoxWebservice.TrailingIcon = null;
            // 
            // checkBoxKraanDatabase
            // 
            this.checkBoxKraanDatabase.AutoSize = true;
            this.checkBoxKraanDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.checkBoxKraanDatabase.Depth = 0;
            this.checkBoxKraanDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxKraanDatabase.Location = new System.Drawing.Point(265, 104);
            this.checkBoxKraanDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxKraanDatabase.MaximumSize = new System.Drawing.Size(500, 50);
            this.checkBoxKraanDatabase.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxKraanDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxKraanDatabase.Name = "checkBoxKraanDatabase";
            this.checkBoxKraanDatabase.ReadOnly = true;
            this.checkBoxKraanDatabase.Ripple = true;
            this.checkBoxKraanDatabase.Size = new System.Drawing.Size(149, 37);
            this.checkBoxKraanDatabase.TabIndex = 4;
            this.checkBoxKraanDatabase.Text = "Kraan Database";
            this.checkBoxKraanDatabase.UseVisualStyleBackColor = false;
            // 
            // checkBoxKraanIni
            // 
            this.checkBoxKraanIni.AutoSize = true;
            this.checkBoxKraanIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.checkBoxKraanIni.Depth = 0;
            this.checkBoxKraanIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxKraanIni.Location = new System.Drawing.Point(142, 104);
            this.checkBoxKraanIni.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxKraanIni.MaximumSize = new System.Drawing.Size(500, 50);
            this.checkBoxKraanIni.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxKraanIni.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxKraanIni.Name = "checkBoxKraanIni";
            this.checkBoxKraanIni.ReadOnly = true;
            this.checkBoxKraanIni.Ripple = true;
            this.checkBoxKraanIni.Size = new System.Drawing.Size(98, 37);
            this.checkBoxKraanIni.TabIndex = 3;
            this.checkBoxKraanIni.Text = "Kraan Ini";
            this.checkBoxKraanIni.UseVisualStyleBackColor = false;
            // 
            // checkBoxKraanDLL
            // 
            this.checkBoxKraanDLL.AutoSize = true;
            this.checkBoxKraanDLL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.checkBoxKraanDLL.Depth = 0;
            this.checkBoxKraanDLL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxKraanDLL.Location = new System.Drawing.Point(5, 104);
            this.checkBoxKraanDLL.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxKraanDLL.MaximumSize = new System.Drawing.Size(500, 50);
            this.checkBoxKraanDLL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxKraanDLL.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxKraanDLL.Name = "checkBoxKraanDLL";
            this.checkBoxKraanDLL.ReadOnly = true;
            this.checkBoxKraanDLL.Ripple = true;
            this.checkBoxKraanDLL.Size = new System.Drawing.Size(112, 37);
            this.checkBoxKraanDLL.TabIndex = 2;
            this.checkBoxKraanDLL.Text = "Kraan DDL";
            this.checkBoxKraanDLL.UseVisualStyleBackColor = false;
            // 
            // LblWebserviceVersie
            // 
            this.LblWebserviceVersie.AutoSize = true;
            this.LblWebserviceVersie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblWebserviceVersie.Depth = 0;
            this.LblWebserviceVersie.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblWebserviceVersie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblWebserviceVersie.Location = new System.Drawing.Point(6, 21);
            this.LblWebserviceVersie.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblWebserviceVersie.Name = "LblWebserviceVersie";
            this.LblWebserviceVersie.Size = new System.Drawing.Size(130, 19);
            this.LblWebserviceVersie.TabIndex = 0;
            this.LblWebserviceVersie.Text = "Webservice versie:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.SslChckBx);
            this.groupBox1.Controls.Add(this.SllCertificaatVervalDatumTxtBx);
            this.groupBox1.Controls.Add(this.LblCertificaatVervalDatum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 144);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results SSL certificaat";
            // 
            // SslChckBx
            // 
            this.SslChckBx.AutoSize = true;
            this.SslChckBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SslChckBx.Depth = 0;
            this.SslChckBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SslChckBx.Location = new System.Drawing.Point(11, 104);
            this.SslChckBx.Margin = new System.Windows.Forms.Padding(0);
            this.SslChckBx.MaximumSize = new System.Drawing.Size(500, 50);
            this.SslChckBx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SslChckBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.SslChckBx.Name = "SslChckBx";
            this.SslChckBx.ReadOnly = true;
            this.SslChckBx.Ripple = true;
            this.SslChckBx.Size = new System.Drawing.Size(141, 37);
            this.SslChckBx.TabIndex = 6;
            this.SslChckBx.Text = "SSL Certificaat";
            this.SslChckBx.UseVisualStyleBackColor = false;
            // 
            // SllCertificaatVervalDatumTxtBx
            // 
            this.SllCertificaatVervalDatumTxtBx.AnimateReadOnly = false;
            this.SllCertificaatVervalDatumTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SllCertificaatVervalDatumTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SllCertificaatVervalDatumTxtBx.Depth = 0;
            this.SllCertificaatVervalDatumTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SllCertificaatVervalDatumTxtBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SllCertificaatVervalDatumTxtBx.LeadingIcon = null;
            this.SllCertificaatVervalDatumTxtBx.Location = new System.Drawing.Point(189, 22);
            this.SllCertificaatVervalDatumTxtBx.MaximumSize = new System.Drawing.Size(500, 50);
            this.SllCertificaatVervalDatumTxtBx.MaxLength = 150;
            this.SllCertificaatVervalDatumTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.SllCertificaatVervalDatumTxtBx.Multiline = false;
            this.SllCertificaatVervalDatumTxtBx.Name = "SllCertificaatVervalDatumTxtBx";
            this.SllCertificaatVervalDatumTxtBx.ReadOnly = true;
            this.SllCertificaatVervalDatumTxtBx.Size = new System.Drawing.Size(235, 50);
            this.SllCertificaatVervalDatumTxtBx.TabIndex = 7;
            this.SllCertificaatVervalDatumTxtBx.Text = "";
            this.SllCertificaatVervalDatumTxtBx.TrailingIcon = null;
            // 
            // LblCertificaatVervalDatum
            // 
            this.LblCertificaatVervalDatum.AutoSize = true;
            this.LblCertificaatVervalDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblCertificaatVervalDatum.Depth = 0;
            this.LblCertificaatVervalDatum.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCertificaatVervalDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCertificaatVervalDatum.Location = new System.Drawing.Point(8, 24);
            this.LblCertificaatVervalDatum.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCertificaatVervalDatum.Name = "LblCertificaatVervalDatum";
            this.LblCertificaatVervalDatum.Size = new System.Drawing.Size(179, 19);
            this.LblCertificaatVervalDatum.TabIndex = 6;
            this.LblCertificaatVervalDatum.Text = "Certificaat vervauldatum:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.LegeUrlsTxtBx);
            this.groupBox2.Controls.Add(this.AantalLegeUrlsTxtBx);
            this.groupBox2.Controls.Add(this.LblAantalLegeUrls);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(21, 549);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 272);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Urls die niet goed gingen";
            // 
            // LegeUrlsTxtBx
            // 
            this.LegeUrlsTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LegeUrlsTxtBx.AnimateReadOnly = false;
            this.LegeUrlsTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LegeUrlsTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LegeUrlsTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LegeUrlsTxtBx.Depth = 0;
            this.LegeUrlsTxtBx.HideSelection = true;
            this.LegeUrlsTxtBx.Location = new System.Drawing.Point(8, 78);
            this.LegeUrlsTxtBx.MaxLength = 32767;
            this.LegeUrlsTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.LegeUrlsTxtBx.Name = "LegeUrlsTxtBx";
            this.LegeUrlsTxtBx.PasswordChar = '\0';
            this.LegeUrlsTxtBx.ReadOnly = false;
            this.LegeUrlsTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LegeUrlsTxtBx.SelectedText = "";
            this.LegeUrlsTxtBx.SelectionLength = 0;
            this.LegeUrlsTxtBx.SelectionStart = 0;
            this.LegeUrlsTxtBx.ShortcutsEnabled = true;
            this.LegeUrlsTxtBx.Size = new System.Drawing.Size(415, 188);
            this.LegeUrlsTxtBx.TabIndex = 32;
            this.LegeUrlsTxtBx.TabStop = false;
            this.LegeUrlsTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LegeUrlsTxtBx.UseSystemPasswordChar = false;
            // 
            // AantalLegeUrlsTxtBx
            // 
            this.AantalLegeUrlsTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AantalLegeUrlsTxtBx.AnimateReadOnly = false;
            this.AantalLegeUrlsTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AantalLegeUrlsTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AantalLegeUrlsTxtBx.Depth = 0;
            this.AantalLegeUrlsTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AantalLegeUrlsTxtBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AantalLegeUrlsTxtBx.LeadingIcon = null;
            this.AantalLegeUrlsTxtBx.Location = new System.Drawing.Point(65, 22);
            this.AantalLegeUrlsTxtBx.MaximumSize = new System.Drawing.Size(500, 50);
            this.AantalLegeUrlsTxtBx.MaxLength = 150;
            this.AantalLegeUrlsTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.AantalLegeUrlsTxtBx.Multiline = false;
            this.AantalLegeUrlsTxtBx.Name = "AantalLegeUrlsTxtBx";
            this.AantalLegeUrlsTxtBx.ReadOnly = true;
            this.AantalLegeUrlsTxtBx.Size = new System.Drawing.Size(358, 50);
            this.AantalLegeUrlsTxtBx.TabIndex = 7;
            this.AantalLegeUrlsTxtBx.Text = "";
            this.AantalLegeUrlsTxtBx.TrailingIcon = null;
            // 
            // LblAantalLegeUrls
            // 
            this.LblAantalLegeUrls.AutoSize = true;
            this.LblAantalLegeUrls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblAantalLegeUrls.Depth = 0;
            this.LblAantalLegeUrls.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblAantalLegeUrls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAantalLegeUrls.Location = new System.Drawing.Point(8, 24);
            this.LblAantalLegeUrls.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAantalLegeUrls.Name = "LblAantalLegeUrls";
            this.LblAantalLegeUrls.Size = new System.Drawing.Size(51, 19);
            this.LblAantalLegeUrls.TabIndex = 6;
            this.LblAantalLegeUrls.Text = "Aantal:";
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseTextBox.AnimateReadOnly = false;
            this.ResponseTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResponseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ResponseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResponseTextBox.Depth = 0;
            this.ResponseTextBox.HideSelection = true;
            this.ResponseTextBox.Location = new System.Drawing.Point(476, 560);
            this.ResponseTextBox.MaxLength = 32767;
            this.ResponseTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.PasswordChar = '\0';
            this.ResponseTextBox.ReadOnly = false;
            this.ResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ResponseTextBox.SelectedText = "";
            this.ResponseTextBox.SelectionLength = 0;
            this.ResponseTextBox.SelectionStart = 0;
            this.ResponseTextBox.ShortcutsEnabled = true;
            this.ResponseTextBox.Size = new System.Drawing.Size(663, 261);
            this.ResponseTextBox.TabIndex = 32;
            this.ResponseTextBox.TabStop = false;
            this.ResponseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ResponseTextBox.UseSystemPasswordChar = false;
            // 
            // TestAllBtn
            // 
            this.TestAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.TestAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestAllBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.TestAllBtn.Location = new System.Drawing.Point(21, 152);
            this.TestAllBtn.Name = "TestAllBtn";
            this.TestAllBtn.Size = new System.Drawing.Size(439, 43);
            this.TestAllBtn.TabIndex = 65;
            this.TestAllBtn.Text = "Test Alles";
            this.TestAllBtn.UseVisualStyleBackColor = false;
            this.TestAllBtn.Click += new System.EventHandler(this.TestAllBtn_Click_1);
            // 
            // WebserviceOfKlantKrMaterialCmbx
            // 
            this.WebserviceOfKlantKrMaterialCmbx.AutoResize = false;
            this.WebserviceOfKlantKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WebserviceOfKlantKrMaterialCmbx.Depth = 0;
            this.WebserviceOfKlantKrMaterialCmbx.DisplayMember = "Name";
            this.WebserviceOfKlantKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WebserviceOfKlantKrMaterialCmbx.DropDownHeight = 174;
            this.WebserviceOfKlantKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebserviceOfKlantKrMaterialCmbx.DropDownWidth = 121;
            this.WebserviceOfKlantKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WebserviceOfKlantKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WebserviceOfKlantKrMaterialCmbx.FormattingEnabled = true;
            this.WebserviceOfKlantKrMaterialCmbx.IntegralHeight = false;
            this.WebserviceOfKlantKrMaterialCmbx.ItemHeight = 43;
            this.WebserviceOfKlantKrMaterialCmbx.Location = new System.Drawing.Point(21, 98);
            this.WebserviceOfKlantKrMaterialCmbx.MaxDropDownItems = 4;
            this.WebserviceOfKlantKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebserviceOfKlantKrMaterialCmbx.Name = "WebserviceOfKlantKrMaterialCmbx";
            this.WebserviceOfKlantKrMaterialCmbx.Size = new System.Drawing.Size(439, 49);
            this.WebserviceOfKlantKrMaterialCmbx.StartIndex = 0;
            this.WebserviceOfKlantKrMaterialCmbx.TabIndex = 33;
            this.WebserviceOfKlantKrMaterialCmbx.ValueMember = "Id";
            this.WebserviceOfKlantKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.WebserviceOfKlantKrMaterialCmbx_SelectedIndexChanged);
            // 
            // WebserviceOfKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 827);
            this.Controls.Add(this.TestAllBtn);
            this.Controls.Add(this.WebserviceOfKlantKrMaterialCmbx);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ZetLogVastChkBx);
            this.Controls.Add(this.LblWebserviceOfKlant);
            this.Controls.Add(this.TrVwAll);
            this.MinimumSize = new System.Drawing.Size(936, 827);
            this.Name = "WebserviceOfKlantForm";
            this.Text = "Per Webservice Testen";
            this.TopMost = true;
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView TrVwAll;
        private MaterialSkin.Controls.MaterialLabel LblWebserviceOfKlant;
        private MaterialSkin.Controls.MaterialCheckbox ZetLogVastChkBx;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialTextBox textBoxWebservice;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanDatabase;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanIni;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanDLL;
        private MaterialSkin.Controls.MaterialLabel LblWebserviceVersie;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckbox SslChckBx;
        private MaterialSkin.Controls.MaterialTextBox SllCertificaatVervalDatumTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblCertificaatVervalDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 LegeUrlsTxtBx;
        private MaterialSkin.Controls.MaterialTextBox AantalLegeUrlsTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblAantalLegeUrls;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ResponseTextBox;
        private KrMaterialCombobox WebserviceOfKlantKrMaterialCmbx;
        private System.Windows.Forms.Button TestAllBtn;
    }
}