
namespace WindowsFormsAppTest
{
    partial class MailServerForm
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
            this.ServerNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ServerPoortTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.GebruikersnaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.WachtwoordTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.GegevensOpslaanBtn = new System.Windows.Forms.Button();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.MailVerzendenVanuitEmailTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // ServerNaamTxtBx
            // 
            this.ServerNaamTxtBx.AllowPromptAsInput = true;
            this.ServerNaamTxtBx.AnimateReadOnly = false;
            this.ServerNaamTxtBx.AsciiOnly = false;
            this.ServerNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ServerNaamTxtBx.BeepOnError = false;
            this.ServerNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ServerNaamTxtBx.Depth = 0;
            this.ServerNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServerNaamTxtBx.HidePromptOnLeave = false;
            this.ServerNaamTxtBx.HideSelection = true;
            this.ServerNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ServerNaamTxtBx.LeadingIcon = null;
            this.ServerNaamTxtBx.Location = new System.Drawing.Point(208, 74);
            this.ServerNaamTxtBx.Mask = "";
            this.ServerNaamTxtBx.MaxLength = 32767;
            this.ServerNaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.ServerNaamTxtBx.Name = "ServerNaamTxtBx";
            this.ServerNaamTxtBx.PasswordChar = '\0';
            this.ServerNaamTxtBx.PrefixSuffixText = null;
            this.ServerNaamTxtBx.PromptChar = '_';
            this.ServerNaamTxtBx.ReadOnly = false;
            this.ServerNaamTxtBx.RejectInputOnFirstFailure = false;
            this.ServerNaamTxtBx.ResetOnPrompt = true;
            this.ServerNaamTxtBx.ResetOnSpace = true;
            this.ServerNaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerNaamTxtBx.SelectedText = "";
            this.ServerNaamTxtBx.SelectionLength = 0;
            this.ServerNaamTxtBx.SelectionStart = 0;
            this.ServerNaamTxtBx.ShortcutsEnabled = true;
            this.ServerNaamTxtBx.Size = new System.Drawing.Size(250, 48);
            this.ServerNaamTxtBx.SkipLiterals = true;
            this.ServerNaamTxtBx.TabIndex = 0;
            this.ServerNaamTxtBx.TabStop = false;
            this.ServerNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServerNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ServerNaamTxtBx.TrailingIcon = null;
            this.ServerNaamTxtBx.UseSystemPasswordChar = false;
            this.ServerNaamTxtBx.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Mail server naam:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 143);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Mail server poort:";
            // 
            // ServerPoortTxtBx
            // 
            this.ServerPoortTxtBx.AllowPromptAsInput = true;
            this.ServerPoortTxtBx.AnimateReadOnly = false;
            this.ServerPoortTxtBx.AsciiOnly = false;
            this.ServerPoortTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ServerPoortTxtBx.BeepOnError = false;
            this.ServerPoortTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ServerPoortTxtBx.Depth = 0;
            this.ServerPoortTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServerPoortTxtBx.HidePromptOnLeave = false;
            this.ServerPoortTxtBx.HideSelection = true;
            this.ServerPoortTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ServerPoortTxtBx.LeadingIcon = null;
            this.ServerPoortTxtBx.Location = new System.Drawing.Point(208, 128);
            this.ServerPoortTxtBx.Mask = "";
            this.ServerPoortTxtBx.MaxLength = 32767;
            this.ServerPoortTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.ServerPoortTxtBx.Name = "ServerPoortTxtBx";
            this.ServerPoortTxtBx.PasswordChar = '\0';
            this.ServerPoortTxtBx.PrefixSuffixText = null;
            this.ServerPoortTxtBx.PromptChar = '_';
            this.ServerPoortTxtBx.ReadOnly = false;
            this.ServerPoortTxtBx.RejectInputOnFirstFailure = false;
            this.ServerPoortTxtBx.ResetOnPrompt = true;
            this.ServerPoortTxtBx.ResetOnSpace = true;
            this.ServerPoortTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerPoortTxtBx.SelectedText = "";
            this.ServerPoortTxtBx.SelectionLength = 0;
            this.ServerPoortTxtBx.SelectionStart = 0;
            this.ServerPoortTxtBx.ShortcutsEnabled = true;
            this.ServerPoortTxtBx.Size = new System.Drawing.Size(250, 48);
            this.ServerPoortTxtBx.SkipLiterals = true;
            this.ServerPoortTxtBx.TabIndex = 2;
            this.ServerPoortTxtBx.TabStop = false;
            this.ServerPoortTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServerPoortTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ServerPoortTxtBx.TrailingIcon = null;
            this.ServerPoortTxtBx.UseSystemPasswordChar = false;
            this.ServerPoortTxtBx.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 248);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(200, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Mail server gebruikersnaam:";
            // 
            // GebruikersnaamTxtBx
            // 
            this.GebruikersnaamTxtBx.AllowPromptAsInput = true;
            this.GebruikersnaamTxtBx.AnimateReadOnly = false;
            this.GebruikersnaamTxtBx.AsciiOnly = false;
            this.GebruikersnaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GebruikersnaamTxtBx.BeepOnError = false;
            this.GebruikersnaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.GebruikersnaamTxtBx.Depth = 0;
            this.GebruikersnaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GebruikersnaamTxtBx.HidePromptOnLeave = false;
            this.GebruikersnaamTxtBx.HideSelection = true;
            this.GebruikersnaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.GebruikersnaamTxtBx.LeadingIcon = null;
            this.GebruikersnaamTxtBx.Location = new System.Drawing.Point(208, 233);
            this.GebruikersnaamTxtBx.Mask = "";
            this.GebruikersnaamTxtBx.MaxLength = 32767;
            this.GebruikersnaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.GebruikersnaamTxtBx.Name = "GebruikersnaamTxtBx";
            this.GebruikersnaamTxtBx.PasswordChar = '\0';
            this.GebruikersnaamTxtBx.PrefixSuffixText = null;
            this.GebruikersnaamTxtBx.PromptChar = '_';
            this.GebruikersnaamTxtBx.ReadOnly = false;
            this.GebruikersnaamTxtBx.RejectInputOnFirstFailure = false;
            this.GebruikersnaamTxtBx.ResetOnPrompt = true;
            this.GebruikersnaamTxtBx.ResetOnSpace = true;
            this.GebruikersnaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GebruikersnaamTxtBx.SelectedText = "";
            this.GebruikersnaamTxtBx.SelectionLength = 0;
            this.GebruikersnaamTxtBx.SelectionStart = 0;
            this.GebruikersnaamTxtBx.ShortcutsEnabled = true;
            this.GebruikersnaamTxtBx.Size = new System.Drawing.Size(250, 48);
            this.GebruikersnaamTxtBx.SkipLiterals = true;
            this.GebruikersnaamTxtBx.TabIndex = 4;
            this.GebruikersnaamTxtBx.TabStop = false;
            this.GebruikersnaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GebruikersnaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.GebruikersnaamTxtBx.TrailingIcon = null;
            this.GebruikersnaamTxtBx.UseSystemPasswordChar = false;
            this.GebruikersnaamTxtBx.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 302);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(173, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Mail server wachtwoord:";
            // 
            // WachtwoordTxtBx
            // 
            this.WachtwoordTxtBx.AllowPromptAsInput = true;
            this.WachtwoordTxtBx.AnimateReadOnly = false;
            this.WachtwoordTxtBx.AsciiOnly = false;
            this.WachtwoordTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WachtwoordTxtBx.BeepOnError = false;
            this.WachtwoordTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.WachtwoordTxtBx.Depth = 0;
            this.WachtwoordTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WachtwoordTxtBx.HidePromptOnLeave = false;
            this.WachtwoordTxtBx.HideSelection = true;
            this.WachtwoordTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.WachtwoordTxtBx.LeadingIcon = null;
            this.WachtwoordTxtBx.Location = new System.Drawing.Point(208, 287);
            this.WachtwoordTxtBx.Mask = "";
            this.WachtwoordTxtBx.MaxLength = 32767;
            this.WachtwoordTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.WachtwoordTxtBx.Name = "WachtwoordTxtBx";
            this.WachtwoordTxtBx.PasswordChar = '*';
            this.WachtwoordTxtBx.PrefixSuffixText = null;
            this.WachtwoordTxtBx.PromptChar = '_';
            this.WachtwoordTxtBx.ReadOnly = false;
            this.WachtwoordTxtBx.RejectInputOnFirstFailure = false;
            this.WachtwoordTxtBx.ResetOnPrompt = true;
            this.WachtwoordTxtBx.ResetOnSpace = true;
            this.WachtwoordTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WachtwoordTxtBx.SelectedText = "";
            this.WachtwoordTxtBx.SelectionLength = 0;
            this.WachtwoordTxtBx.SelectionStart = 0;
            this.WachtwoordTxtBx.ShortcutsEnabled = true;
            this.WachtwoordTxtBx.Size = new System.Drawing.Size(250, 48);
            this.WachtwoordTxtBx.SkipLiterals = true;
            this.WachtwoordTxtBx.TabIndex = 6;
            this.WachtwoordTxtBx.TabStop = false;
            this.WachtwoordTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WachtwoordTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.WachtwoordTxtBx.TrailingIcon = null;
            this.WachtwoordTxtBx.UseSystemPasswordChar = false;
            this.WachtwoordTxtBx.ValidatingType = null;
            // 
            // GegevensOpslaanBtn
            // 
            this.GegevensOpslaanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GegevensOpslaanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.GegevensOpslaanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GegevensOpslaanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GegevensOpslaanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.GegevensOpslaanBtn.Location = new System.Drawing.Point(336, 340);
            this.GegevensOpslaanBtn.Name = "GegevensOpslaanBtn";
            this.GegevensOpslaanBtn.Size = new System.Drawing.Size(122, 43);
            this.GegevensOpslaanBtn.TabIndex = 65;
            this.GegevensOpslaanBtn.Text = "Gegevens opslaan";
            this.GegevensOpslaanBtn.UseVisualStyleBackColor = false;
            this.GegevensOpslaanBtn.Click += new System.EventHandler(this.GegevensOpslaanBtn_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(6, 194);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(203, 19);
            this.materialLabel5.TabIndex = 67;
            this.materialLabel5.Text = "Mail verzenden vanuit email:";
            // 
            // MailVerzendenVanuitEmailTxtBx
            // 
            this.MailVerzendenVanuitEmailTxtBx.AllowPromptAsInput = true;
            this.MailVerzendenVanuitEmailTxtBx.AnimateReadOnly = false;
            this.MailVerzendenVanuitEmailTxtBx.AsciiOnly = false;
            this.MailVerzendenVanuitEmailTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MailVerzendenVanuitEmailTxtBx.BeepOnError = false;
            this.MailVerzendenVanuitEmailTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MailVerzendenVanuitEmailTxtBx.Depth = 0;
            this.MailVerzendenVanuitEmailTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MailVerzendenVanuitEmailTxtBx.HidePromptOnLeave = false;
            this.MailVerzendenVanuitEmailTxtBx.HideSelection = true;
            this.MailVerzendenVanuitEmailTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MailVerzendenVanuitEmailTxtBx.LeadingIcon = null;
            this.MailVerzendenVanuitEmailTxtBx.Location = new System.Drawing.Point(208, 179);
            this.MailVerzendenVanuitEmailTxtBx.Mask = "";
            this.MailVerzendenVanuitEmailTxtBx.MaxLength = 32767;
            this.MailVerzendenVanuitEmailTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.MailVerzendenVanuitEmailTxtBx.Name = "MailVerzendenVanuitEmailTxtBx";
            this.MailVerzendenVanuitEmailTxtBx.PasswordChar = '\0';
            this.MailVerzendenVanuitEmailTxtBx.PrefixSuffixText = null;
            this.MailVerzendenVanuitEmailTxtBx.PromptChar = '_';
            this.MailVerzendenVanuitEmailTxtBx.ReadOnly = false;
            this.MailVerzendenVanuitEmailTxtBx.RejectInputOnFirstFailure = false;
            this.MailVerzendenVanuitEmailTxtBx.ResetOnPrompt = true;
            this.MailVerzendenVanuitEmailTxtBx.ResetOnSpace = true;
            this.MailVerzendenVanuitEmailTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MailVerzendenVanuitEmailTxtBx.SelectedText = "";
            this.MailVerzendenVanuitEmailTxtBx.SelectionLength = 0;
            this.MailVerzendenVanuitEmailTxtBx.SelectionStart = 0;
            this.MailVerzendenVanuitEmailTxtBx.ShortcutsEnabled = true;
            this.MailVerzendenVanuitEmailTxtBx.Size = new System.Drawing.Size(250, 48);
            this.MailVerzendenVanuitEmailTxtBx.SkipLiterals = true;
            this.MailVerzendenVanuitEmailTxtBx.TabIndex = 66;
            this.MailVerzendenVanuitEmailTxtBx.TabStop = false;
            this.MailVerzendenVanuitEmailTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MailVerzendenVanuitEmailTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MailVerzendenVanuitEmailTxtBx.TrailingIcon = null;
            this.MailVerzendenVanuitEmailTxtBx.UseSystemPasswordChar = false;
            this.MailVerzendenVanuitEmailTxtBx.ValidatingType = null;
            // 
            // MailServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 388);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.MailVerzendenVanuitEmailTxtBx);
            this.Controls.Add(this.GegevensOpslaanBtn);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.WachtwoordTxtBx);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.GebruikersnaamTxtBx);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ServerPoortTxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ServerNaamTxtBx);
            this.Name = "MailServerForm";
            this.Text = "MailServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox ServerNaamTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox ServerPoortTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox GebruikersnaamTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMaskedTextBox WachtwoordTxtBx;
        private System.Windows.Forms.Button GegevensOpslaanBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMaskedTextBox MailVerzendenVanuitEmailTxtBx;
    }
}