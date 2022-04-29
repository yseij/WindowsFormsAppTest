﻿
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BasisUrl2TxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BasisUrl1TxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.PasKlantAanBtn = new System.Windows.Forms.Button();
            this.AddKlantBtn = new System.Windows.Forms.Button();
            this.KlantTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.DeleteKlantBttn = new System.Windows.Forms.Button();
            this.LblNaam = new MaterialSkin.Controls.MaterialLabel();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrlsByKlant = new MaterialSkin.Controls.MaterialLabel();
            this.UrlTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblNaamUrl = new MaterialSkin.Controls.MaterialLabel();
            this.LblBasisUrl = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PasUrlAanBtn = new System.Windows.Forms.Button();
            this.AddUrlByWebserviceBttn = new System.Windows.Forms.Button();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ZoekOpKlantNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.AllKlantKrLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.AllWebserviceKrLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.SoapWebserviceChkBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BasisUrl2TxtBx);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.BasisUrl1TxtBx);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.PasKlantAanBtn);
            this.groupBox1.Controls.Add(this.AddKlantBtn);
            this.groupBox1.Controls.Add(this.KlantTxtBx);
            this.groupBox1.Controls.Add(this.DeleteKlantBttn);
            this.groupBox1.Controls.Add(this.LblNaam);
            this.groupBox1.Location = new System.Drawing.Point(376, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 244);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klant bewerken";
            // 
            // BasisUrl2TxtBx
            // 
            this.BasisUrl2TxtBx.AllowPromptAsInput = true;
            this.BasisUrl2TxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasisUrl2TxtBx.AnimateReadOnly = false;
            this.BasisUrl2TxtBx.AsciiOnly = false;
            this.BasisUrl2TxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BasisUrl2TxtBx.BeepOnError = false;
            this.BasisUrl2TxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisUrl2TxtBx.Depth = 0;
            this.BasisUrl2TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BasisUrl2TxtBx.HidePromptOnLeave = false;
            this.BasisUrl2TxtBx.HideSelection = true;
            this.BasisUrl2TxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BasisUrl2TxtBx.LeadingIcon = null;
            this.BasisUrl2TxtBx.Location = new System.Drawing.Point(94, 130);
            this.BasisUrl2TxtBx.Mask = "";
            this.BasisUrl2TxtBx.MaxLength = 32767;
            this.BasisUrl2TxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.BasisUrl2TxtBx.Name = "BasisUrl2TxtBx";
            this.BasisUrl2TxtBx.PasswordChar = '\0';
            this.BasisUrl2TxtBx.PrefixSuffixText = null;
            this.BasisUrl2TxtBx.PromptChar = '_';
            this.BasisUrl2TxtBx.ReadOnly = false;
            this.BasisUrl2TxtBx.RejectInputOnFirstFailure = false;
            this.BasisUrl2TxtBx.ResetOnPrompt = true;
            this.BasisUrl2TxtBx.ResetOnSpace = true;
            this.BasisUrl2TxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasisUrl2TxtBx.SelectedText = "";
            this.BasisUrl2TxtBx.SelectionLength = 0;
            this.BasisUrl2TxtBx.SelectionStart = 0;
            this.BasisUrl2TxtBx.ShortcutsEnabled = true;
            this.BasisUrl2TxtBx.Size = new System.Drawing.Size(356, 48);
            this.BasisUrl2TxtBx.SkipLiterals = true;
            this.BasisUrl2TxtBx.TabIndex = 84;
            this.BasisUrl2TxtBx.TabStop = false;
            this.BasisUrl2TxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BasisUrl2TxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisUrl2TxtBx.TrailingIcon = null;
            this.BasisUrl2TxtBx.UseSystemPasswordChar = false;
            this.BasisUrl2TxtBx.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(8, 130);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 19);
            this.materialLabel3.TabIndex = 85;
            this.materialLabel3.Text = "BasisUrl2:";
            // 
            // BasisUrl1TxtBx
            // 
            this.BasisUrl1TxtBx.AllowPromptAsInput = true;
            this.BasisUrl1TxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasisUrl1TxtBx.AnimateReadOnly = false;
            this.BasisUrl1TxtBx.AsciiOnly = false;
            this.BasisUrl1TxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BasisUrl1TxtBx.BeepOnError = false;
            this.BasisUrl1TxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisUrl1TxtBx.Depth = 0;
            this.BasisUrl1TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BasisUrl1TxtBx.HidePromptOnLeave = false;
            this.BasisUrl1TxtBx.HideSelection = true;
            this.BasisUrl1TxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BasisUrl1TxtBx.LeadingIcon = null;
            this.BasisUrl1TxtBx.Location = new System.Drawing.Point(94, 73);
            this.BasisUrl1TxtBx.Mask = "";
            this.BasisUrl1TxtBx.MaxLength = 32767;
            this.BasisUrl1TxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.BasisUrl1TxtBx.Name = "BasisUrl1TxtBx";
            this.BasisUrl1TxtBx.PasswordChar = '\0';
            this.BasisUrl1TxtBx.PrefixSuffixText = null;
            this.BasisUrl1TxtBx.PromptChar = '_';
            this.BasisUrl1TxtBx.ReadOnly = false;
            this.BasisUrl1TxtBx.RejectInputOnFirstFailure = false;
            this.BasisUrl1TxtBx.ResetOnPrompt = true;
            this.BasisUrl1TxtBx.ResetOnSpace = true;
            this.BasisUrl1TxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasisUrl1TxtBx.SelectedText = "";
            this.BasisUrl1TxtBx.SelectionLength = 0;
            this.BasisUrl1TxtBx.SelectionStart = 0;
            this.BasisUrl1TxtBx.ShortcutsEnabled = true;
            this.BasisUrl1TxtBx.Size = new System.Drawing.Size(356, 48);
            this.BasisUrl1TxtBx.SkipLiterals = true;
            this.BasisUrl1TxtBx.TabIndex = 82;
            this.BasisUrl1TxtBx.TabStop = false;
            this.BasisUrl1TxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BasisUrl1TxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisUrl1TxtBx.TrailingIcon = null;
            this.BasisUrl1TxtBx.UseSystemPasswordChar = false;
            this.BasisUrl1TxtBx.ValidatingType = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(8, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 83;
            this.materialLabel2.Text = "BasisUrl1:";
            // 
            // PasKlantAanBtn
            // 
            this.PasKlantAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasKlantAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasKlantAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasKlantAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasKlantAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasKlantAanBtn.Location = new System.Drawing.Point(339, 195);
            this.PasKlantAanBtn.Name = "PasKlantAanBtn";
            this.PasKlantAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasKlantAanBtn.TabIndex = 81;
            this.PasKlantAanBtn.Text = "KLANT AANPASSEN";
            this.PasKlantAanBtn.UseVisualStyleBackColor = false;
            this.PasKlantAanBtn.Click += new System.EventHandler(this.PasKlantAanBtn_Click);
            // 
            // AddKlantBtn
            // 
            this.AddKlantBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddKlantBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddKlantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddKlantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddKlantBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddKlantBtn.Location = new System.Drawing.Point(221, 195);
            this.AddKlantBtn.Name = "AddKlantBtn";
            this.AddKlantBtn.Size = new System.Drawing.Size(112, 43);
            this.AddKlantBtn.TabIndex = 80;
            this.AddKlantBtn.Text = "KLANT TOEVOEGEN";
            this.AddKlantBtn.UseVisualStyleBackColor = false;
            this.AddKlantBtn.Click += new System.EventHandler(this.AddKlantBtn_Click);
            // 
            // KlantTxtBx
            // 
            this.KlantTxtBx.AllowPromptAsInput = true;
            this.KlantTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KlantTxtBx.AnimateReadOnly = false;
            this.KlantTxtBx.AsciiOnly = false;
            this.KlantTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KlantTxtBx.BeepOnError = false;
            this.KlantTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.KlantTxtBx.Depth = 0;
            this.KlantTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.KlantTxtBx.HidePromptOnLeave = false;
            this.KlantTxtBx.HideSelection = true;
            this.KlantTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.KlantTxtBx.LeadingIcon = null;
            this.KlantTxtBx.Location = new System.Drawing.Point(94, 19);
            this.KlantTxtBx.Mask = "";
            this.KlantTxtBx.MaxLength = 32767;
            this.KlantTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantTxtBx.Name = "KlantTxtBx";
            this.KlantTxtBx.PasswordChar = '\0';
            this.KlantTxtBx.PrefixSuffixText = null;
            this.KlantTxtBx.PromptChar = '_';
            this.KlantTxtBx.ReadOnly = false;
            this.KlantTxtBx.RejectInputOnFirstFailure = false;
            this.KlantTxtBx.ResetOnPrompt = true;
            this.KlantTxtBx.ResetOnSpace = true;
            this.KlantTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KlantTxtBx.SelectedText = "";
            this.KlantTxtBx.SelectionLength = 0;
            this.KlantTxtBx.SelectionStart = 0;
            this.KlantTxtBx.ShortcutsEnabled = true;
            this.KlantTxtBx.Size = new System.Drawing.Size(356, 48);
            this.KlantTxtBx.SkipLiterals = true;
            this.KlantTxtBx.TabIndex = 2;
            this.KlantTxtBx.TabStop = false;
            this.KlantTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KlantTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.KlantTxtBx.TrailingIcon = null;
            this.KlantTxtBx.UseSystemPasswordChar = false;
            this.KlantTxtBx.ValidatingType = null;
            this.KlantTxtBx.TextChanged += new System.EventHandler(this.KlantTxtBx_TextChanged);
            // 
            // DeleteKlantBttn
            // 
            this.DeleteKlantBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteKlantBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteKlantBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteKlantBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteKlantBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteKlantBttn.Location = new System.Drawing.Point(9, 195);
            this.DeleteKlantBttn.Name = "DeleteKlantBttn";
            this.DeleteKlantBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteKlantBttn.TabIndex = 79;
            this.DeleteKlantBttn.Text = "KLANT VERWIJDEREN";
            this.DeleteKlantBttn.UseVisualStyleBackColor = false;
            this.DeleteKlantBttn.Click += new System.EventHandler(this.DeleteKlantBttn_Click);
            // 
            // LblNaam
            // 
            this.LblNaam.AutoSize = true;
            this.LblNaam.Depth = 0;
            this.LblNaam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblNaam.Location = new System.Drawing.Point(7, 19);
            this.LblNaam.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNaam.Name = "LblNaam";
            this.LblNaam.Size = new System.Drawing.Size(48, 19);
            this.LblNaam.TabIndex = 61;
            this.LblNaam.Text = "Naam:";
            // 
            // LblKlant
            // 
            this.LblKlant.AutoSize = true;
            this.LblKlant.Depth = 0;
            this.LblKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblKlant.Location = new System.Drawing.Point(6, 162);
            this.LblKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblKlant.Name = "LblKlant";
            this.LblKlant.Size = new System.Drawing.Size(55, 19);
            this.LblKlant.TabIndex = 59;
            this.LblKlant.Text = "Klanten";
            // 
            // LblUrlsByKlant
            // 
            this.LblUrlsByKlant.AutoSize = true;
            this.LblUrlsByKlant.Depth = 0;
            this.LblUrlsByKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblUrlsByKlant.Location = new System.Drawing.Point(6, 442);
            this.LblUrlsByKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrlsByKlant.Name = "LblUrlsByKlant";
            this.LblUrlsByKlant.Size = new System.Drawing.Size(172, 19);
            this.LblUrlsByKlant.TabIndex = 60;
            this.LblUrlsByKlant.Text = "Urls bij de gekozen klant";
            // 
            // UrlTxtBx
            // 
            this.UrlTxtBx.AllowPromptAsInput = true;
            this.UrlTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTxtBx.AnimateReadOnly = false;
            this.UrlTxtBx.AsciiOnly = false;
            this.UrlTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UrlTxtBx.BeepOnError = false;
            this.UrlTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.UrlTxtBx.Depth = 0;
            this.UrlTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UrlTxtBx.HidePromptOnLeave = false;
            this.UrlTxtBx.HideSelection = true;
            this.UrlTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.UrlTxtBx.LeadingIcon = null;
            this.UrlTxtBx.Location = new System.Drawing.Point(98, 19);
            this.UrlTxtBx.Mask = "";
            this.UrlTxtBx.MaxLength = 32767;
            this.UrlTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.UrlTxtBx.Name = "UrlTxtBx";
            this.UrlTxtBx.PasswordChar = '\0';
            this.UrlTxtBx.PrefixSuffixText = null;
            this.UrlTxtBx.PromptChar = '_';
            this.UrlTxtBx.ReadOnly = false;
            this.UrlTxtBx.RejectInputOnFirstFailure = false;
            this.UrlTxtBx.ResetOnPrompt = true;
            this.UrlTxtBx.ResetOnSpace = true;
            this.UrlTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UrlTxtBx.SelectedText = "";
            this.UrlTxtBx.SelectionLength = 0;
            this.UrlTxtBx.SelectionStart = 0;
            this.UrlTxtBx.ShortcutsEnabled = true;
            this.UrlTxtBx.Size = new System.Drawing.Size(352, 48);
            this.UrlTxtBx.SkipLiterals = true;
            this.UrlTxtBx.TabIndex = 8;
            this.UrlTxtBx.TabStop = false;
            this.UrlTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UrlTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.UrlTxtBx.TrailingIcon = null;
            this.UrlTxtBx.UseSystemPasswordChar = false;
            this.UrlTxtBx.ValidatingType = null;
            this.UrlTxtBx.TextChanged += new System.EventHandler(this.UrlTxtBx_TextChanged);
            // 
            // LblNaamUrl
            // 
            this.LblNaamUrl.AutoSize = true;
            this.LblNaamUrl.Depth = 0;
            this.LblNaamUrl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblNaamUrl.Location = new System.Drawing.Point(7, 19);
            this.LblNaamUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNaamUrl.Name = "LblNaamUrl";
            this.LblNaamUrl.Size = new System.Drawing.Size(48, 19);
            this.LblNaamUrl.TabIndex = 69;
            this.LblNaamUrl.Text = "Naam:";
            // 
            // LblBasisUrl
            // 
            this.LblBasisUrl.AutoSize = true;
            this.LblBasisUrl.Depth = 0;
            this.LblBasisUrl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBasisUrl.Location = new System.Drawing.Point(7, 83);
            this.LblBasisUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBasisUrl.Name = "LblBasisUrl";
            this.LblBasisUrl.Size = new System.Drawing.Size(59, 19);
            this.LblBasisUrl.TabIndex = 71;
            this.LblBasisUrl.Text = "BasisUrl";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.materialCheckbox1);
            this.groupBox2.Controls.Add(this.SoapWebserviceChkBx);
            this.groupBox2.Controls.Add(this.PasUrlAanBtn);
            this.groupBox2.Controls.Add(this.AddUrlByWebserviceBttn);
            this.groupBox2.Controls.Add(this.DeleteUrlBttn);
            this.groupBox2.Controls.Add(this.LblNaamUrl);
            this.groupBox2.Controls.Add(this.UrlTxtBx);
            this.groupBox2.Controls.Add(this.LblBasisUrl);
            this.groupBox2.Location = new System.Drawing.Point(377, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 224);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Url bewerken";
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasUrlAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasUrlAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasUrlAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasUrlAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(337, 178);
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasUrlAanBtn.TabIndex = 83;
            this.PasUrlAanBtn.Text = "URL AANPASSEN";
            this.PasUrlAanBtn.UseVisualStyleBackColor = false;
            // 
            // AddUrlByWebserviceBttn
            // 
            this.AddUrlByWebserviceBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUrlByWebserviceBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddUrlByWebserviceBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUrlByWebserviceBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUrlByWebserviceBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUrlByWebserviceBttn.Location = new System.Drawing.Point(219, 178);
            this.AddUrlByWebserviceBttn.Name = "AddUrlByWebserviceBttn";
            this.AddUrlByWebserviceBttn.Size = new System.Drawing.Size(112, 43);
            this.AddUrlByWebserviceBttn.TabIndex = 82;
            this.AddUrlByWebserviceBttn.Text = "URL TOEVOEGEN";
            this.AddUrlByWebserviceBttn.UseVisualStyleBackColor = false;
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteUrlBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUrlBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUrlBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(6, 178);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteUrlBttn.TabIndex = 81;
            this.DeleteUrlBttn.Text = "URL VERWIJDEREN";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(842, 2);
            this.label3.TabIndex = 80;
            // 
            // ZoekOpKlantNaamTxtBx
            // 
            this.ZoekOpKlantNaamTxtBx.AllowPromptAsInput = true;
            this.ZoekOpKlantNaamTxtBx.AnimateReadOnly = false;
            this.ZoekOpKlantNaamTxtBx.AsciiOnly = false;
            this.ZoekOpKlantNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZoekOpKlantNaamTxtBx.BeepOnError = false;
            this.ZoekOpKlantNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ZoekOpKlantNaamTxtBx.Depth = 0;
            this.ZoekOpKlantNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ZoekOpKlantNaamTxtBx.HidePromptOnLeave = false;
            this.ZoekOpKlantNaamTxtBx.HideSelection = true;
            this.ZoekOpKlantNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ZoekOpKlantNaamTxtBx.LeadingIcon = null;
            this.ZoekOpKlantNaamTxtBx.Location = new System.Drawing.Point(6, 98);
            this.ZoekOpKlantNaamTxtBx.Mask = "";
            this.ZoekOpKlantNaamTxtBx.MaxLength = 32767;
            this.ZoekOpKlantNaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.ZoekOpKlantNaamTxtBx.Name = "ZoekOpKlantNaamTxtBx";
            this.ZoekOpKlantNaamTxtBx.PasswordChar = '\0';
            this.ZoekOpKlantNaamTxtBx.PrefixSuffixText = null;
            this.ZoekOpKlantNaamTxtBx.PromptChar = '_';
            this.ZoekOpKlantNaamTxtBx.ReadOnly = false;
            this.ZoekOpKlantNaamTxtBx.RejectInputOnFirstFailure = false;
            this.ZoekOpKlantNaamTxtBx.ResetOnPrompt = true;
            this.ZoekOpKlantNaamTxtBx.ResetOnSpace = true;
            this.ZoekOpKlantNaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZoekOpKlantNaamTxtBx.SelectedText = "";
            this.ZoekOpKlantNaamTxtBx.SelectionLength = 0;
            this.ZoekOpKlantNaamTxtBx.SelectionStart = 0;
            this.ZoekOpKlantNaamTxtBx.ShortcutsEnabled = true;
            this.ZoekOpKlantNaamTxtBx.Size = new System.Drawing.Size(363, 48);
            this.ZoekOpKlantNaamTxtBx.SkipLiterals = true;
            this.ZoekOpKlantNaamTxtBx.TabIndex = 1;
            this.ZoekOpKlantNaamTxtBx.TabStop = false;
            this.ZoekOpKlantNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ZoekOpKlantNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ZoekOpKlantNaamTxtBx.TrailingIcon = null;
            this.ZoekOpKlantNaamTxtBx.UseSystemPasswordChar = false;
            this.ZoekOpKlantNaamTxtBx.ValidatingType = null;
            this.ZoekOpKlantNaamTxtBx.TextChanged += new System.EventHandler(this.ZoekOpKlantNaamTxtBx_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 19);
            this.materialLabel1.TabIndex = 84;
            this.materialLabel1.Text = "Zoek op klant naam";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 2);
            this.label1.TabIndex = 85;
            // 
            // AllKlantKrLstBx
            // 
            this.AllKlantKrLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllKlantKrLstBx.BackColor = System.Drawing.Color.White;
            this.AllKlantKrLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllKlantKrLstBx.ItemHeight = 20;
            this.AllKlantKrLstBx.Location = new System.Drawing.Point(6, 193);
            this.AllKlantKrLstBx.Name = "AllKlantKrLstBx";
            this.AllKlantKrLstBx.Size = new System.Drawing.Size(363, 244);
            this.AllKlantKrLstBx.TabIndex = 64;
            this.AllKlantKrLstBx.SelectedValueChanged += new System.EventHandler(this.AllKlantKrLstBx_SelectedIndexChanged);
            // 
            // AllWebserviceKrLstBx
            // 
            this.AllWebserviceKrLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllWebserviceKrLstBx.BackColor = System.Drawing.Color.White;
            this.AllWebserviceKrLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllWebserviceKrLstBx.ItemHeight = 20;
            this.AllWebserviceKrLstBx.Location = new System.Drawing.Point(6, 464);
            this.AllWebserviceKrLstBx.Name = "AllWebserviceKrLstBx";
            this.AllWebserviceKrLstBx.Size = new System.Drawing.Size(363, 224);
            this.AllWebserviceKrLstBx.TabIndex = 86;
            // 
            // SoapWebserviceChkBx
            // 
            this.SoapWebserviceChkBx.AutoSize = true;
            this.SoapWebserviceChkBx.Depth = 0;
            this.SoapWebserviceChkBx.Location = new System.Drawing.Point(98, 74);
            this.SoapWebserviceChkBx.Margin = new System.Windows.Forms.Padding(0);
            this.SoapWebserviceChkBx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SoapWebserviceChkBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.SoapWebserviceChkBx.Name = "SoapWebserviceChkBx";
            this.SoapWebserviceChkBx.ReadOnly = false;
            this.SoapWebserviceChkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SoapWebserviceChkBx.Ripple = true;
            this.SoapWebserviceChkBx.Size = new System.Drawing.Size(106, 37);
            this.SoapWebserviceChkBx.TabIndex = 90;
            this.SoapWebserviceChkBx.Text = "BasisUrl 1";
            this.SoapWebserviceChkBx.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(226, 74);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(106, 37);
            this.materialCheckbox1.TabIndex = 91;
            this.materialCheckbox1.Text = "BasisUrl 2";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // AllKlantenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 697);
            this.Controls.Add(this.AllWebserviceKrLstBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ZoekOpKlantNaamTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllKlantKrLstBx);
            this.Controls.Add(this.LblUrlsByKlant);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AllKlantenForm";
            this.Text = "Klanten beheren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox KlantTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblNaam;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private MaterialSkin.Controls.MaterialLabel LblUrlsByKlant;
        private MaterialSkin.Controls.MaterialMaskedTextBox UrlTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblNaamUrl;
        private MaterialSkin.Controls.MaterialLabel LblBasisUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private KrMaterialListBox AllKlantKrLstBx;
        private System.Windows.Forms.Button PasKlantAanBtn;
        private System.Windows.Forms.Button AddKlantBtn;
        private System.Windows.Forms.Button DeleteKlantBttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PasUrlAanBtn;
        private System.Windows.Forms.Button AddUrlByWebserviceBttn;
        private System.Windows.Forms.Button DeleteUrlBttn;
        private MaterialSkin.Controls.MaterialMaskedTextBox ZoekOpKlantNaamTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialMaskedTextBox BasisUrl2TxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox BasisUrl1TxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private KrMaterialListBox AllWebserviceKrLstBx;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox SoapWebserviceChkBx;
    }
}