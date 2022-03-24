
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
            this.PasKlantAanBtn = new System.Windows.Forms.Button();
            this.AddKlantBtn = new System.Windows.Forms.Button();
            this.KlantTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.DeleteKlantBttn = new System.Windows.Forms.Button();
            this.LblNaam = new MaterialSkin.Controls.MaterialLabel();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrlsByKlant = new MaterialSkin.Controls.MaterialLabel();
            this.SecurityIdTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblSecurityID = new MaterialSkin.Controls.MaterialLabel();
            this.UrlTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblNaamUrl = new MaterialSkin.Controls.MaterialLabel();
            this.LblWebservice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PasUrlAanBtn = new System.Windows.Forms.Button();
            this.AddUrlByWebserviceBttn = new System.Windows.Forms.Button();
            this.KlantKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.WebserviceKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.AllUrlsKrMaterialLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.AllKlantKrMaterialLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PasKlantAanBtn);
            this.groupBox1.Controls.Add(this.AddKlantBtn);
            this.groupBox1.Controls.Add(this.KlantTxtBx);
            this.groupBox1.Controls.Add(this.DeleteKlantBttn);
            this.groupBox1.Controls.Add(this.LblNaam);
            this.groupBox1.Location = new System.Drawing.Point(514, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 198);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klant bewerken";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PasKlantAanBtn
            // 
            this.PasKlantAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasKlantAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasKlantAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasKlantAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasKlantAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasKlantAanBtn.Location = new System.Drawing.Point(353, 149);
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
            this.AddKlantBtn.Location = new System.Drawing.Point(235, 149);
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
            this.KlantTxtBx.Location = new System.Drawing.Point(61, 19);
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
            this.KlantTxtBx.Size = new System.Drawing.Size(405, 48);
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
            this.DeleteKlantBttn.Location = new System.Drawing.Point(9, 149);
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
            this.LblKlant.Location = new System.Drawing.Point(4, 152);
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
            this.LblUrlsByKlant.Location = new System.Drawing.Point(6, 386);
            this.LblUrlsByKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrlsByKlant.Name = "LblUrlsByKlant";
            this.LblUrlsByKlant.Size = new System.Drawing.Size(172, 19);
            this.LblUrlsByKlant.TabIndex = 60;
            this.LblUrlsByKlant.Text = "Urls bij de gekozen klant";
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.AllowPromptAsInput = true;
            this.SecurityIdTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityIdTxtBx.AnimateReadOnly = false;
            this.SecurityIdTxtBx.AsciiOnly = false;
            this.SecurityIdTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SecurityIdTxtBx.BeepOnError = false;
            this.SecurityIdTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.SecurityIdTxtBx.Depth = 0;
            this.SecurityIdTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SecurityIdTxtBx.HidePromptOnLeave = false;
            this.SecurityIdTxtBx.HideSelection = true;
            this.SecurityIdTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.SecurityIdTxtBx.LeadingIcon = null;
            this.SecurityIdTxtBx.Location = new System.Drawing.Point(98, 19);
            this.SecurityIdTxtBx.Mask = "";
            this.SecurityIdTxtBx.MaxLength = 32767;
            this.SecurityIdTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.SecurityIdTxtBx.Name = "SecurityIdTxtBx";
            this.SecurityIdTxtBx.PasswordChar = '\0';
            this.SecurityIdTxtBx.PrefixSuffixText = null;
            this.SecurityIdTxtBx.PromptChar = '_';
            this.SecurityIdTxtBx.ReadOnly = false;
            this.SecurityIdTxtBx.RejectInputOnFirstFailure = false;
            this.SecurityIdTxtBx.ResetOnPrompt = true;
            this.SecurityIdTxtBx.ResetOnSpace = true;
            this.SecurityIdTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecurityIdTxtBx.SelectedText = "";
            this.SecurityIdTxtBx.SelectionLength = 0;
            this.SecurityIdTxtBx.SelectionStart = 0;
            this.SecurityIdTxtBx.ShortcutsEnabled = true;
            this.SecurityIdTxtBx.Size = new System.Drawing.Size(368, 48);
            this.SecurityIdTxtBx.SkipLiterals = true;
            this.SecurityIdTxtBx.TabIndex = 7;
            this.SecurityIdTxtBx.TabStop = false;
            this.SecurityIdTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecurityIdTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.SecurityIdTxtBx.TrailingIcon = null;
            this.SecurityIdTxtBx.UseSystemPasswordChar = false;
            this.SecurityIdTxtBx.ValidatingType = null;
            this.SecurityIdTxtBx.TextChanged += new System.EventHandler(this.SecurityIdTxtBx_TextChanged);
            // 
            // LblSecurityID
            // 
            this.LblSecurityID.AutoSize = true;
            this.LblSecurityID.Depth = 0;
            this.LblSecurityID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSecurityID.Location = new System.Drawing.Point(7, 19);
            this.LblSecurityID.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSecurityID.Name = "LblSecurityID";
            this.LblSecurityID.Size = new System.Drawing.Size(77, 19);
            this.LblSecurityID.TabIndex = 67;
            this.LblSecurityID.Text = "SecurityID:";
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
            this.UrlTxtBx.Location = new System.Drawing.Point(98, 73);
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
            this.UrlTxtBx.Size = new System.Drawing.Size(368, 48);
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
            this.LblNaamUrl.Location = new System.Drawing.Point(7, 73);
            this.LblNaamUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNaamUrl.Name = "LblNaamUrl";
            this.LblNaamUrl.Size = new System.Drawing.Size(48, 19);
            this.LblNaamUrl.TabIndex = 69;
            this.LblNaamUrl.Text = "Naam:";
            // 
            // LblWebservice
            // 
            this.LblWebservice.AutoSize = true;
            this.LblWebservice.Depth = 0;
            this.LblWebservice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblWebservice.Location = new System.Drawing.Point(7, 127);
            this.LblWebservice.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblWebservice.Name = "LblWebservice";
            this.LblWebservice.Size = new System.Drawing.Size(85, 19);
            this.LblWebservice.TabIndex = 71;
            this.LblWebservice.Text = "Webservice:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(7, 181);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(38, 19);
            this.materialLabel4.TabIndex = 73;
            this.materialLabel4.Text = "Klant";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PasUrlAanBtn);
            this.groupBox2.Controls.Add(this.AddUrlByWebserviceBttn);
            this.groupBox2.Controls.Add(this.KlantKrMaterialCmbx);
            this.groupBox2.Controls.Add(this.DeleteUrlBttn);
            this.groupBox2.Controls.Add(this.WebserviceKrMaterialCmbx);
            this.groupBox2.Controls.Add(this.SecurityIdTxtBx);
            this.groupBox2.Controls.Add(this.LblSecurityID);
            this.groupBox2.Controls.Add(this.LblNaamUrl);
            this.groupBox2.Controls.Add(this.UrlTxtBx);
            this.groupBox2.Controls.Add(this.LblWebservice);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Location = new System.Drawing.Point(518, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 304);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Url bewerken";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasUrlAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasUrlAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasUrlAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasUrlAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(354, 258);
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
            this.AddUrlByWebserviceBttn.Location = new System.Drawing.Point(236, 258);
            this.AddUrlByWebserviceBttn.Name = "AddUrlByWebserviceBttn";
            this.AddUrlByWebserviceBttn.Size = new System.Drawing.Size(112, 43);
            this.AddUrlByWebserviceBttn.TabIndex = 82;
            this.AddUrlByWebserviceBttn.Text = "URL TOEVOEGEN";
            this.AddUrlByWebserviceBttn.UseVisualStyleBackColor = false;
            // 
            // KlantKrMaterialCmbx
            // 
            this.KlantKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KlantKrMaterialCmbx.AutoResize = false;
            this.KlantKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.KlantKrMaterialCmbx.Depth = 0;
            this.KlantKrMaterialCmbx.DisplayMember = "Name";
            this.KlantKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.KlantKrMaterialCmbx.DropDownHeight = 174;
            this.KlantKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlantKrMaterialCmbx.DropDownWidth = 121;
            this.KlantKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.KlantKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KlantKrMaterialCmbx.FormattingEnabled = true;
            this.KlantKrMaterialCmbx.IntegralHeight = false;
            this.KlantKrMaterialCmbx.ItemHeight = 43;
            this.KlantKrMaterialCmbx.Location = new System.Drawing.Point(98, 182);
            this.KlantKrMaterialCmbx.MaxDropDownItems = 4;
            this.KlantKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantKrMaterialCmbx.Name = "KlantKrMaterialCmbx";
            this.KlantKrMaterialCmbx.Size = new System.Drawing.Size(368, 49);
            this.KlantKrMaterialCmbx.StartIndex = 0;
            this.KlantKrMaterialCmbx.TabIndex = 75;
            this.KlantKrMaterialCmbx.ValueMember = "Id";
            this.KlantKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.KlantKrMaterialCmbx_SelectedIndexChanged);
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteUrlBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUrlBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUrlBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(6, 258);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteUrlBttn.TabIndex = 81;
            this.DeleteUrlBttn.Text = "URL VERWIJDEREN";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            // 
            // WebserviceKrMaterialCmbx
            // 
            this.WebserviceKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebserviceKrMaterialCmbx.AutoResize = false;
            this.WebserviceKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WebserviceKrMaterialCmbx.Depth = 0;
            this.WebserviceKrMaterialCmbx.DisplayMember = "Name";
            this.WebserviceKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WebserviceKrMaterialCmbx.DropDownHeight = 174;
            this.WebserviceKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebserviceKrMaterialCmbx.DropDownWidth = 121;
            this.WebserviceKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WebserviceKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WebserviceKrMaterialCmbx.FormattingEnabled = true;
            this.WebserviceKrMaterialCmbx.IntegralHeight = false;
            this.WebserviceKrMaterialCmbx.ItemHeight = 43;
            this.WebserviceKrMaterialCmbx.Location = new System.Drawing.Point(98, 127);
            this.WebserviceKrMaterialCmbx.MaxDropDownItems = 4;
            this.WebserviceKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebserviceKrMaterialCmbx.Name = "WebserviceKrMaterialCmbx";
            this.WebserviceKrMaterialCmbx.Size = new System.Drawing.Size(368, 49);
            this.WebserviceKrMaterialCmbx.StartIndex = 0;
            this.WebserviceKrMaterialCmbx.TabIndex = 74;
            this.WebserviceKrMaterialCmbx.ValueMember = "Id";
            this.WebserviceKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.WebserviceKrMaterialCmbx_SelectedIndexChanged);
            // 
            // AllUrlsKrMaterialLstBx
            // 
            this.AllUrlsKrMaterialLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllUrlsKrMaterialLstBx.BackColor = System.Drawing.Color.White;
            this.AllUrlsKrMaterialLstBx.BorderColor = System.Drawing.Color.LightGray;
            this.AllUrlsKrMaterialLstBx.Depth = 0;
            this.AllUrlsKrMaterialLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllUrlsKrMaterialLstBx.Location = new System.Drawing.Point(7, 408);
            this.AllUrlsKrMaterialLstBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllUrlsKrMaterialLstBx.Name = "AllUrlsKrMaterialLstBx";
            this.AllUrlsKrMaterialLstBx.SelectedIndex = -1;
            this.AllUrlsKrMaterialLstBx.SelectedItem = null;
            this.AllUrlsKrMaterialLstBx.Size = new System.Drawing.Size(504, 304);
            this.AllUrlsKrMaterialLstBx.TabIndex = 65;
            this.AllUrlsKrMaterialLstBx.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.AllUrlsKrMaterialLstBx_SelectedIndexChanged);
            // 
            // AllKlantKrMaterialLstBx
            // 
            this.AllKlantKrMaterialLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllKlantKrMaterialLstBx.BackColor = System.Drawing.Color.White;
            this.AllKlantKrMaterialLstBx.BorderColor = System.Drawing.Color.LightGray;
            this.AllKlantKrMaterialLstBx.Depth = 0;
            this.AllKlantKrMaterialLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllKlantKrMaterialLstBx.Location = new System.Drawing.Point(3, 174);
            this.AllKlantKrMaterialLstBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllKlantKrMaterialLstBx.Name = "AllKlantKrMaterialLstBx";
            this.AllKlantKrMaterialLstBx.SelectedIndex = -1;
            this.AllKlantKrMaterialLstBx.SelectedItem = null;
            this.AllKlantKrMaterialLstBx.Size = new System.Drawing.Size(504, 199);
            this.AllKlantKrMaterialLstBx.TabIndex = 64;
            this.AllKlantKrMaterialLstBx.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.AllKlantKrMaterialLstBx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(3, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(983, 2);
            this.label3.TabIndex = 80;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AllKlantenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 715);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllUrlsKrMaterialLstBx);
            this.Controls.Add(this.AllKlantKrMaterialLstBx);
            this.Controls.Add(this.LblUrlsByKlant);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(854, 605);
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
        private MaterialSkin.Controls.MaterialMaskedTextBox SecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblSecurityID;
        private MaterialSkin.Controls.MaterialMaskedTextBox UrlTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblNaamUrl;
        private MaterialSkin.Controls.MaterialLabel LblWebservice;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private KrMaterialCombobox KlantKrMaterialCmbx;
        private KrMaterialCombobox WebserviceKrMaterialCmbx;
        private KrMaterialListBox AllKlantKrMaterialLstBx;
        private KrMaterialListBox AllUrlsKrMaterialLstBx;
        private System.Windows.Forms.Button PasKlantAanBtn;
        private System.Windows.Forms.Button AddKlantBtn;
        private System.Windows.Forms.Button DeleteKlantBttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PasUrlAanBtn;
        private System.Windows.Forms.Button AddUrlByWebserviceBttn;
        private System.Windows.Forms.Button DeleteUrlBttn;
    }
}