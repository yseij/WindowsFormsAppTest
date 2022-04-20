
namespace WindowsFormsAppTest
{
    partial class AllUrlsForm
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
            this.LblBewerken = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SecurityIdTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.UrlTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblUrl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.AddUrlBtn = new System.Windows.Forms.Button();
            this.PasUrlAanBtn = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.HttpKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.KlantKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.WebserviceKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.AllUrlsKrLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.ZoekOpUrlNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // LblBewerken
            // 
            this.LblBewerken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBewerken.AutoSize = true;
            this.LblBewerken.Depth = 0;
            this.LblBewerken.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBewerken.Location = new System.Drawing.Point(491, 178);
            this.LblBewerken.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBewerken.Name = "LblBewerken";
            this.LblBewerken.Size = new System.Drawing.Size(91, 19);
            this.LblBewerken.TabIndex = 40;
            this.LblBewerken.Text = "Url bewerken";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(495, 207);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "SecurityID:";
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityIdTxtBx.AnimateReadOnly = false;
            this.SecurityIdTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecurityIdTxtBx.Depth = 0;
            this.SecurityIdTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SecurityIdTxtBx.LeadingIcon = null;
            this.SecurityIdTxtBx.Location = new System.Drawing.Point(591, 204);
            this.SecurityIdTxtBx.MaxLength = 50;
            this.SecurityIdTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.SecurityIdTxtBx.Multiline = false;
            this.SecurityIdTxtBx.Name = "SecurityIdTxtBx";
            this.SecurityIdTxtBx.Size = new System.Drawing.Size(390, 50);
            this.SecurityIdTxtBx.TabIndex = 43;
            this.SecurityIdTxtBx.Text = "";
            this.SecurityIdTxtBx.TrailingIcon = null;
            this.SecurityIdTxtBx.TextChanged += new System.EventHandler(this.SecurityIdTxtBx_TextChanged);
            // 
            // UrlTxtBx
            // 
            this.UrlTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTxtBx.AnimateReadOnly = false;
            this.UrlTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrlTxtBx.Depth = 0;
            this.UrlTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UrlTxtBx.LeadingIcon = null;
            this.UrlTxtBx.Location = new System.Drawing.Point(591, 260);
            this.UrlTxtBx.MaxLength = 50;
            this.UrlTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.UrlTxtBx.Multiline = false;
            this.UrlTxtBx.Name = "UrlTxtBx";
            this.UrlTxtBx.Size = new System.Drawing.Size(390, 50);
            this.UrlTxtBx.TabIndex = 45;
            this.UrlTxtBx.Text = "";
            this.UrlTxtBx.TrailingIcon = null;
            this.UrlTxtBx.TextChanged += new System.EventHandler(this.UrlTxtBx_TextChanged);
            // 
            // LblUrl
            // 
            this.LblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUrl.AutoSize = true;
            this.LblUrl.Depth = 0;
            this.LblUrl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblUrl.Location = new System.Drawing.Point(495, 266);
            this.LblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(24, 19);
            this.LblUrl.TabIndex = 44;
            this.LblUrl.Text = "Url:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(495, 374);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 48;
            this.materialLabel3.Text = "Webservice:";
            // 
            // LblKlant
            // 
            this.LblKlant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblKlant.AutoSize = true;
            this.LblKlant.Depth = 0;
            this.LblKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblKlant.Location = new System.Drawing.Point(495, 429);
            this.LblKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblKlant.Name = "LblKlant";
            this.LblKlant.Size = new System.Drawing.Size(38, 19);
            this.LblKlant.TabIndex = 49;
            this.LblKlant.Text = "Klant";
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteUrlBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUrlBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUrlBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(493, 481);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteUrlBttn.TabIndex = 57;
            this.DeleteUrlBttn.Text = "URL VERWIJDEREN";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            this.DeleteUrlBttn.Click += new System.EventHandler(this.DeleteUrlBttn_Click);
            // 
            // AddUrlBtn
            // 
            this.AddUrlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUrlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddUrlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUrlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUrlBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUrlBtn.Location = new System.Drawing.Point(751, 481);
            this.AddUrlBtn.Name = "AddUrlBtn";
            this.AddUrlBtn.Size = new System.Drawing.Size(112, 43);
            this.AddUrlBtn.TabIndex = 58;
            this.AddUrlBtn.Text = "URL TOEVOEGEN";
            this.AddUrlBtn.UseVisualStyleBackColor = false;
            this.AddUrlBtn.Click += new System.EventHandler(this.AddUrlBtn_Click);
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasUrlAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasUrlAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasUrlAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasUrlAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(869, 480);
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasUrlAanBtn.TabIndex = 59;
            this.PasUrlAanBtn.Text = "URL AANPASSEN";
            this.PasUrlAanBtn.UseVisualStyleBackColor = false;
            this.PasUrlAanBtn.Click += new System.EventHandler(this.PasUrlAanBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(495, 317);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(35, 19);
            this.materialLabel2.TabIndex = 60;
            this.materialLabel2.Text = "Http:";
            // 
            // HttpKrMaterialCmbx
            // 
            this.HttpKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.HttpKrMaterialCmbx.Location = new System.Drawing.Point(591, 316);
            this.HttpKrMaterialCmbx.MaxDropDownItems = 4;
            this.HttpKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.HttpKrMaterialCmbx.Name = "HttpKrMaterialCmbx";
            this.HttpKrMaterialCmbx.Size = new System.Drawing.Size(390, 49);
            this.HttpKrMaterialCmbx.StartIndex = 0;
            this.HttpKrMaterialCmbx.TabIndex = 61;
            this.HttpKrMaterialCmbx.ValueMember = "Id";
            this.HttpKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.HttpKrMaterialCmbx_SelectedIndexChanged);
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
            this.KlantKrMaterialCmbx.Location = new System.Drawing.Point(591, 429);
            this.KlantKrMaterialCmbx.MaxDropDownItems = 4;
            this.KlantKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantKrMaterialCmbx.Name = "KlantKrMaterialCmbx";
            this.KlantKrMaterialCmbx.Size = new System.Drawing.Size(390, 49);
            this.KlantKrMaterialCmbx.StartIndex = 0;
            this.KlantKrMaterialCmbx.TabIndex = 56;
            this.KlantKrMaterialCmbx.ValueMember = "Id";
            this.KlantKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.KlantKrMaterialCmbx_SelectedIndexChanged);
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
            this.WebserviceKrMaterialCmbx.Location = new System.Drawing.Point(591, 373);
            this.WebserviceKrMaterialCmbx.MaxDropDownItems = 4;
            this.WebserviceKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebserviceKrMaterialCmbx.Name = "WebserviceKrMaterialCmbx";
            this.WebserviceKrMaterialCmbx.Size = new System.Drawing.Size(390, 49);
            this.WebserviceKrMaterialCmbx.StartIndex = 0;
            this.WebserviceKrMaterialCmbx.TabIndex = 55;
            this.WebserviceKrMaterialCmbx.ValueMember = "Id";
            this.WebserviceKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.WebserviceKrMaterialCmbx_SelectedIndexChanged);
            // 
            // AllUrlsKrLstBx
            // 
            this.AllUrlsKrLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllUrlsKrLstBx.BackColor = System.Drawing.Color.White;
            this.AllUrlsKrLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllUrlsKrLstBx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AllUrlsKrLstBx.ItemHeight = 20;
            this.AllUrlsKrLstBx.Location = new System.Drawing.Point(6, 179);
            this.AllUrlsKrLstBx.Name = "AllUrlsKrLstBx";
            this.AllUrlsKrLstBx.Size = new System.Drawing.Size(479, 344);
            this.AllUrlsKrLstBx.TabIndex = 54;
            this.AllUrlsKrLstBx.SelectedIndexChanged += new System.EventHandler(this.AllUrlsKrLstBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 2);
            this.label1.TabIndex = 86;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(6, 74);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(125, 19);
            this.materialLabel7.TabIndex = 89;
            this.materialLabel7.Text = "Zoek op url naam";
            // 
            // ZoekOpUrlNaamTxtBx
            // 
            this.ZoekOpUrlNaamTxtBx.AllowPromptAsInput = true;
            this.ZoekOpUrlNaamTxtBx.AnimateReadOnly = false;
            this.ZoekOpUrlNaamTxtBx.AsciiOnly = false;
            this.ZoekOpUrlNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZoekOpUrlNaamTxtBx.BeepOnError = false;
            this.ZoekOpUrlNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ZoekOpUrlNaamTxtBx.Depth = 0;
            this.ZoekOpUrlNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ZoekOpUrlNaamTxtBx.HidePromptOnLeave = false;
            this.ZoekOpUrlNaamTxtBx.HideSelection = true;
            this.ZoekOpUrlNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ZoekOpUrlNaamTxtBx.LeadingIcon = null;
            this.ZoekOpUrlNaamTxtBx.Location = new System.Drawing.Point(6, 99);
            this.ZoekOpUrlNaamTxtBx.Mask = "";
            this.ZoekOpUrlNaamTxtBx.MaxLength = 32767;
            this.ZoekOpUrlNaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.ZoekOpUrlNaamTxtBx.Name = "ZoekOpUrlNaamTxtBx";
            this.ZoekOpUrlNaamTxtBx.PasswordChar = '\0';
            this.ZoekOpUrlNaamTxtBx.PrefixSuffixText = null;
            this.ZoekOpUrlNaamTxtBx.PromptChar = '_';
            this.ZoekOpUrlNaamTxtBx.ReadOnly = false;
            this.ZoekOpUrlNaamTxtBx.RejectInputOnFirstFailure = false;
            this.ZoekOpUrlNaamTxtBx.ResetOnPrompt = true;
            this.ZoekOpUrlNaamTxtBx.ResetOnSpace = true;
            this.ZoekOpUrlNaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZoekOpUrlNaamTxtBx.SelectedText = "";
            this.ZoekOpUrlNaamTxtBx.SelectionLength = 0;
            this.ZoekOpUrlNaamTxtBx.SelectionStart = 0;
            this.ZoekOpUrlNaamTxtBx.ShortcutsEnabled = true;
            this.ZoekOpUrlNaamTxtBx.Size = new System.Drawing.Size(363, 48);
            this.ZoekOpUrlNaamTxtBx.SkipLiterals = true;
            this.ZoekOpUrlNaamTxtBx.TabIndex = 88;
            this.ZoekOpUrlNaamTxtBx.TabStop = false;
            this.ZoekOpUrlNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ZoekOpUrlNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ZoekOpUrlNaamTxtBx.TrailingIcon = null;
            this.ZoekOpUrlNaamTxtBx.UseSystemPasswordChar = false;
            this.ZoekOpUrlNaamTxtBx.ValidatingType = null;
            this.ZoekOpUrlNaamTxtBx.TextChanged += new System.EventHandler(this.ZoekOpUrlNaamTxtBx_TextChanged);
            // 
            // AllUrlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 531);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.ZoekOpUrlNaamTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HttpKrMaterialCmbx);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.PasUrlAanBtn);
            this.Controls.Add(this.AddUrlBtn);
            this.Controls.Add(this.DeleteUrlBttn);
            this.Controls.Add(this.KlantKrMaterialCmbx);
            this.Controls.Add(this.WebserviceKrMaterialCmbx);
            this.Controls.Add(this.AllUrlsKrLstBx);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.UrlTxtBx);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.SecurityIdTxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.LblBewerken);
            this.MinimumSize = new System.Drawing.Size(1000, 427);
            this.Name = "AllUrlsForm";
            this.Text = "Urls beheren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LblBewerken;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox SecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialTextBox UrlTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private KrMaterialCombobox WebserviceKrMaterialCmbx;
        private KrMaterialCombobox KlantKrMaterialCmbx;
        private System.Windows.Forms.Button DeleteUrlBttn;
        private System.Windows.Forms.Button AddUrlBtn;
        private System.Windows.Forms.Button PasUrlAanBtn;
        private KrMaterialCombobox HttpKrMaterialCmbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private KrMaterialListBox AllUrlsKrLstBx;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMaskedTextBox ZoekOpUrlNaamTxtBx;
    }
}