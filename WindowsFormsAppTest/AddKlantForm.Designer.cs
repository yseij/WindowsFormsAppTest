
namespace WindowsFormsAppTest
{
    partial class AddKlantForm
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
            this.NewKlantNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LblName = new MaterialSkin.Controls.MaterialLabel();
            this.AddKlantBttn = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BasisUrl1TxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BasisUrl2TxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // NewKlantNaamTxtBx
            // 
            this.NewKlantNaamTxtBx.AllowPromptAsInput = true;
            this.NewKlantNaamTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewKlantNaamTxtBx.AnimateReadOnly = false;
            this.NewKlantNaamTxtBx.AsciiOnly = false;
            this.NewKlantNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewKlantNaamTxtBx.BeepOnError = false;
            this.NewKlantNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewKlantNaamTxtBx.Depth = 0;
            this.NewKlantNaamTxtBx.ErrorMessage = "test";
            this.NewKlantNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewKlantNaamTxtBx.HidePromptOnLeave = false;
            this.NewKlantNaamTxtBx.HideSelection = true;
            this.NewKlantNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewKlantNaamTxtBx.LeadingIcon = null;
            this.NewKlantNaamTxtBx.Location = new System.Drawing.Point(92, 67);
            this.NewKlantNaamTxtBx.Mask = "";
            this.NewKlantNaamTxtBx.MaxLength = 32767;
            this.NewKlantNaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.NewKlantNaamTxtBx.Name = "NewKlantNaamTxtBx";
            this.NewKlantNaamTxtBx.PasswordChar = '\0';
            this.NewKlantNaamTxtBx.PrefixSuffixText = null;
            this.NewKlantNaamTxtBx.PromptChar = '_';
            this.NewKlantNaamTxtBx.ReadOnly = false;
            this.NewKlantNaamTxtBx.RejectInputOnFirstFailure = false;
            this.NewKlantNaamTxtBx.ResetOnPrompt = true;
            this.NewKlantNaamTxtBx.ResetOnSpace = true;
            this.NewKlantNaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewKlantNaamTxtBx.SelectedText = "";
            this.NewKlantNaamTxtBx.SelectionLength = 0;
            this.NewKlantNaamTxtBx.SelectionStart = 0;
            this.NewKlantNaamTxtBx.ShortcutsEnabled = true;
            this.NewKlantNaamTxtBx.Size = new System.Drawing.Size(355, 48);
            this.NewKlantNaamTxtBx.SkipLiterals = true;
            this.NewKlantNaamTxtBx.TabIndex = 2;
            this.NewKlantNaamTxtBx.TabStop = false;
            this.NewKlantNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewKlantNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewKlantNaamTxtBx.TrailingIcon = null;
            this.NewKlantNaamTxtBx.UseSystemPasswordChar = false;
            this.NewKlantNaamTxtBx.ValidatingType = null;
            this.NewKlantNaamTxtBx.TextChanged += new System.EventHandler(this.NewKlantNaamTxtBx_TextChanged);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Depth = 0;
            this.LblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblName.Location = new System.Drawing.Point(7, 71);
            this.LblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(48, 19);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Naam:";
            // 
            // AddKlantBttn
            // 
            this.AddKlantBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddKlantBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddKlantBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddKlantBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddKlantBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddKlantBttn.Location = new System.Drawing.Point(307, 230);
            this.AddKlantBttn.Name = "AddKlantBttn";
            this.AddKlantBttn.Size = new System.Drawing.Size(140, 43);
            this.AddKlantBttn.TabIndex = 28;
            this.AddKlantBttn.Text = "KLANT TOEVOEGEN";
            this.AddKlantBttn.UseVisualStyleBackColor = false;
            this.AddKlantBttn.Click += new System.EventHandler(this.AddKlantBttn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Basis url 1:";
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
            this.BasisUrl1TxtBx.ErrorMessage = "test";
            this.BasisUrl1TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BasisUrl1TxtBx.HidePromptOnLeave = false;
            this.BasisUrl1TxtBx.HideSelection = true;
            this.BasisUrl1TxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BasisUrl1TxtBx.LeadingIcon = null;
            this.BasisUrl1TxtBx.Location = new System.Drawing.Point(92, 121);
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
            this.BasisUrl1TxtBx.Size = new System.Drawing.Size(355, 48);
            this.BasisUrl1TxtBx.SkipLiterals = true;
            this.BasisUrl1TxtBx.TabIndex = 30;
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
            this.materialLabel2.Location = new System.Drawing.Point(7, 179);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Basis url 2:";
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
            this.BasisUrl2TxtBx.ErrorMessage = "test";
            this.BasisUrl2TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BasisUrl2TxtBx.HidePromptOnLeave = false;
            this.BasisUrl2TxtBx.HideSelection = true;
            this.BasisUrl2TxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BasisUrl2TxtBx.LeadingIcon = null;
            this.BasisUrl2TxtBx.Location = new System.Drawing.Point(92, 175);
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
            this.BasisUrl2TxtBx.Size = new System.Drawing.Size(355, 48);
            this.BasisUrl2TxtBx.SkipLiterals = true;
            this.BasisUrl2TxtBx.TabIndex = 32;
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
            this.materialLabel3.Location = new System.Drawing.Point(6, 198);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "(eventueel)";
            // 
            // AddKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 279);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.BasisUrl2TxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BasisUrl1TxtBx);
            this.Controls.Add(this.AddKlantBttn);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.NewKlantNaamTxtBx);
            this.MinimumSize = new System.Drawing.Size(479, 279);
            this.Name = "AddKlantForm";
            this.Text = "Klant toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialMaskedTextBox NewKlantNaamTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblName;
        private System.Windows.Forms.Button AddKlantBttn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox BasisUrl1TxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox BasisUrl2TxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}