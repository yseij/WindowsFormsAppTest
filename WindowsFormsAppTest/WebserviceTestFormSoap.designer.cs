namespace WindowsFormsAppTest
{
    partial class WebserviceTestFormSoap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebserviceTestFormSoap));
            this.labelHttpsText = new System.Windows.Forms.Label();
            this.BtnTestWebservice = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBxPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TxtBxUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTestResultaat = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.HttpKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.WebserviceKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHttpsText
            // 
            this.labelHttpsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHttpsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHttpsText.Location = new System.Drawing.Point(6, 188);
            this.labelHttpsText.Name = "labelHttpsText";
            this.labelHttpsText.Size = new System.Drawing.Size(831, 21);
            this.labelHttpsText.TabIndex = 36;
            this.labelHttpsText.Text = "Let op!: Om verbinding te kunnen maken met Kraan Sales dient bij Message Service " +
    "versie 3.1 inlog gegevens te worden geconfigureerd.";
            // 
            // BtnTestWebservice
            // 
            this.BtnTestWebservice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnTestWebservice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnTestWebservice.Depth = 0;
            this.BtnTestWebservice.HighEmphasis = true;
            this.BtnTestWebservice.Icon = null;
            this.BtnTestWebservice.Location = new System.Drawing.Point(678, 139);
            this.BtnTestWebservice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnTestWebservice.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnTestWebservice.Name = "BtnTestWebservice";
            this.BtnTestWebservice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnTestWebservice.Size = new System.Drawing.Size(158, 36);
            this.BtnTestWebservice.TabIndex = 37;
            this.BtnTestWebservice.Text = "Test Webservices";
            this.BtnTestWebservice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnTestWebservice.UseAccentColor = false;
            this.BtnTestWebservice.UseVisualStyleBackColor = true;
            this.BtnTestWebservice.Click += new System.EventHandler(this.BtnTestWebservice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.HttpKrMaterialCmbx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.WebserviceKrMaterialCmbx);
            this.groupBox2.Controls.Add(this.TxtBxPassword);
            this.groupBox2.Controls.Add(this.TxtBxUsername);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.BtnTestWebservice);
            this.groupBox2.Controls.Add(this.labelHttpsText);
            this.groupBox2.Location = new System.Drawing.Point(10, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 214);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Https";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(386, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "+";
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.AllowPromptAsInput = true;
            this.TxtBxPassword.AnimateReadOnly = false;
            this.TxtBxPassword.AsciiOnly = false;
            this.TxtBxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtBxPassword.BeepOnError = false;
            this.TxtBxPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TxtBxPassword.Depth = 0;
            this.TxtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBxPassword.HidePromptOnLeave = false;
            this.TxtBxPassword.HideSelection = true;
            this.TxtBxPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TxtBxPassword.LeadingIcon = null;
            this.TxtBxPassword.Location = new System.Drawing.Point(129, 127);
            this.TxtBxPassword.Mask = "";
            this.TxtBxPassword.MaxLength = 32767;
            this.TxtBxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.PasswordChar = '*';
            this.TxtBxPassword.PrefixSuffixText = null;
            this.TxtBxPassword.PromptChar = '_';
            this.TxtBxPassword.ReadOnly = false;
            this.TxtBxPassword.RejectInputOnFirstFailure = false;
            this.TxtBxPassword.ResetOnPrompt = true;
            this.TxtBxPassword.ResetOnSpace = true;
            this.TxtBxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxPassword.SelectedText = "";
            this.TxtBxPassword.SelectionLength = 0;
            this.TxtBxPassword.SelectionStart = 0;
            this.TxtBxPassword.ShortcutsEnabled = true;
            this.TxtBxPassword.Size = new System.Drawing.Size(532, 48);
            this.TxtBxPassword.SkipLiterals = true;
            this.TxtBxPassword.TabIndex = 43;
            this.TxtBxPassword.TabStop = false;
            this.TxtBxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBxPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TxtBxPassword.TrailingIcon = null;
            this.TxtBxPassword.UseSystemPasswordChar = false;
            this.TxtBxPassword.ValidatingType = null;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.AllowPromptAsInput = true;
            this.TxtBxUsername.AnimateReadOnly = false;
            this.TxtBxUsername.AsciiOnly = false;
            this.TxtBxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtBxUsername.BeepOnError = false;
            this.TxtBxUsername.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TxtBxUsername.Depth = 0;
            this.TxtBxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBxUsername.HidePromptOnLeave = false;
            this.TxtBxUsername.HideSelection = true;
            this.TxtBxUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TxtBxUsername.LeadingIcon = null;
            this.TxtBxUsername.Location = new System.Drawing.Point(129, 73);
            this.TxtBxUsername.Mask = "";
            this.TxtBxUsername.MaxLength = 32767;
            this.TxtBxUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.PasswordChar = '\0';
            this.TxtBxUsername.PrefixSuffixText = null;
            this.TxtBxUsername.PromptChar = '_';
            this.TxtBxUsername.ReadOnly = false;
            this.TxtBxUsername.RejectInputOnFirstFailure = false;
            this.TxtBxUsername.ResetOnPrompt = true;
            this.TxtBxUsername.ResetOnSpace = true;
            this.TxtBxUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxUsername.SelectedText = "";
            this.TxtBxUsername.SelectionLength = 0;
            this.TxtBxUsername.SelectionStart = 0;
            this.TxtBxUsername.ShortcutsEnabled = true;
            this.TxtBxUsername.Size = new System.Drawing.Size(532, 48);
            this.TxtBxUsername.SkipLiterals = true;
            this.TxtBxUsername.TabIndex = 42;
            this.TxtBxUsername.TabStop = false;
            this.TxtBxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBxUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TxtBxUsername.TrailingIcon = null;
            this.TxtBxUsername.UseSystemPasswordChar = false;
            this.TxtBxUsername.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 127);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 19);
            this.materialLabel3.TabIndex = 40;
            this.materialLabel3.Text = "Wachtwoord";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 39;
            this.materialLabel2.Text = "Gebruikersnaam";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Hostname";
            // 
            // txtTestResultaat
            // 
            this.txtTestResultaat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTestResultaat.AnimateReadOnly = false;
            this.txtTestResultaat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTestResultaat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTestResultaat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTestResultaat.Depth = 0;
            this.txtTestResultaat.HideSelection = true;
            this.txtTestResultaat.Location = new System.Drawing.Point(10, 294);
            this.txtTestResultaat.MaxLength = 32767;
            this.txtTestResultaat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTestResultaat.Name = "txtTestResultaat";
            this.txtTestResultaat.PasswordChar = '\0';
            this.txtTestResultaat.ReadOnly = false;
            this.txtTestResultaat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTestResultaat.SelectedText = "";
            this.txtTestResultaat.SelectionLength = 0;
            this.txtTestResultaat.SelectionStart = 0;
            this.txtTestResultaat.ShortcutsEnabled = true;
            this.txtTestResultaat.Size = new System.Drawing.Size(843, 254);
            this.txtTestResultaat.TabIndex = 42;
            this.txtTestResultaat.TabStop = false;
            this.txtTestResultaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTestResultaat.UseSystemPasswordChar = false;
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
            this.HttpKrMaterialCmbx.Location = new System.Drawing.Point(129, 16);
            this.HttpKrMaterialCmbx.MaxDropDownItems = 4;
            this.HttpKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.HttpKrMaterialCmbx.Name = "HttpKrMaterialCmbx";
            this.HttpKrMaterialCmbx.Size = new System.Drawing.Size(251, 49);
            this.HttpKrMaterialCmbx.StartIndex = 0;
            this.HttpKrMaterialCmbx.TabIndex = 45;
            this.HttpKrMaterialCmbx.ValueMember = "Id";
            // 
            // WebserviceKrMaterialCmbx
            // 
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
            this.WebserviceKrMaterialCmbx.Location = new System.Drawing.Point(408, 18);
            this.WebserviceKrMaterialCmbx.MaxDropDownItems = 4;
            this.WebserviceKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebserviceKrMaterialCmbx.Name = "WebserviceKrMaterialCmbx";
            this.WebserviceKrMaterialCmbx.Size = new System.Drawing.Size(253, 49);
            this.WebserviceKrMaterialCmbx.StartIndex = 0;
            this.WebserviceKrMaterialCmbx.TabIndex = 34;
            this.WebserviceKrMaterialCmbx.ValueMember = "Id";
            // 
            // WebserviceTestFormSoap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(859, 562);
            this.Controls.Add(this.txtTestResultaat);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebserviceTestFormSoap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Sales test Soap";
            this.Load += new System.EventHandler(this.WebserviceTestForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelHttpsText;
        private MaterialSkin.Controls.MaterialButton BtnTestWebservice;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox TxtBxPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox TxtBxUsername;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTestResultaat;
        private KrMaterialCombobox WebserviceKrMaterialCmbx;
        private System.Windows.Forms.Label label2;
        private KrMaterialCombobox HttpKrMaterialCmbx;
    }
}

