
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
            this.NewUrlTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.NewSecurityIdTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            this.AddUrlButton.TabIndex = 16;
            this.AddUrlButton.Text = "Url toevoegen";
            this.AddUrlButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddUrlButton.UseAccentColor = false;
            this.AddUrlButton.UseVisualStyleBackColor = true;
            // 
            // NewUrlTextBox
            // 
            this.NewUrlTextBox.AllowPromptAsInput = true;
            this.NewUrlTextBox.AnimateReadOnly = false;
            this.NewUrlTextBox.AsciiOnly = false;
            this.NewUrlTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewUrlTextBox.BeepOnError = false;
            this.NewUrlTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewUrlTextBox.Depth = 0;
            this.NewUrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewUrlTextBox.HidePromptOnLeave = false;
            this.NewUrlTextBox.HideSelection = true;
            this.NewUrlTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewUrlTextBox.LeadingIcon = null;
            this.NewUrlTextBox.Location = new System.Drawing.Point(101, 121);
            this.NewUrlTextBox.Mask = "";
            this.NewUrlTextBox.MaxLength = 32767;
            this.NewUrlTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NewUrlTextBox.Name = "NewUrlTextBox";
            this.NewUrlTextBox.PasswordChar = '\0';
            this.NewUrlTextBox.PrefixSuffixText = null;
            this.NewUrlTextBox.PromptChar = '_';
            this.NewUrlTextBox.ReadOnly = false;
            this.NewUrlTextBox.RejectInputOnFirstFailure = false;
            this.NewUrlTextBox.ResetOnPrompt = true;
            this.NewUrlTextBox.ResetOnSpace = true;
            this.NewUrlTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewUrlTextBox.SelectedText = "";
            this.NewUrlTextBox.SelectionLength = 0;
            this.NewUrlTextBox.SelectionStart = 0;
            this.NewUrlTextBox.ShortcutsEnabled = true;
            this.NewUrlTextBox.Size = new System.Drawing.Size(370, 48);
            this.NewUrlTextBox.SkipLiterals = true;
            this.NewUrlTextBox.TabIndex = 18;
            this.NewUrlTextBox.TabStop = false;
            this.NewUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewUrlTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewUrlTextBox.TrailingIcon = null;
            this.NewUrlTextBox.UseSystemPasswordChar = false;
            this.NewUrlTextBox.ValidatingType = null;
            // 
            // NewSecurityIdTextBox
            // 
            this.NewSecurityIdTextBox.AllowPromptAsInput = true;
            this.NewSecurityIdTextBox.AnimateReadOnly = false;
            this.NewSecurityIdTextBox.AsciiOnly = false;
            this.NewSecurityIdTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewSecurityIdTextBox.BeepOnError = false;
            this.NewSecurityIdTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewSecurityIdTextBox.Depth = 0;
            this.NewSecurityIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewSecurityIdTextBox.HidePromptOnLeave = false;
            this.NewSecurityIdTextBox.HideSelection = true;
            this.NewSecurityIdTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewSecurityIdTextBox.LeadingIcon = null;
            this.NewSecurityIdTextBox.Location = new System.Drawing.Point(100, 67);
            this.NewSecurityIdTextBox.Mask = "";
            this.NewSecurityIdTextBox.MaxLength = 32767;
            this.NewSecurityIdTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NewSecurityIdTextBox.Name = "NewSecurityIdTextBox";
            this.NewSecurityIdTextBox.PasswordChar = '\0';
            this.NewSecurityIdTextBox.PrefixSuffixText = null;
            this.NewSecurityIdTextBox.PromptChar = '_';
            this.NewSecurityIdTextBox.ReadOnly = false;
            this.NewSecurityIdTextBox.RejectInputOnFirstFailure = false;
            this.NewSecurityIdTextBox.ResetOnPrompt = true;
            this.NewSecurityIdTextBox.ResetOnSpace = true;
            this.NewSecurityIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewSecurityIdTextBox.SelectedText = "";
            this.NewSecurityIdTextBox.SelectionLength = 0;
            this.NewSecurityIdTextBox.SelectionStart = 0;
            this.NewSecurityIdTextBox.ShortcutsEnabled = true;
            this.NewSecurityIdTextBox.Size = new System.Drawing.Size(370, 48);
            this.NewSecurityIdTextBox.SkipLiterals = true;
            this.NewSecurityIdTextBox.TabIndex = 19;
            this.NewSecurityIdTextBox.TabStop = false;
            this.NewSecurityIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewSecurityIdTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewSecurityIdTextBox.TrailingIcon = null;
            this.NewSecurityIdTextBox.UseSystemPasswordChar = false;
            this.NewSecurityIdTextBox.ValidatingType = null;
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
            this.LblSecurityID.TabIndex = 16;
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
            this.LblUrl.TabIndex = 20;
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
            this.LblWebservice.TabIndex = 21;
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
            this.LblKlant.TabIndex = 22;
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
            this.Controls.Add(this.NewSecurityIdTextBox);
            this.Controls.Add(this.NewUrlTextBox);
            this.Controls.Add(this.AddUrlButton);
            this.Name = "AddUrlForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddUrlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton AddUrlButton;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewUrlTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewSecurityIdTextBox;
        private MaterialSkin.Controls.MaterialLabel LblSecurityID;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private MaterialSkin.Controls.MaterialLabel LblWebservice;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private MaterialSkin.Controls.MaterialComboBox WebServiceCmbx;
        private MaterialSkin.Controls.MaterialComboBox KlantCmbBx;
    }
}