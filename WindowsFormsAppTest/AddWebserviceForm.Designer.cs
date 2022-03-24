
namespace WindowsFormsAppTest
{
    partial class AddWebserviceForm
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
            this.LblName = new MaterialSkin.Controls.MaterialLabel();
            this.NewKlantNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.AddKlantBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Depth = 0;
            this.LblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblName.Location = new System.Drawing.Point(6, 71);
            this.LblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(48, 19);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Naam:";
            // 
            // NewKlantNaamTxtBx
            // 
            this.NewKlantNaamTxtBx.AllowPromptAsInput = true;
            this.NewKlantNaamTxtBx.AnimateReadOnly = false;
            this.NewKlantNaamTxtBx.AsciiOnly = false;
            this.NewKlantNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewKlantNaamTxtBx.BeepOnError = false;
            this.NewKlantNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewKlantNaamTxtBx.Depth = 0;
            this.NewKlantNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewKlantNaamTxtBx.HidePromptOnLeave = false;
            this.NewKlantNaamTxtBx.HideSelection = true;
            this.NewKlantNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewKlantNaamTxtBx.LeadingIcon = null;
            this.NewKlantNaamTxtBx.Location = new System.Drawing.Point(60, 67);
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
            this.NewKlantNaamTxtBx.Size = new System.Drawing.Size(383, 48);
            this.NewKlantNaamTxtBx.SkipLiterals = true;
            this.NewKlantNaamTxtBx.TabIndex = 5;
            this.NewKlantNaamTxtBx.TabStop = false;
            this.NewKlantNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewKlantNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewKlantNaamTxtBx.TrailingIcon = null;
            this.NewKlantNaamTxtBx.UseSystemPasswordChar = false;
            this.NewKlantNaamTxtBx.ValidatingType = null;
            this.NewKlantNaamTxtBx.TextChanged += new System.EventHandler(this.NewKlantNaamTxtBx_TextChanged);
            // 
            // AddKlantBttn
            // 
            this.AddKlantBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddKlantBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddKlantBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddKlantBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddKlantBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddKlantBttn.Location = new System.Drawing.Point(252, 121);
            this.AddKlantBttn.MinimumSize = new System.Drawing.Size(191, 43);
            this.AddKlantBttn.Name = "AddKlantBttn";
            this.AddKlantBttn.Size = new System.Drawing.Size(191, 43);
            this.AddKlantBttn.TabIndex = 29;
            this.AddKlantBttn.Text = "WEBSERVICE TOEVOEGEN";
            this.AddKlantBttn.UseVisualStyleBackColor = false;
            this.AddKlantBttn.Click += new System.EventHandler(this.AddWebserviceBttn_Click);
            // 
            // AddWebserviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 169);
            this.Controls.Add(this.AddKlantBttn);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.NewKlantNaamTxtBx);
            this.Name = "AddWebserviceForm";
            this.Text = "AddWebserviceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblName;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewKlantNaamTxtBx;
        private System.Windows.Forms.Button AddKlantBttn;
    }
}