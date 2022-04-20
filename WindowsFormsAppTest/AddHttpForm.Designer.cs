
namespace WindowsFormsAppTest
{
    partial class AddHttpForm
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
            this.AddHttpBttn = new System.Windows.Forms.Button();
            this.LblName = new MaterialSkin.Controls.MaterialLabel();
            this.NewHttpNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // AddHttpBttn
            // 
            this.AddHttpBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHttpBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddHttpBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHttpBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHttpBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddHttpBttn.Location = new System.Drawing.Point(173, 121);
            this.AddHttpBttn.Name = "AddHttpBttn";
            this.AddHttpBttn.Size = new System.Drawing.Size(140, 43);
            this.AddHttpBttn.TabIndex = 31;
            this.AddHttpBttn.Text = "HTTP TOEVOEGEN";
            this.AddHttpBttn.UseVisualStyleBackColor = false;
            this.AddHttpBttn.Click += new System.EventHandler(this.AddHttpBttn_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Depth = 0;
            this.LblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblName.Location = new System.Drawing.Point(5, 71);
            this.LblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(48, 19);
            this.LblName.TabIndex = 29;
            this.LblName.Text = "Naam:";
            // 
            // NewHttpNaamTxtBx
            // 
            this.NewHttpNaamTxtBx.AllowPromptAsInput = true;
            this.NewHttpNaamTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewHttpNaamTxtBx.AnimateReadOnly = false;
            this.NewHttpNaamTxtBx.AsciiOnly = false;
            this.NewHttpNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewHttpNaamTxtBx.BeepOnError = false;
            this.NewHttpNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewHttpNaamTxtBx.Depth = 0;
            this.NewHttpNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewHttpNaamTxtBx.HidePromptOnLeave = false;
            this.NewHttpNaamTxtBx.HideSelection = true;
            this.NewHttpNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewHttpNaamTxtBx.LeadingIcon = null;
            this.NewHttpNaamTxtBx.Location = new System.Drawing.Point(59, 67);
            this.NewHttpNaamTxtBx.Mask = "";
            this.NewHttpNaamTxtBx.MaxLength = 32767;
            this.NewHttpNaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.NewHttpNaamTxtBx.Name = "NewHttpNaamTxtBx";
            this.NewHttpNaamTxtBx.PasswordChar = '\0';
            this.NewHttpNaamTxtBx.PrefixSuffixText = null;
            this.NewHttpNaamTxtBx.PromptChar = '_';
            this.NewHttpNaamTxtBx.ReadOnly = false;
            this.NewHttpNaamTxtBx.RejectInputOnFirstFailure = false;
            this.NewHttpNaamTxtBx.ResetOnPrompt = true;
            this.NewHttpNaamTxtBx.ResetOnSpace = true;
            this.NewHttpNaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewHttpNaamTxtBx.SelectedText = "";
            this.NewHttpNaamTxtBx.SelectionLength = 0;
            this.NewHttpNaamTxtBx.SelectionStart = 0;
            this.NewHttpNaamTxtBx.ShortcutsEnabled = true;
            this.NewHttpNaamTxtBx.Size = new System.Drawing.Size(254, 48);
            this.NewHttpNaamTxtBx.SkipLiterals = true;
            this.NewHttpNaamTxtBx.TabIndex = 30;
            this.NewHttpNaamTxtBx.TabStop = false;
            this.NewHttpNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewHttpNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewHttpNaamTxtBx.TrailingIcon = null;
            this.NewHttpNaamTxtBx.UseSystemPasswordChar = false;
            this.NewHttpNaamTxtBx.ValidatingType = null;
            this.NewHttpNaamTxtBx.TextChanged += new System.EventHandler(this.NewHttpNaamTxtBx_TextChanged);
            // 
            // AddHttpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 171);
            this.Controls.Add(this.AddHttpBttn);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.NewHttpNaamTxtBx);
            this.MinimumSize = new System.Drawing.Size(339, 171);
            this.Name = "AddHttpForm";
            this.Text = "Add Http";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddHttpBttn;
        private MaterialSkin.Controls.MaterialLabel LblName;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewHttpNaamTxtBx;
    }
}