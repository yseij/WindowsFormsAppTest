
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SslChckBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.SllCertificaatVervalDatumTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCertificaatVervalDatum = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrl = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxWebservice = new MaterialSkin.Controls.MaterialTextBox();
            this.checkBoxKraanDatabase = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxKraanIni = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxKraanDLL = new MaterialSkin.Controls.MaterialCheckbox();
            this.LblWebserviceVersie = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ResponseTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TestRouteBtn = new MaterialSkin.Controls.MaterialButton();
            this.HttpKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.UrlKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(282, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.SslChckBx);
            this.groupBox2.Controls.Add(this.SllCertificaatVervalDatumTxtBx);
            this.groupBox2.Controls.Add(this.LblCertificaatVervalDatum);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(500, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 144);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results SSL certificaat";
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
            this.SllCertificaatVervalDatumTxtBx.Location = new System.Drawing.Point(180, 22);
            this.SllCertificaatVervalDatumTxtBx.MaximumSize = new System.Drawing.Size(500, 50);
            this.SllCertificaatVervalDatumTxtBx.MaxLength = 150;
            this.SllCertificaatVervalDatumTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.SllCertificaatVervalDatumTxtBx.Multiline = false;
            this.SllCertificaatVervalDatumTxtBx.Name = "SllCertificaatVervalDatumTxtBx";
            this.SllCertificaatVervalDatumTxtBx.ReadOnly = true;
            this.SllCertificaatVervalDatumTxtBx.Size = new System.Drawing.Size(236, 50);
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
            this.LblCertificaatVervalDatum.Size = new System.Drawing.Size(170, 19);
            this.LblCertificaatVervalDatum.TabIndex = 6;
            this.LblCertificaatVervalDatum.Text = "Certificaat vervaldatum:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblUrl.Depth = 0;
            this.LblUrl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblUrl.Location = new System.Drawing.Point(22, 81);
            this.LblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(20, 19);
            this.LblUrl.TabIndex = 1;
            this.LblUrl.Text = "Url";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox3.Controls.Add(this.textBoxWebservice);
            this.groupBox3.Controls.Add(this.checkBoxKraanDatabase);
            this.groupBox3.Controls.Add(this.checkBoxKraanIni);
            this.groupBox3.Controls.Add(this.checkBoxKraanDLL);
            this.groupBox3.Controls.Add(this.LblWebserviceVersie);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(25, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 144);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results Webservice";
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
            this.textBoxWebservice.Size = new System.Drawing.Size(272, 50);
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
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(465, 159);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(29, 152);
            this.materialDivider1.TabIndex = 31;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.AnimateReadOnly = false;
            this.ResponseTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResponseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ResponseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResponseTextBox.Depth = 0;
            this.ResponseTextBox.Enabled = false;
            this.ResponseTextBox.HideSelection = true;
            this.ResponseTextBox.Location = new System.Drawing.Point(25, 338);
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
            this.ResponseTextBox.Size = new System.Drawing.Size(925, 196);
            this.ResponseTextBox.TabIndex = 32;
            this.ResponseTextBox.TabStop = false;
            this.ResponseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ResponseTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 316);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(28, 19);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "Log";
            // 
            // TestRouteBtn
            // 
            this.TestRouteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TestRouteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TestRouteBtn.Depth = 0;
            this.TestRouteBtn.HighEmphasis = true;
            this.TestRouteBtn.Icon = null;
            this.TestRouteBtn.Location = new System.Drawing.Point(436, 543);
            this.TestRouteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TestRouteBtn.MinimumSize = new System.Drawing.Size(50, 0);
            this.TestRouteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TestRouteBtn.Name = "TestRouteBtn";
            this.TestRouteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TestRouteBtn.Size = new System.Drawing.Size(106, 36);
            this.TestRouteBtn.TabIndex = 34;
            this.TestRouteBtn.Text = "Test Route";
            this.TestRouteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TestRouteBtn.UseAccentColor = false;
            this.TestRouteBtn.UseVisualStyleBackColor = true;
            this.TestRouteBtn.Click += new System.EventHandler(this.TestRouteBtn_Click);
            // 
            // HttpKrMaterialCmbx
            // 
            this.HttpKrMaterialCmbx.AutoResize = false;
            this.HttpKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HttpKrMaterialCmbx.Depth = 0;
            this.HttpKrMaterialCmbx.DisplayMember = "Name";
            this.HttpKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.HttpKrMaterialCmbx.DropDownHeight = 174;
            this.HttpKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HttpKrMaterialCmbx.DropDownWidth = 121;
            this.HttpKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.HttpKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HttpKrMaterialCmbx.FormattingEnabled = true;
            this.HttpKrMaterialCmbx.IntegralHeight = false;
            this.HttpKrMaterialCmbx.ItemHeight = 43;
            this.HttpKrMaterialCmbx.Location = new System.Drawing.Point(25, 104);
            this.HttpKrMaterialCmbx.MaxDropDownItems = 4;
            this.HttpKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.HttpKrMaterialCmbx.Name = "HttpKrMaterialCmbx";
            this.HttpKrMaterialCmbx.Size = new System.Drawing.Size(251, 49);
            this.HttpKrMaterialCmbx.StartIndex = 0;
            this.HttpKrMaterialCmbx.TabIndex = 35;
            this.HttpKrMaterialCmbx.ValueMember = "Id";
            this.HttpKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.HttpKrMaterialCmbx_SelectedIndexChanged);
            // 
            // UrlKrMaterialCmbx
            // 
            this.UrlKrMaterialCmbx.AutoResize = false;
            this.UrlKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UrlKrMaterialCmbx.Depth = 0;
            this.UrlKrMaterialCmbx.DisplayMember = "Name";
            this.UrlKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UrlKrMaterialCmbx.DropDownHeight = 174;
            this.UrlKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrlKrMaterialCmbx.DropDownWidth = 121;
            this.UrlKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UrlKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UrlKrMaterialCmbx.FormattingEnabled = true;
            this.UrlKrMaterialCmbx.IntegralHeight = false;
            this.UrlKrMaterialCmbx.ItemHeight = 43;
            this.UrlKrMaterialCmbx.Location = new System.Drawing.Point(304, 104);
            this.UrlKrMaterialCmbx.MaxDropDownItems = 4;
            this.UrlKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.UrlKrMaterialCmbx.Name = "UrlKrMaterialCmbx";
            this.UrlKrMaterialCmbx.Size = new System.Drawing.Size(643, 49);
            this.UrlKrMaterialCmbx.StartIndex = 0;
            this.UrlKrMaterialCmbx.TabIndex = 36;
            this.UrlKrMaterialCmbx.ValueMember = "Id";
            this.UrlKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.UrlKrMaterialCmbx_SelectedIndexChanged);
            // 
            // EenUrlTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 590);
            this.Controls.Add(this.UrlKrMaterialCmbx);
            this.Controls.Add(this.HttpKrMaterialCmbx);
            this.Controls.Add(this.TestRouteBtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Name = "EenUrlTestForm";
            this.Sizable = false;
            this.Text = "Test Url";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel LblWebserviceVersie;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanDLL;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanIni;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxKraanDatabase;
        private MaterialSkin.Controls.MaterialTextBox textBoxWebservice;
        private MaterialSkin.Controls.MaterialLabel LblCertificaatVervalDatum;
        private MaterialSkin.Controls.MaterialTextBox SllCertificaatVervalDatumTxtBx;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckbox SslChckBx;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ResponseTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton TestRouteBtn;
        private KrMaterialCombobox HttpKrMaterialCmbx;
        private KrMaterialCombobox UrlKrMaterialCmbx;
    }
}

