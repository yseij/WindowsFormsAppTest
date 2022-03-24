
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
            this.NewUrlTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.NewSecurityIdTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblSecurityID = new MaterialSkin.Controls.MaterialLabel();
            this.LblUrl = new MaterialSkin.Controls.MaterialLabel();
            this.LblWebservice = new MaterialSkin.Controls.MaterialLabel();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.KlantenKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.WebserviceKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.AddUrlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUrlTxtBx
            // 
            this.NewUrlTxtBx.AllowPromptAsInput = true;
            this.NewUrlTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.NewSecurityIdTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // KlantenKrMaterialCmbx
            // 
            this.KlantenKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KlantenKrMaterialCmbx.AutoResize = false;
            this.KlantenKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.KlantenKrMaterialCmbx.Depth = 0;
            this.KlantenKrMaterialCmbx.DisplayMember = "Name";
            this.KlantenKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.KlantenKrMaterialCmbx.DropDownHeight = 174;
            this.KlantenKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlantenKrMaterialCmbx.DropDownWidth = 121;
            this.KlantenKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.KlantenKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KlantenKrMaterialCmbx.FormattingEnabled = true;
            this.KlantenKrMaterialCmbx.IntegralHeight = false;
            this.KlantenKrMaterialCmbx.ItemHeight = 43;
            this.KlantenKrMaterialCmbx.Location = new System.Drawing.Point(101, 230);
            this.KlantenKrMaterialCmbx.MaxDropDownItems = 4;
            this.KlantenKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantenKrMaterialCmbx.Name = "KlantenKrMaterialCmbx";
            this.KlantenKrMaterialCmbx.Size = new System.Drawing.Size(370, 49);
            this.KlantenKrMaterialCmbx.StartIndex = 0;
            this.KlantenKrMaterialCmbx.TabIndex = 26;
            this.KlantenKrMaterialCmbx.ValueMember = "Id";
            this.KlantenKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.KlantenKrMaterialCmbx_SelectedIndexChanged);
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
            this.WebserviceKrMaterialCmbx.Location = new System.Drawing.Point(101, 175);
            this.WebserviceKrMaterialCmbx.MaxDropDownItems = 4;
            this.WebserviceKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebserviceKrMaterialCmbx.Name = "WebserviceKrMaterialCmbx";
            this.WebserviceKrMaterialCmbx.Size = new System.Drawing.Size(370, 49);
            this.WebserviceKrMaterialCmbx.StartIndex = 0;
            this.WebserviceKrMaterialCmbx.TabIndex = 25;
            this.WebserviceKrMaterialCmbx.ValueMember = "Id";
            this.WebserviceKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.WebserviceKrMaterialCmbx_SelectedIndexChanged);
            // 
            // AddUrlButton
            // 
            this.AddUrlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUrlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddUrlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUrlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUrlButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUrlButton.Location = new System.Drawing.Point(331, 285);
            this.AddUrlButton.Name = "AddUrlButton";
            this.AddUrlButton.Size = new System.Drawing.Size(140, 43);
            this.AddUrlButton.TabIndex = 27;
            this.AddUrlButton.Text = "URL TOEVOEGEN";
            this.AddUrlButton.UseVisualStyleBackColor = false;
            this.AddUrlButton.Click += new System.EventHandler(this.AddUrlButton_Click);
            // 
            // AddUrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 334);
            this.Controls.Add(this.AddUrlButton);
            this.Controls.Add(this.KlantenKrMaterialCmbx);
            this.Controls.Add(this.WebserviceKrMaterialCmbx);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.LblWebservice);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSecurityID);
            this.Controls.Add(this.NewSecurityIdTxtBx);
            this.Controls.Add(this.NewUrlTxtBx);
            this.MinimumSize = new System.Drawing.Size(482, 334);
            this.Name = "AddUrlForm";
            this.Text = "Url toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialMaskedTextBox NewUrlTxtBx;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewSecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblSecurityID;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private MaterialSkin.Controls.MaterialLabel LblWebservice;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private KrMaterialCombobox WebserviceKrMaterialCmbx;
        private KrMaterialCombobox KlantenKrMaterialCmbx;
        private System.Windows.Forms.Button AddUrlButton;
    }
}