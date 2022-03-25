
namespace WindowsFormsAppTest
{
    partial class AllWebserviceForm
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
            this.PasWebserviceAanBtn = new System.Windows.Forms.Button();
            this.AddWebserviceBtn = new System.Windows.Forms.Button();
            this.DeleteWebserviceBttn = new System.Windows.Forms.Button();
            this.WebserviceTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblNaam = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SecurityIdTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.UrlTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PasUrlAanBtn = new System.Windows.Forms.Button();
            this.KlantKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.AddUrlByWebserviceBttn = new System.Windows.Forms.Button();
            this.WebserviceKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.AllUrlsKrMaterialLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.AllWebserviceKrMaterialLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.ZoekOpWebserviceNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PasWebserviceAanBtn);
            this.groupBox1.Controls.Add(this.AddWebserviceBtn);
            this.groupBox1.Controls.Add(this.DeleteWebserviceBttn);
            this.groupBox1.Controls.Add(this.WebserviceTxtBx);
            this.groupBox1.Controls.Add(this.LblNaam);
            this.groupBox1.Location = new System.Drawing.Point(459, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 198);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Webservice bewerken";
            // 
            // PasWebserviceAanBtn
            // 
            this.PasWebserviceAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasWebserviceAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasWebserviceAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasWebserviceAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasWebserviceAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasWebserviceAanBtn.Location = new System.Drawing.Point(354, 149);
            this.PasWebserviceAanBtn.Name = "PasWebserviceAanBtn";
            this.PasWebserviceAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasWebserviceAanBtn.TabIndex = 78;
            this.PasWebserviceAanBtn.Text = "WEBSERVICE AANPASSEN";
            this.PasWebserviceAanBtn.UseVisualStyleBackColor = false;
            this.PasWebserviceAanBtn.Click += new System.EventHandler(this.PasWebserviceAanBtn_Click);
            // 
            // AddWebserviceBtn
            // 
            this.AddWebserviceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddWebserviceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddWebserviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWebserviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWebserviceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddWebserviceBtn.Location = new System.Drawing.Point(236, 149);
            this.AddWebserviceBtn.Name = "AddWebserviceBtn";
            this.AddWebserviceBtn.Size = new System.Drawing.Size(112, 43);
            this.AddWebserviceBtn.TabIndex = 77;
            this.AddWebserviceBtn.Text = "WEBSERVICE TOEVOEGEN";
            this.AddWebserviceBtn.UseVisualStyleBackColor = false;
            this.AddWebserviceBtn.Click += new System.EventHandler(this.AddWebserviceBtn_Click);
            // 
            // DeleteWebserviceBttn
            // 
            this.DeleteWebserviceBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteWebserviceBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteWebserviceBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWebserviceBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWebserviceBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteWebserviceBttn.Location = new System.Drawing.Point(10, 149);
            this.DeleteWebserviceBttn.Name = "DeleteWebserviceBttn";
            this.DeleteWebserviceBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteWebserviceBttn.TabIndex = 76;
            this.DeleteWebserviceBttn.Text = "WEBSERVICE VERWIJDEREN";
            this.DeleteWebserviceBttn.UseVisualStyleBackColor = false;
            this.DeleteWebserviceBttn.Click += new System.EventHandler(this.DeleteWebserviceBttn_Click);
            // 
            // WebserviceTxtBx
            // 
            this.WebserviceTxtBx.AllowPromptAsInput = true;
            this.WebserviceTxtBx.AnimateReadOnly = false;
            this.WebserviceTxtBx.AsciiOnly = false;
            this.WebserviceTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WebserviceTxtBx.BeepOnError = false;
            this.WebserviceTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.WebserviceTxtBx.Depth = 0;
            this.WebserviceTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WebserviceTxtBx.HidePromptOnLeave = false;
            this.WebserviceTxtBx.HideSelection = true;
            this.WebserviceTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.WebserviceTxtBx.LeadingIcon = null;
            this.WebserviceTxtBx.Location = new System.Drawing.Point(61, 19);
            this.WebserviceTxtBx.Mask = "";
            this.WebserviceTxtBx.MaxLength = 32767;
            this.WebserviceTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebserviceTxtBx.Name = "WebserviceTxtBx";
            this.WebserviceTxtBx.PasswordChar = '\0';
            this.WebserviceTxtBx.PrefixSuffixText = null;
            this.WebserviceTxtBx.PromptChar = '_';
            this.WebserviceTxtBx.ReadOnly = false;
            this.WebserviceTxtBx.RejectInputOnFirstFailure = false;
            this.WebserviceTxtBx.ResetOnPrompt = true;
            this.WebserviceTxtBx.ResetOnSpace = true;
            this.WebserviceTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WebserviceTxtBx.SelectedText = "";
            this.WebserviceTxtBx.SelectionLength = 0;
            this.WebserviceTxtBx.SelectionStart = 0;
            this.WebserviceTxtBx.ShortcutsEnabled = true;
            this.WebserviceTxtBx.Size = new System.Drawing.Size(405, 48);
            this.WebserviceTxtBx.SkipLiterals = true;
            this.WebserviceTxtBx.TabIndex = 2;
            this.WebserviceTxtBx.TabStop = false;
            this.WebserviceTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WebserviceTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.WebserviceTxtBx.TrailingIcon = null;
            this.WebserviceTxtBx.UseSystemPasswordChar = false;
            this.WebserviceTxtBx.ValidatingType = null;
            this.WebserviceTxtBx.TextChanged += new System.EventHandler(this.WebserviceTxtBx_TextChanged);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 180);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 66;
            this.materialLabel1.Text = "Webservice";
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.AllowPromptAsInput = true;
            this.SecurityIdTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(7, 19);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 67;
            this.materialLabel2.Text = "SecurityID:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(7, 73);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(48, 19);
            this.materialLabel3.TabIndex = 69;
            this.materialLabel3.Text = "Naam:";
            // 
            // UrlTxtBx
            // 
            this.UrlTxtBx.AllowPromptAsInput = true;
            this.UrlTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(7, 127);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 19);
            this.materialLabel4.TabIndex = 71;
            this.materialLabel4.Text = "Webservice:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(7, 181);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 73;
            this.materialLabel5.Text = "Klant";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PasUrlAanBtn);
            this.groupBox2.Controls.Add(this.KlantKrMaterialCmbx);
            this.groupBox2.Controls.Add(this.AddUrlByWebserviceBttn);
            this.groupBox2.Controls.Add(this.WebserviceKrMaterialCmbx);
            this.groupBox2.Controls.Add(this.DeleteUrlBttn);
            this.groupBox2.Controls.Add(this.SecurityIdTxtBx);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.UrlTxtBx);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Location = new System.Drawing.Point(459, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 344);
            this.groupBox2.TabIndex = 76;
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
            this.PasUrlAanBtn.Location = new System.Drawing.Point(354, 295);
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasUrlAanBtn.TabIndex = 64;
            this.PasUrlAanBtn.Text = "URL AANPASSEN";
            this.PasUrlAanBtn.UseVisualStyleBackColor = false;
            this.PasUrlAanBtn.Click += new System.EventHandler(this.PasUrlAanBtn_Click);
            // 
            // KlantKrMaterialCmbx
            // 
            this.KlantKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // AddUrlByWebserviceBttn
            // 
            this.AddUrlByWebserviceBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUrlByWebserviceBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddUrlByWebserviceBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUrlByWebserviceBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUrlByWebserviceBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUrlByWebserviceBttn.Location = new System.Drawing.Point(236, 295);
            this.AddUrlByWebserviceBttn.Name = "AddUrlByWebserviceBttn";
            this.AddUrlByWebserviceBttn.Size = new System.Drawing.Size(112, 43);
            this.AddUrlByWebserviceBttn.TabIndex = 63;
            this.AddUrlByWebserviceBttn.Text = "URL TOEVOEGEN";
            this.AddUrlByWebserviceBttn.UseVisualStyleBackColor = false;
            this.AddUrlByWebserviceBttn.Click += new System.EventHandler(this.AddUrlByWebserviceBttn_Click);
            // 
            // WebserviceKrMaterialCmbx
            // 
            this.WebserviceKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteUrlBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUrlBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUrlBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(10, 295);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteUrlBttn.TabIndex = 62;
            this.DeleteUrlBttn.Text = "URL VERWIJDEREN";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            this.DeleteUrlBttn.Click += new System.EventHandler(this.DeleteUrlBttn_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(6, 409);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(194, 19);
            this.materialLabel6.TabIndex = 78;
            this.materialLabel6.Text = "Urls bij gekozen webservice";
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
            this.AllUrlsKrMaterialLstBx.Location = new System.Drawing.Point(7, 431);
            this.AllUrlsKrMaterialLstBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllUrlsKrMaterialLstBx.Name = "AllUrlsKrMaterialLstBx";
            this.AllUrlsKrMaterialLstBx.SelectedIndex = -1;
            this.AllUrlsKrMaterialLstBx.SelectedItem = null;
            this.AllUrlsKrMaterialLstBx.Size = new System.Drawing.Size(446, 344);
            this.AllUrlsKrMaterialLstBx.TabIndex = 77;
            this.AllUrlsKrMaterialLstBx.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.AllUrlsKrMaterialLstBx_SelectedIndexChanged);
            // 
            // AllWebserviceKrMaterialLstBx
            // 
            this.AllWebserviceKrMaterialLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllWebserviceKrMaterialLstBx.BackColor = System.Drawing.Color.White;
            this.AllWebserviceKrMaterialLstBx.BorderColor = System.Drawing.Color.LightGray;
            this.AllWebserviceKrMaterialLstBx.Depth = 0;
            this.AllWebserviceKrMaterialLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllWebserviceKrMaterialLstBx.Location = new System.Drawing.Point(6, 203);
            this.AllWebserviceKrMaterialLstBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllWebserviceKrMaterialLstBx.Name = "AllWebserviceKrMaterialLstBx";
            this.AllWebserviceKrMaterialLstBx.SelectedIndex = -1;
            this.AllWebserviceKrMaterialLstBx.SelectedItem = null;
            this.AllWebserviceKrMaterialLstBx.ShowScrollBar = true;
            this.AllWebserviceKrMaterialLstBx.Size = new System.Drawing.Size(446, 199);
            this.AllWebserviceKrMaterialLstBx.TabIndex = 66;
            this.AllWebserviceKrMaterialLstBx.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.AllWebserviceKrMaterialLstBx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(925, 2);
            this.label3.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 2);
            this.label1.TabIndex = 88;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(6, 83);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(185, 19);
            this.materialLabel7.TabIndex = 87;
            this.materialLabel7.Text = "Zoek op webservice naam";
            // 
            // ZoekOpWebserviceNaamTxtBx
            // 
            this.ZoekOpWebserviceNaamTxtBx.AllowPromptAsInput = true;
            this.ZoekOpWebserviceNaamTxtBx.AnimateReadOnly = false;
            this.ZoekOpWebserviceNaamTxtBx.AsciiOnly = false;
            this.ZoekOpWebserviceNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZoekOpWebserviceNaamTxtBx.BeepOnError = false;
            this.ZoekOpWebserviceNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ZoekOpWebserviceNaamTxtBx.Depth = 0;
            this.ZoekOpWebserviceNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ZoekOpWebserviceNaamTxtBx.HidePromptOnLeave = false;
            this.ZoekOpWebserviceNaamTxtBx.HideSelection = true;
            this.ZoekOpWebserviceNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ZoekOpWebserviceNaamTxtBx.LeadingIcon = null;
            this.ZoekOpWebserviceNaamTxtBx.Location = new System.Drawing.Point(6, 108);
            this.ZoekOpWebserviceNaamTxtBx.Mask = "";
            this.ZoekOpWebserviceNaamTxtBx.MaxLength = 32767;
            this.ZoekOpWebserviceNaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.ZoekOpWebserviceNaamTxtBx.Name = "ZoekOpWebserviceNaamTxtBx";
            this.ZoekOpWebserviceNaamTxtBx.PasswordChar = '\0';
            this.ZoekOpWebserviceNaamTxtBx.PrefixSuffixText = null;
            this.ZoekOpWebserviceNaamTxtBx.PromptChar = '_';
            this.ZoekOpWebserviceNaamTxtBx.ReadOnly = false;
            this.ZoekOpWebserviceNaamTxtBx.RejectInputOnFirstFailure = false;
            this.ZoekOpWebserviceNaamTxtBx.ResetOnPrompt = true;
            this.ZoekOpWebserviceNaamTxtBx.ResetOnSpace = true;
            this.ZoekOpWebserviceNaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZoekOpWebserviceNaamTxtBx.SelectedText = "";
            this.ZoekOpWebserviceNaamTxtBx.SelectionLength = 0;
            this.ZoekOpWebserviceNaamTxtBx.SelectionStart = 0;
            this.ZoekOpWebserviceNaamTxtBx.ShortcutsEnabled = true;
            this.ZoekOpWebserviceNaamTxtBx.Size = new System.Drawing.Size(363, 48);
            this.ZoekOpWebserviceNaamTxtBx.SkipLiterals = true;
            this.ZoekOpWebserviceNaamTxtBx.TabIndex = 86;
            this.ZoekOpWebserviceNaamTxtBx.TabStop = false;
            this.ZoekOpWebserviceNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ZoekOpWebserviceNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ZoekOpWebserviceNaamTxtBx.TrailingIcon = null;
            this.ZoekOpWebserviceNaamTxtBx.UseSystemPasswordChar = false;
            this.ZoekOpWebserviceNaamTxtBx.ValidatingType = null;
            this.ZoekOpWebserviceNaamTxtBx.TextChanged += new System.EventHandler(this.ZoekOpWebserviceNaamTxtBx_TextChanged);
            // 
            // AllWebserviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 783);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.ZoekOpWebserviceNaamTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.AllUrlsKrMaterialLstBx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.AllWebserviceKrMaterialLstBx);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(906, 632);
            this.Name = "AllWebserviceForm";
            this.Text = "Webservices beheren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KrMaterialListBox AllWebserviceKrMaterialLstBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox WebserviceTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblNaam;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private KrMaterialCombobox KlantKrMaterialCmbx;
        private KrMaterialCombobox WebserviceKrMaterialCmbx;
        private MaterialSkin.Controls.MaterialMaskedTextBox SecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox UrlTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private KrMaterialListBox AllUrlsKrMaterialLstBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button PasUrlAanBtn;
        private System.Windows.Forms.Button AddUrlByWebserviceBttn;
        private System.Windows.Forms.Button DeleteUrlBttn;
        private System.Windows.Forms.Button PasWebserviceAanBtn;
        private System.Windows.Forms.Button AddWebserviceBtn;
        private System.Windows.Forms.Button DeleteWebserviceBttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMaskedTextBox ZoekOpWebserviceNaamTxtBx;
    }
}