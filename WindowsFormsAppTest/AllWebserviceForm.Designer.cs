
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SoapWebserviceChkBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.PasWebserviceAanBtn = new System.Windows.Forms.Button();
            this.SecurityTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.AddWebserviceBtn = new System.Windows.Forms.Button();
            this.DeleteWebserviceBttn = new System.Windows.Forms.Button();
            this.WebserviceTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblNaam = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AllWebserviceKrLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.ZoekOpWebserviceNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.SoapWebserviceChkBx);
            this.groupBox1.Controls.Add(this.PasWebserviceAanBtn);
            this.groupBox1.Controls.Add(this.SecurityTxtBx);
            this.groupBox1.Controls.Add(this.DeleteWebserviceBttn);
            this.groupBox1.Controls.Add(this.WebserviceTxtBx);
            this.groupBox1.Controls.Add(this.LblNaam);
            this.groupBox1.Location = new System.Drawing.Point(389, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 224);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Webservice bewerken";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(7, 77);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 90;
            this.materialLabel2.Text = "SecurityId:";
            // 
            // SoapWebserviceChkBx
            // 
            this.SoapWebserviceChkBx.AutoSize = true;
            this.SoapWebserviceChkBx.Depth = 0;
            this.SoapWebserviceChkBx.Location = new System.Drawing.Point(88, 124);
            this.SoapWebserviceChkBx.Margin = new System.Windows.Forms.Padding(0);
            this.SoapWebserviceChkBx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SoapWebserviceChkBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.SoapWebserviceChkBx.Name = "SoapWebserviceChkBx";
            this.SoapWebserviceChkBx.ReadOnly = false;
            this.SoapWebserviceChkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SoapWebserviceChkBx.Ripple = true;
            this.SoapWebserviceChkBx.Size = new System.Drawing.Size(154, 37);
            this.SoapWebserviceChkBx.TabIndex = 89;
            this.SoapWebserviceChkBx.Text = "Soap webservice";
            this.SoapWebserviceChkBx.UseVisualStyleBackColor = true;
            // 
            // PasWebserviceAanBtn
            // 
            this.PasWebserviceAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasWebserviceAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasWebserviceAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasWebserviceAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasWebserviceAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasWebserviceAanBtn.Location = new System.Drawing.Point(354, 175);
            this.PasWebserviceAanBtn.Name = "PasWebserviceAanBtn";
            this.PasWebserviceAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasWebserviceAanBtn.TabIndex = 78;
            this.PasWebserviceAanBtn.Text = "WEBSERVICE AANPASSEN";
            this.PasWebserviceAanBtn.UseVisualStyleBackColor = false;
            this.PasWebserviceAanBtn.Click += new System.EventHandler(this.PasWebserviceAanBtn_Click);
            // 
            // SecurityTxtBx
            // 
            this.SecurityTxtBx.AllowPromptAsInput = true;
            this.SecurityTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityTxtBx.AnimateReadOnly = false;
            this.SecurityTxtBx.AsciiOnly = false;
            this.SecurityTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SecurityTxtBx.BeepOnError = false;
            this.SecurityTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.SecurityTxtBx.Depth = 0;
            this.SecurityTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SecurityTxtBx.HidePromptOnLeave = false;
            this.SecurityTxtBx.HideSelection = true;
            this.SecurityTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.SecurityTxtBx.LeadingIcon = null;
            this.SecurityTxtBx.Location = new System.Drawing.Point(88, 73);
            this.SecurityTxtBx.Mask = "";
            this.SecurityTxtBx.MaxLength = 32767;
            this.SecurityTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.SecurityTxtBx.Name = "SecurityTxtBx";
            this.SecurityTxtBx.PasswordChar = '\0';
            this.SecurityTxtBx.PrefixSuffixText = null;
            this.SecurityTxtBx.PromptChar = '_';
            this.SecurityTxtBx.ReadOnly = false;
            this.SecurityTxtBx.RejectInputOnFirstFailure = false;
            this.SecurityTxtBx.ResetOnPrompt = true;
            this.SecurityTxtBx.ResetOnSpace = true;
            this.SecurityTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecurityTxtBx.SelectedText = "";
            this.SecurityTxtBx.SelectionLength = 0;
            this.SecurityTxtBx.SelectionStart = 0;
            this.SecurityTxtBx.ShortcutsEnabled = true;
            this.SecurityTxtBx.Size = new System.Drawing.Size(378, 48);
            this.SecurityTxtBx.SkipLiterals = true;
            this.SecurityTxtBx.TabIndex = 91;
            this.SecurityTxtBx.TabStop = false;
            this.SecurityTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecurityTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.SecurityTxtBx.TrailingIcon = null;
            this.SecurityTxtBx.UseSystemPasswordChar = false;
            this.SecurityTxtBx.ValidatingType = null;
            // 
            // AddWebserviceBtn
            // 
            this.AddWebserviceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddWebserviceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddWebserviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWebserviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWebserviceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddWebserviceBtn.Location = new System.Drawing.Point(749, 108);
            this.AddWebserviceBtn.Name = "AddWebserviceBtn";
            this.AddWebserviceBtn.Size = new System.Drawing.Size(112, 48);
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
            this.DeleteWebserviceBttn.Location = new System.Drawing.Point(10, 175);
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
            this.WebserviceTxtBx.Location = new System.Drawing.Point(88, 19);
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
            this.WebserviceTxtBx.Size = new System.Drawing.Size(378, 48);
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
            // AllWebserviceKrLstBx
            // 
            this.AllWebserviceKrLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllWebserviceKrLstBx.BackColor = System.Drawing.Color.White;
            this.AllWebserviceKrLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllWebserviceKrLstBx.ItemHeight = 20;
            this.AllWebserviceKrLstBx.Location = new System.Drawing.Point(6, 203);
            this.AllWebserviceKrLstBx.Name = "AllWebserviceKrLstBx";
            this.AllWebserviceKrLstBx.Size = new System.Drawing.Size(376, 224);
            this.AllWebserviceKrLstBx.TabIndex = 66;
            this.AllWebserviceKrLstBx.SelectedIndexChanged += new System.EventHandler(this.AllWebserviceKrLstBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 2);
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
            this.ZoekOpWebserviceNaamTxtBx.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(868, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.ZoekOpWebserviceNaamTxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.AddWebserviceBtn);
            this.Controls.Add(this.AllWebserviceKrLstBx);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(868, 434);
            this.Name = "AllWebserviceForm";
            this.Text = "Webservices beheren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KrMaterialListBox AllWebserviceKrLstBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox WebserviceTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblNaam;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button PasWebserviceAanBtn;
        private System.Windows.Forms.Button AddWebserviceBtn;
        private System.Windows.Forms.Button DeleteWebserviceBttn;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMaskedTextBox ZoekOpWebserviceNaamTxtBx;
        private MaterialSkin.Controls.MaterialCheckbox SoapWebserviceChkBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox SecurityTxtBx;
    }
}