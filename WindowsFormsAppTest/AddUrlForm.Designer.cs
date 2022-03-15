
namespace WindowsFormsAppTest
{
    partial class AddUrlForm
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
            this.AddUrlButton = new MaterialSkin.Controls.MaterialButton();
            this.NewUrlTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.NewSecurityIdTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblSecurityID = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrl = new MaterialSkin.Controls.MaterialLabel();
            this.LblWebservice = new MaterialSkin.Controls.MaterialLabel();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.WebServiceCmbx = new MaterialSkin.Controls.MaterialComboBox();
            this.KlantCmbBx = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // AddUrlButton
            // 
            this.AddUrlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddUrlButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddUrlButton.Depth = 0;
            this.AddUrlButton.HighEmphasis = true;
            this.AddUrlButton.Icon = null;
            this.AddUrlButton.Location = new System.Drawing.Point(334, 286);
            this.AddUrlButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddUrlButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddUrlButton.Name = "AddUrlButton";
            this.AddUrlButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddUrlButton.Size = new System.Drawing.Size(136, 36);
            this.AddUrlButton.TabIndex = 8;
            this.AddUrlButton.Text = "Url toevoegen";
            this.AddUrlButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddUrlButton.UseAccentColor = false;
            this.AddUrlButton.UseVisualStyleBackColor = true;
            this.AddUrlButton.Click += new System.EventHandler(this.AddUrlButton_Click);
            // 
            // NewUrlTxtBx
            // 
            this.NewUrlTxtBx.AllowPromptAsInput = true;
            this.NewUrlTxtBx.AnimateReadOnly = false;
            this.NewUrlTxtBx.AsciiOnly = false;
            this.NewUrlTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewUrlTxtBx.BeepOnError = false;
            this.NewUrlTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewUrlTxtBx.Depth = 0;
            this.NewUrlTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewUrlTxtBx.HidePromptOnLeave = false;
            this.NewUrlTxtBx.HideSelection = true;
            this.NewUrlTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewUrlTxtBx.LeadingIcon = null;
            this.NewUrlTxtBx.Location = new System.Drawing.Point(101, 121);
            this.NewUrlTxtBx.Mask = "";
            this.NewUrlTxtBx.MaxLength = 32767;
            this.NewUrlTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.NewUrlTxtBx.Name = "NewUrlTxtBx";
            this.NewUrlTxtBx.PasswordChar = '\0';
            this.NewUrlTxtBx.PrefixSuffixText = null;
            this.NewUrlTxtBx.PromptChar = '_';
            this.NewUrlTxtBx.ReadOnly = false;
            this.NewUrlTxtBx.RejectInputOnFirstFailure = false;
            this.NewUrlTxtBx.ResetOnPrompt = true;
            this.NewUrlTxtBx.ResetOnSpace = true;
            this.NewUrlTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewUrlTxtBx.SelectedText = "";
            this.NewUrlTxtBx.SelectionLength = 0;
            this.NewUrlTxtBx.SelectionStart = 0;
            this.NewUrlTxtBx.ShortcutsEnabled = true;
            this.NewUrlTxtBx.Size = new System.Drawing.Size(370, 48);
            this.NewUrlTxtBx.SkipLiterals = true;
            this.NewUrlTxtBx.TabIndex = 2;
            this.NewUrlTxtBx.TabStop = false;
            this.NewUrlTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewUrlTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewUrlTxtBx.TrailingIcon = null;
            this.NewUrlTxtBx.UseSystemPasswordChar = false;
            this.NewUrlTxtBx.ValidatingType = null;
            this.NewUrlTxtBx.TextChanged += new System.EventHandler(this.NewUrlTxtBx_TextChanged);
            // 
            // NewSecurityIdTxtBx
            // 
            this.NewSecurityIdTxtBx.AllowPromptAsInput = true;
            this.NewSecurityIdTxtBx.AnimateReadOnly = false;
            this.NewSecurityIdTxtBx.AsciiOnly = false;
            this.NewSecurityIdTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewSecurityIdTxtBx.BeepOnError = false;
            this.NewSecurityIdTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewSecurityIdTxtBx.Depth = 0;
            this.NewSecurityIdTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewSecurityIdTxtBx.HidePromptOnLeave = false;
            this.NewSecurityIdTxtBx.HideSelection = true;
            this.NewSecurityIdTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewSecurityIdTxtBx.LeadingIcon = null;
            this.NewSecurityIdTxtBx.Location = new System.Drawing.Point(100, 67);
            this.NewSecurityIdTxtBx.Mask = "";
            this.NewSecurityIdTxtBx.MaxLength = 32767;
            this.NewSecurityIdTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.NewSecurityIdTxtBx.Name = "NewSecurityIdTxtBx";
            this.NewSecurityIdTxtBx.PasswordChar = '\0';
            this.NewSecurityIdTxtBx.PrefixSuffixText = null;
            this.NewSecurityIdTxtBx.PromptChar = '_';
            this.NewSecurityIdTxtBx.ReadOnly = false;
            this.NewSecurityIdTxtBx.RejectInputOnFirstFailure = false;
            this.NewSecurityIdTxtBx.ResetOnPrompt = true;
            this.NewSecurityIdTxtBx.ResetOnSpace = true;
            this.NewSecurityIdTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewSecurityIdTxtBx.SelectedText = "";
            this.NewSecurityIdTxtBx.SelectionLength = 0;
            this.NewSecurityIdTxtBx.SelectionStart = 0;
            this.NewSecurityIdTxtBx.ShortcutsEnabled = true;
            this.NewSecurityIdTxtBx.Size = new System.Drawing.Size(370, 48);
            this.NewSecurityIdTxtBx.SkipLiterals = true;
            this.NewSecurityIdTxtBx.TabIndex = 1;
            this.NewSecurityIdTxtBx.TabStop = false;
            this.NewSecurityIdTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewSecurityIdTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewSecurityIdTxtBx.TrailingIcon = null;
            this.NewSecurityIdTxtBx.UseSystemPasswordChar = false;
            this.NewSecurityIdTxtBx.ValidatingType = null;
            this.NewSecurityIdTxtBx.TextChanged += new System.EventHandler(this.NewSecurityIdTxtBx_TextChanged);
            // 
            // LblSecurityID
            // 
            this.LblSecurityID.AutoSize = true;
            this.LblSecurityID.Depth = 0;
            this.LblSecurityID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSecurityID.Location = new System.Drawing.Point(9, 67);
            this.LblSecurityID.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSecurityID.Name = "LblSecurityID";
            this.LblSecurityID.Size = new System.Drawing.Size(77, 19);
            this.LblSecurityID.TabIndex = 1;
            this.LblSecurityID.Text = "SecurityID:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Depth = 0;
            this.LblUrl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblUrl.Location = new System.Drawing.Point(9, 121);
            this.LblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(24, 19);
            this.LblUrl.TabIndex = 3;
            this.LblUrl.Text = "Url:";
            // 
            // LblWebservice
            // 
            this.LblWebservice.AutoSize = true;
            this.LblWebservice.Depth = 0;
            this.LblWebservice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblWebservice.Location = new System.Drawing.Point(9, 175);
            this.LblWebservice.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblWebservice.Name = "LblWebservice";
            this.LblWebservice.Size = new System.Drawing.Size(85, 19);
            this.LblWebservice.TabIndex = 5;
            this.LblWebservice.Text = "Webservice:";
            // 
            // LblKlant
            // 
            this.LblKlant.AutoSize = true;
            this.LblKlant.Depth = 0;
            this.LblKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblKlant.Location = new System.Drawing.Point(9, 229);
            this.LblKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblKlant.Name = "LblKlant";
            this.LblKlant.Size = new System.Drawing.Size(42, 19);
            this.LblKlant.TabIndex = 7;
            this.LblKlant.Text = "Klant:";
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
            this.WebServiceCmbx.Location = new System.Drawing.Point(100, 175);
            this.WebServiceCmbx.MaxDropDownItems = 4;
            this.WebServiceCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebServiceCmbx.Name = "WebServiceCmbx";
            this.WebServiceCmbx.Size = new System.Drawing.Size(370, 49);
            this.WebServiceCmbx.StartIndex = 0;
            this.WebServiceCmbx.TabIndex = 23;
            this.WebServiceCmbx.SelectedIndexChanged += new System.EventHandler(this.WebServiceCmbx_SelectedIndexChanged);
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
            this.KlantCmbBx.Location = new System.Drawing.Point(100, 230);
            this.KlantCmbBx.MaxDropDownItems = 4;
            this.KlantCmbBx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantCmbBx.Name = "KlantCmbBx";
            this.KlantCmbBx.Size = new System.Drawing.Size(370, 49);
            this.KlantCmbBx.StartIndex = 0;
            this.KlantCmbBx.TabIndex = 24;
            this.KlantCmbBx.SelectedIndexChanged += new System.EventHandler(this.KlantCmbBx_SelectedIndexChanged);
            // 
            // AddUrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 334);
            this.Controls.Add(this.KlantCmbBx);
            this.Controls.Add(this.WebServiceCmbx);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.LblWebservice);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSecurityID);
            this.Controls.Add(this.NewSecurityIdTxtBx);
            this.Controls.Add(this.NewUrlTxtBx);
            this.Controls.Add(this.AddUrlButton);
            this.Name = "AddUrlForm";
            this.Text = "Url toevoegen";
            this.Load += new System.EventHandler(this.AddUrlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton AddUrlButton;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewUrlTxtBx;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewSecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblSecurityID;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private MaterialSkin.Controls.MaterialLabel LblWebservice;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private MaterialSkin.Controls.MaterialComboBox WebServiceCmbx;
        private MaterialSkin.Controls.MaterialComboBox KlantCmbBx;
    }
}