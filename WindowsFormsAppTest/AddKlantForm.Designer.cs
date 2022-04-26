
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
            this.BasisURlTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            // BasisURlTxtBx
            // 
            this.BasisURlTxtBx.AllowPromptAsInput = true;
            this.BasisURlTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasisURlTxtBx.AnimateReadOnly = false;
            this.BasisURlTxtBx.AsciiOnly = false;
            this.BasisURlTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BasisURlTxtBx.BeepOnError = false;
            this.BasisURlTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisURlTxtBx.Depth = 0;
            this.BasisURlTxtBx.ErrorMessage = "test";
            this.BasisURlTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BasisURlTxtBx.HidePromptOnLeave = false;
            this.BasisURlTxtBx.HideSelection = true;
            this.BasisURlTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BasisURlTxtBx.LeadingIcon = null;
            this.BasisURlTxtBx.Location = new System.Drawing.Point(92, 121);
            this.BasisURlTxtBx.Mask = "";
            this.BasisURlTxtBx.MaxLength = 32767;
            this.BasisURlTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.BasisURlTxtBx.Name = "BasisURlTxtBx";
            this.BasisURlTxtBx.PasswordChar = '\0';
            this.BasisURlTxtBx.PrefixSuffixText = null;
            this.BasisURlTxtBx.PromptChar = '_';
            this.BasisURlTxtBx.ReadOnly = false;
            this.BasisURlTxtBx.RejectInputOnFirstFailure = false;
            this.BasisURlTxtBx.ResetOnPrompt = true;
            this.BasisURlTxtBx.ResetOnSpace = true;
            this.BasisURlTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasisURlTxtBx.SelectedText = "";
            this.BasisURlTxtBx.SelectionLength = 0;
            this.BasisURlTxtBx.SelectionStart = 0;
            this.BasisURlTxtBx.ShortcutsEnabled = true;
            this.BasisURlTxtBx.Size = new System.Drawing.Size(355, 48);
            this.BasisURlTxtBx.SkipLiterals = true;
            this.BasisURlTxtBx.TabIndex = 30;
            this.BasisURlTxtBx.TabStop = false;
            this.BasisURlTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BasisURlTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisURlTxtBx.TrailingIcon = null;
            this.BasisURlTxtBx.UseSystemPasswordChar = false;
            this.BasisURlTxtBx.ValidatingType = null;
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
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.ErrorMessage = "test";
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(92, 175);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(355, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 32;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 198);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "(Eventueel)";
            // 
            // AddKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 279);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialMaskedTextBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BasisURlTxtBx);
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
        private MaterialSkin.Controls.MaterialMaskedTextBox BasisURlTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}