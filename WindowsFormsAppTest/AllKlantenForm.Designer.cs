
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
            this.AllKlantLstBx = new System.Windows.Forms.ListBox();
            this.UrlsByKlantLstBx = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PasKlantAanBtn = new MaterialSkin.Controls.MaterialButton();
            this.KlantTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.AddKlantBtn = new MaterialSkin.Controls.MaterialButton();
            this.LblNaam = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteKlantBttn = new MaterialSkin.Controls.MaterialButton();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrlsByKlant = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SecurityIdTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblSecurityID = new MaterialSkin.Controls.MaterialLabel();
            this.UrlTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblNaamUrl = new MaterialSkin.Controls.MaterialLabel();
            this.LblWebservice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.WebServiceCmbx = new MaterialSkin.Controls.MaterialComboBox();
            this.KlantCmbBx = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PasUrlAanBtn = new MaterialSkin.Controls.MaterialButton();
            this.AddUrlByKlantBttn = new MaterialSkin.Controls.MaterialButton();
            this.DeleteUrlBttn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllKlantLstBx
            // 
            this.AllKlantLstBx.FormattingEnabled = true;
            this.AllKlantLstBx.Location = new System.Drawing.Point(6, 90);
            this.AllKlantLstBx.Name = "AllKlantLstBx";
            this.AllKlantLstBx.Size = new System.Drawing.Size(402, 147);
            this.AllKlantLstBx.TabIndex = 39;
            this.AllKlantLstBx.SelectedIndexChanged += new System.EventHandler(this.AllKlantLstBx_SelectedIndexChanged);
            // 
            // UrlsByKlantLstBx
            // 
            this.UrlsByKlantLstBx.FormattingEnabled = true;
            this.UrlsByKlantLstBx.Location = new System.Drawing.Point(5, 294);
            this.UrlsByKlantLstBx.Name = "UrlsByKlantLstBx";
            this.UrlsByKlantLstBx.Size = new System.Drawing.Size(402, 290);
            this.UrlsByKlantLstBx.TabIndex = 49;
            this.UrlsByKlantLstBx.SelectedIndexChanged += new System.EventHandler(this.UrlsByKlantLstBx_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PasKlantAanBtn);
            this.groupBox1.Controls.Add(this.KlantTxtBx);
            this.groupBox1.Controls.Add(this.AddKlantBtn);
            this.groupBox1.Controls.Add(this.LblNaam);
            this.groupBox1.Controls.Add(this.DeleteKlantBttn);
            this.groupBox1.Location = new System.Drawing.Point(414, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 147);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klant bewerken";
            // 
            // PasKlantAanBtn
            // 
            this.PasKlantAanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasKlantAanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PasKlantAanBtn.Depth = 0;
            this.PasKlantAanBtn.HighEmphasis = true;
            this.PasKlantAanBtn.Icon = null;
            this.PasKlantAanBtn.Location = new System.Drawing.Point(226, 102);
            this.PasKlantAanBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PasKlantAanBtn.MaximumSize = new System.Drawing.Size(282, 0);
            this.PasKlantAanBtn.MinimumSize = new System.Drawing.Size(150, 0);
            this.PasKlantAanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasKlantAanBtn.Name = "PasKlantAanBtn";
            this.PasKlantAanBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PasKlantAanBtn.Size = new System.Drawing.Size(161, 36);
            this.PasKlantAanBtn.TabIndex = 66;
            this.PasKlantAanBtn.Text = "Pas gegevens aan";
            this.PasKlantAanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PasKlantAanBtn.UseAccentColor = false;
            this.PasKlantAanBtn.UseVisualStyleBackColor = true;
            // 
            // KlantTxtBx
            // 
            this.KlantTxtBx.AllowPromptAsInput = true;
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
            this.KlantTxtBx.Size = new System.Drawing.Size(326, 48);
            this.KlantTxtBx.SkipLiterals = true;
            this.KlantTxtBx.TabIndex = 62;
            this.KlantTxtBx.TabStop = false;
            this.KlantTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KlantTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.KlantTxtBx.TrailingIcon = null;
            this.KlantTxtBx.UseSystemPasswordChar = false;
            this.KlantTxtBx.ValidatingType = null;
            // 
            // AddKlantBtn
            // 
            this.AddKlantBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddKlantBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddKlantBtn.Depth = 0;
            this.AddKlantBtn.HighEmphasis = true;
            this.AddKlantBtn.Icon = null;
            this.AddKlantBtn.Location = new System.Drawing.Point(118, 102);
            this.AddKlantBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddKlantBtn.MaximumSize = new System.Drawing.Size(100, 0);
            this.AddKlantBtn.MinimumSize = new System.Drawing.Size(100, 0);
            this.AddKlantBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddKlantBtn.Name = "AddKlantBtn";
            this.AddKlantBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddKlantBtn.Size = new System.Drawing.Size(100, 36);
            this.AddKlantBtn.TabIndex = 65;
            this.AddKlantBtn.Text = "Klant toevoegen";
            this.AddKlantBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddKlantBtn.UseAccentColor = false;
            this.AddKlantBtn.UseVisualStyleBackColor = true;
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
            // DeleteKlantBttn
            // 
            this.DeleteKlantBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteKlantBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteKlantBttn.Depth = 0;
            this.DeleteKlantBttn.HighEmphasis = true;
            this.DeleteKlantBttn.Icon = null;
            this.DeleteKlantBttn.Location = new System.Drawing.Point(10, 102);
            this.DeleteKlantBttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteKlantBttn.MaximumSize = new System.Drawing.Size(100, 0);
            this.DeleteKlantBttn.MinimumSize = new System.Drawing.Size(100, 0);
            this.DeleteKlantBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteKlantBttn.Name = "DeleteKlantBttn";
            this.DeleteKlantBttn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteKlantBttn.Size = new System.Drawing.Size(100, 36);
            this.DeleteKlantBttn.TabIndex = 64;
            this.DeleteKlantBttn.Text = "Klant verwijderen";
            this.DeleteKlantBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteKlantBttn.UseAccentColor = false;
            this.DeleteKlantBttn.UseVisualStyleBackColor = true;
            // 
            // LblKlant
            // 
            this.LblKlant.AutoSize = true;
            this.LblKlant.Depth = 0;
            this.LblKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblKlant.Location = new System.Drawing.Point(7, 68);
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
            this.LblUrlsByKlant.Location = new System.Drawing.Point(6, 272);
            this.LblUrlsByKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrlsByKlant.Name = "LblUrlsByKlant";
            this.LblUrlsByKlant.Size = new System.Drawing.Size(172, 19);
            this.LblUrlsByKlant.TabIndex = 60;
            this.LblUrlsByKlant.Text = "Urls bij de gekozen klant";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 244);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(807, 23);
            this.materialDivider1.TabIndex = 63;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.AllowPromptAsInput = true;
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
            this.SecurityIdTxtBx.Size = new System.Drawing.Size(289, 48);
            this.SecurityIdTxtBx.SkipLiterals = true;
            this.SecurityIdTxtBx.TabIndex = 68;
            this.SecurityIdTxtBx.TabStop = false;
            this.SecurityIdTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecurityIdTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.SecurityIdTxtBx.TrailingIcon = null;
            this.SecurityIdTxtBx.UseSystemPasswordChar = false;
            this.SecurityIdTxtBx.ValidatingType = null;
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
            this.UrlTxtBx.Size = new System.Drawing.Size(289, 48);
            this.UrlTxtBx.SkipLiterals = true;
            this.UrlTxtBx.TabIndex = 70;
            this.UrlTxtBx.TabStop = false;
            this.UrlTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UrlTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.UrlTxtBx.TrailingIcon = null;
            this.UrlTxtBx.UseSystemPasswordChar = false;
            this.UrlTxtBx.ValidatingType = null;
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
            // WebServiceCmbx
            // 
            this.WebServiceCmbx.AutoResize = false;
            this.WebServiceCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WebServiceCmbx.Depth = 0;
            this.WebServiceCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WebServiceCmbx.DropDownHeight = 174;
            this.WebServiceCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebServiceCmbx.DropDownWidth = 121;
            this.WebServiceCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WebServiceCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WebServiceCmbx.FormattingEnabled = true;
            this.WebServiceCmbx.IntegralHeight = false;
            this.WebServiceCmbx.ItemHeight = 43;
            this.WebServiceCmbx.Location = new System.Drawing.Point(98, 127);
            this.WebServiceCmbx.MaxDropDownItems = 4;
            this.WebServiceCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebServiceCmbx.Name = "WebServiceCmbx";
            this.WebServiceCmbx.Size = new System.Drawing.Size(289, 49);
            this.WebServiceCmbx.StartIndex = 0;
            this.WebServiceCmbx.TabIndex = 74;
            // 
            // KlantCmbBx
            // 
            this.KlantCmbBx.AutoResize = false;
            this.KlantCmbBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.KlantCmbBx.Depth = 0;
            this.KlantCmbBx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.KlantCmbBx.DropDownHeight = 174;
            this.KlantCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlantCmbBx.DropDownWidth = 121;
            this.KlantCmbBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.KlantCmbBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KlantCmbBx.FormattingEnabled = true;
            this.KlantCmbBx.IntegralHeight = false;
            this.KlantCmbBx.ItemHeight = 43;
            this.KlantCmbBx.Location = new System.Drawing.Point(98, 182);
            this.KlantCmbBx.MaxDropDownItems = 4;
            this.KlantCmbBx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantCmbBx.Name = "KlantCmbBx";
            this.KlantCmbBx.Size = new System.Drawing.Size(289, 49);
            this.KlantCmbBx.StartIndex = 0;
            this.KlantCmbBx.TabIndex = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PasUrlAanBtn);
            this.groupBox2.Controls.Add(this.AddUrlByKlantBttn);
            this.groupBox2.Controls.Add(this.SecurityIdTxtBx);
            this.groupBox2.Controls.Add(this.DeleteUrlBttn);
            this.groupBox2.Controls.Add(this.KlantCmbBx);
            this.groupBox2.Controls.Add(this.LblSecurityID);
            this.groupBox2.Controls.Add(this.LblNaamUrl);
            this.groupBox2.Controls.Add(this.WebServiceCmbx);
            this.groupBox2.Controls.Add(this.UrlTxtBx);
            this.groupBox2.Controls.Add(this.LblWebservice);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Location = new System.Drawing.Point(414, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 290);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Url bewerken";
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasUrlAanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PasUrlAanBtn.Depth = 0;
            this.PasUrlAanBtn.HighEmphasis = true;
            this.PasUrlAanBtn.Icon = null;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(226, 240);
            this.PasUrlAanBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PasUrlAanBtn.MaximumSize = new System.Drawing.Size(282, 0);
            this.PasUrlAanBtn.MinimumSize = new System.Drawing.Size(150, 0);
            this.PasUrlAanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PasUrlAanBtn.Size = new System.Drawing.Size(161, 36);
            this.PasUrlAanBtn.TabIndex = 69;
            this.PasUrlAanBtn.Text = "Pas gegevens aan";
            this.PasUrlAanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PasUrlAanBtn.UseAccentColor = false;
            this.PasUrlAanBtn.UseVisualStyleBackColor = true;
            // 
            // AddUrlByKlantBttn
            // 
            this.AddUrlByKlantBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddUrlByKlantBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddUrlByKlantBttn.Depth = 0;
            this.AddUrlByKlantBttn.HighEmphasis = true;
            this.AddUrlByKlantBttn.Icon = null;
            this.AddUrlByKlantBttn.Location = new System.Drawing.Point(118, 240);
            this.AddUrlByKlantBttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddUrlByKlantBttn.MaximumSize = new System.Drawing.Size(100, 0);
            this.AddUrlByKlantBttn.MinimumSize = new System.Drawing.Size(100, 0);
            this.AddUrlByKlantBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddUrlByKlantBttn.Name = "AddUrlByKlantBttn";
            this.AddUrlByKlantBttn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddUrlByKlantBttn.Size = new System.Drawing.Size(100, 36);
            this.AddUrlByKlantBttn.TabIndex = 68;
            this.AddUrlByKlantBttn.Text = "Klant toevoegen";
            this.AddUrlByKlantBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddUrlByKlantBttn.UseAccentColor = false;
            this.AddUrlByKlantBttn.UseVisualStyleBackColor = true;
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteUrlBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteUrlBttn.Depth = 0;
            this.DeleteUrlBttn.HighEmphasis = true;
            this.DeleteUrlBttn.Icon = null;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(10, 240);
            this.DeleteUrlBttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteUrlBttn.MaximumSize = new System.Drawing.Size(100, 0);
            this.DeleteUrlBttn.MinimumSize = new System.Drawing.Size(100, 0);
            this.DeleteUrlBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteUrlBttn.Size = new System.Drawing.Size(100, 36);
            this.DeleteUrlBttn.TabIndex = 67;
            this.DeleteUrlBttn.Text = "Klant verwijderen";
            this.DeleteUrlBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteUrlBttn.UseAccentColor = false;
            this.DeleteUrlBttn.UseVisualStyleBackColor = true;
            // 
            // AllKlantenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 595);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.LblUrlsByKlant);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UrlsByKlantLstBx);
            this.Controls.Add(this.AllKlantLstBx);
            this.Name = "AllKlantenForm";
            this.Text = "Klanten beheren";
            this.Load += new System.EventHandler(this.AllKlantenForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox AllKlantLstBx;
        private System.Windows.Forms.ListBox UrlsByKlantLstBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox KlantTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblNaam;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private MaterialSkin.Controls.MaterialLabel LblUrlsByKlant;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton PasKlantAanBtn;
        private MaterialSkin.Controls.MaterialButton AddKlantBtn;
        private MaterialSkin.Controls.MaterialButton DeleteKlantBttn;
        private MaterialSkin.Controls.MaterialMaskedTextBox SecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblSecurityID;
        private MaterialSkin.Controls.MaterialMaskedTextBox UrlTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblNaamUrl;
        private MaterialSkin.Controls.MaterialLabel LblWebservice;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox WebServiceCmbx;
        private MaterialSkin.Controls.MaterialComboBox KlantCmbBx;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton PasUrlAanBtn;
        private MaterialSkin.Controls.MaterialButton AddUrlByKlantBttn;
        private MaterialSkin.Controls.MaterialButton DeleteUrlBttn;
    }
}