
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
            this.label2 = new System.Windows.Forms.Label();
            this.TrVwAll = new System.Windows.Forms.TreeView();
            this.LblKlanten = new MaterialSkin.Controls.MaterialLabel();
            this.KlantsCmbx = new MaterialSkin.Controls.MaterialComboBox();
            this.TestAllBtn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LegeUrlsTxtBx = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.AantalLegeUrlsTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblAantalLegeUrls = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SslChckBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.SllCertificaatVervalDatumTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCertificaatVervalDatum = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxWebservice = new MaterialSkin.Controls.MaterialTextBox();
            this.checkBoxKraanDatabase = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxKraanIni = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxKraanDLL = new MaterialSkin.Controls.MaterialCheckbox();
            this.LblWebserviceVersie = new MaterialSkin.Controls.MaterialLabel();
            this.ZetLogVastChkBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.ResponseTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
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
            this.TrVwAll.Location = new System.Drawing.Point(490, 95);
            this.TrVwAll.Name = "TrVwAll";
            this.TrVwAll.Size = new System.Drawing.Size(577, 429);
            this.TrVwAll.TabIndex = 21;
            this.TrVwAll.Click += new System.EventHandler(this.TrVwAll_Click);
            // 
            // LblKlanten
            // 
            this.LblKlanten.AutoSize = true;
            this.LblKlanten.Depth = 0;
            this.LblKlanten.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblKlanten.Location = new System.Drawing.Point(17, 72);
            this.LblKlanten.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblKlanten.Name = "LblKlanten";
            this.LblKlanten.Size = new System.Drawing.Size(55, 19);
            this.LblKlanten.TabIndex = 30;
            this.LblKlanten.Text = "Klanten";
            // 
            // KlantsCmbx
            // 
            this.KlantsCmbx.AutoResize = false;
            this.KlantsCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.KlantsCmbx.Depth = 0;
            this.KlantsCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.KlantsCmbx.DropDownHeight = 174;
            this.KlantsCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlantsCmbx.DropDownWidth = 121;
            this.KlantsCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.KlantsCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KlantsCmbx.FormattingEnabled = true;
            this.KlantsCmbx.IntegralHeight = false;
            this.KlantsCmbx.ItemHeight = 43;
            this.KlantsCmbx.Location = new System.Drawing.Point(20, 95);
            this.KlantsCmbx.MaxDropDownItems = 4;
            this.KlantsCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantsCmbx.Name = "KlantsCmbx";
            this.KlantsCmbx.Size = new System.Drawing.Size(440, 49);
            this.KlantsCmbx.StartIndex = 0;
            this.KlantsCmbx.TabIndex = 32;
            this.KlantsCmbx.SelectedIndexChanged += new System.EventHandler(this.KlantsCmbx_SelectedIndexChanged);
            // 
            // TestAllBtn
            // 
            this.TestAllBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TestAllBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TestAllBtn.Depth = 0;
            this.TestAllBtn.HighEmphasis = true;
            this.TestAllBtn.Icon = null;
            this.TestAllBtn.Location = new System.Drawing.Point(20, 153);
            this.TestAllBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TestAllBtn.MinimumSize = new System.Drawing.Size(440, 35);
            this.TestAllBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TestAllBtn.Name = "TestAllBtn";
            this.TestAllBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TestAllBtn.Size = new System.Drawing.Size(440, 36);
            this.TestAllBtn.TabIndex = 33;
            this.TestAllBtn.Text = "Test all";
            this.TestAllBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TestAllBtn.UseAccentColor = false;
            this.TestAllBtn.UseVisualStyleBackColor = true;
            this.TestAllBtn.Click += new System.EventHandler(this.TestAllBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox4.Controls.Add(this.LegeUrlsTxtBx);
            this.groupBox4.Controls.Add(this.AantalLegeUrlsTxtBx);
            this.groupBox4.Controls.Add(this.LblAantalLegeUrls);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(22, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 317);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Urls die niet goed gingen";
            // 
            // LegeUrlsTxtBx
            // 
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
            this.LegeUrlsTxtBx.Size = new System.Drawing.Size(415, 233);
            this.LegeUrlsTxtBx.TabIndex = 32;
            this.LegeUrlsTxtBx.TabStop = false;
            this.LegeUrlsTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LegeUrlsTxtBx.UseSystemPasswordChar = false;
            // 
            // AantalLegeUrlsTxtBx
            // 
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
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox5.Controls.Add(this.SslChckBx);
            this.groupBox5.Controls.Add(this.SllCertificaatVervalDatumTxtBx);
            this.groupBox5.Controls.Add(this.LblCertificaatVervalDatum);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(21, 383);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 144);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results SSL certificaat";
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
            this.SslChckBx.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
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
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox6.Controls.Add(this.textBoxWebservice);
            this.groupBox6.Controls.Add(this.checkBoxKraanDatabase);
            this.groupBox6.Controls.Add(this.checkBoxKraanIni);
            this.groupBox6.Controls.Add(this.checkBoxKraanDLL);
            this.groupBox6.Controls.Add(this.LblWebserviceVersie);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox6.Location = new System.Drawing.Point(21, 233);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(439, 144);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Results Webservice";
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
            this.checkBoxKraanDatabase.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
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
            this.checkBoxKraanIni.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
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
            this.checkBoxKraanDLL.Click += new System.EventHandler(this.checkBoxReadOnly_Click);
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
            // ZetLogVastChkBx
            // 
            this.ZetLogVastChkBx.AutoSize = true;
            this.ZetLogVastChkBx.Depth = 0;
            this.ZetLogVastChkBx.Location = new System.Drawing.Point(20, 193);
            this.ZetLogVastChkBx.Margin = new System.Windows.Forms.Padding(0);
            this.ZetLogVastChkBx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ZetLogVastChkBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZetLogVastChkBx.Name = "ZetLogVastChkBx";
            this.ZetLogVastChkBx.ReadOnly = false;
            this.ZetLogVastChkBx.Ripple = true;
            this.ZetLogVastChkBx.Size = new System.Drawing.Size(192, 37);
            this.ZetLogVastChkBx.TabIndex = 34;
            this.ZetLogVastChkBx.Text = "Zet alle gegevens vast";
            this.ZetLogVastChkBx.UseVisualStyleBackColor = true;
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.AnimateReadOnly = false;
            this.ResponseTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResponseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ResponseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResponseTextBox.Depth = 0;
            this.ResponseTextBox.HideSelection = true;
            this.ResponseTextBox.Location = new System.Drawing.Point(490, 558);
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
            this.ResponseTextBox.Size = new System.Drawing.Size(577, 306);
            this.ResponseTextBox.TabIndex = 38;
            this.ResponseTextBox.TabStop = false;
            this.ResponseTextBox.Text = "materialMultiLineTextBox21";
            this.ResponseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ResponseTextBox.UseSystemPasswordChar = false;
            // 
            // WebServicesByKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 887);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.ZetLogVastChkBx);
            this.Controls.Add(this.TestAllBtn);
            this.Controls.Add(this.KlantsCmbx);
            this.Controls.Add(this.LblKlanten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrVwAll);
            this.Name = "WebServicesByKlantForm";
            this.Text = "Per Klant Testen";
            this.Load += new System.EventHandler(this.WebServicesByKlantForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TrVwAll;
        private MaterialSkin.Controls.MaterialLabel LblKlanten;
        private MaterialSkin.Controls.MaterialComboBox KlantsCmbx;
        private MaterialSkin.Controls.MaterialButton TestAllBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 LegeUrlsTxtBx;
        private MaterialSkin.Controls.MaterialTextBox AantalLegeUrlsTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblAantalLegeUrls;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialCheckbox SslChckBx;
        private MaterialSkin.Controls.MaterialTextBox SllCertificaatVervalDatumTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblCertificaatVervalDatum;
        private System.Windows.Forms.GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialTextBox textBoxWebservice;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanDatabase;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanIni;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanDLL;
        private MaterialSkin.Controls.MaterialLabel LblWebserviceVersie;
        private MaterialSkin.Controls.MaterialCheckbox ZetLogVastChkBx;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ResponseTextBox;
    }
}