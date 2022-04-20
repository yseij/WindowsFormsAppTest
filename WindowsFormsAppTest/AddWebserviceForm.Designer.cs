
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
            this.NewWebserviceNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.AddWebserviceBttn = new System.Windows.Forms.Button();
            this.SoapWebserviceChkBx = new MaterialSkin.Controls.MaterialCheckbox();
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
            // NewWebserviceNaamTxtBx
            // 
            this.NewWebserviceNaamTxtBx.AllowPromptAsInput = true;
            this.NewWebserviceNaamTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewWebserviceNaamTxtBx.AnimateReadOnly = false;
            this.NewWebserviceNaamTxtBx.AsciiOnly = false;
            this.NewWebserviceNaamTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewWebserviceNaamTxtBx.BeepOnError = false;
            this.NewWebserviceNaamTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewWebserviceNaamTxtBx.Depth = 0;
            this.NewWebserviceNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewWebserviceNaamTxtBx.HidePromptOnLeave = false;
            this.NewWebserviceNaamTxtBx.HideSelection = true;
            this.NewWebserviceNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewWebserviceNaamTxtBx.LeadingIcon = null;
            this.NewWebserviceNaamTxtBx.Location = new System.Drawing.Point(60, 67);
            this.NewWebserviceNaamTxtBx.Mask = "";
            this.NewWebserviceNaamTxtBx.MaxLength = 32767;
            this.NewWebserviceNaamTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.NewWebserviceNaamTxtBx.Name = "NewWebserviceNaamTxtBx";
            this.NewWebserviceNaamTxtBx.PasswordChar = '\0';
            this.NewWebserviceNaamTxtBx.PrefixSuffixText = null;
            this.NewWebserviceNaamTxtBx.PromptChar = '_';
            this.NewWebserviceNaamTxtBx.ReadOnly = false;
            this.NewWebserviceNaamTxtBx.RejectInputOnFirstFailure = false;
            this.NewWebserviceNaamTxtBx.ResetOnPrompt = true;
            this.NewWebserviceNaamTxtBx.ResetOnSpace = true;
            this.NewWebserviceNaamTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewWebserviceNaamTxtBx.SelectedText = "";
            this.NewWebserviceNaamTxtBx.SelectionLength = 0;
            this.NewWebserviceNaamTxtBx.SelectionStart = 0;
            this.NewWebserviceNaamTxtBx.ShortcutsEnabled = true;
            this.NewWebserviceNaamTxtBx.Size = new System.Drawing.Size(354, 48);
            this.NewWebserviceNaamTxtBx.SkipLiterals = true;
            this.NewWebserviceNaamTxtBx.TabIndex = 5;
            this.NewWebserviceNaamTxtBx.TabStop = false;
            this.NewWebserviceNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewWebserviceNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NewWebserviceNaamTxtBx.TrailingIcon = null;
            this.NewWebserviceNaamTxtBx.UseSystemPasswordChar = false;
            this.NewWebserviceNaamTxtBx.ValidatingType = null;
            this.NewWebserviceNaamTxtBx.TextChanged += new System.EventHandler(this.NewKlantNaamTxtBx_TextChanged);
            // 
            // AddWebserviceBttn
            // 
            this.AddWebserviceBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddWebserviceBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddWebserviceBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWebserviceBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWebserviceBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddWebserviceBttn.Location = new System.Drawing.Point(223, 144);
            this.AddWebserviceBttn.MinimumSize = new System.Drawing.Size(191, 43);
            this.AddWebserviceBttn.Name = "AddWebserviceBttn";
            this.AddWebserviceBttn.Size = new System.Drawing.Size(191, 43);
            this.AddWebserviceBttn.TabIndex = 29;
            this.AddWebserviceBttn.Text = "WEBSERVICE TOEVOEGEN";
            this.AddWebserviceBttn.UseVisualStyleBackColor = false;
            this.AddWebserviceBttn.Click += new System.EventHandler(this.AddWebserviceBttn_Click);
            // 
            // SoapWebserviceChkBx
            // 
            this.SoapWebserviceChkBx.AutoSize = true;
            this.SoapWebserviceChkBx.Depth = 0;
            this.SoapWebserviceChkBx.Location = new System.Drawing.Point(60, 118);
            this.SoapWebserviceChkBx.Margin = new System.Windows.Forms.Padding(0);
            this.SoapWebserviceChkBx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SoapWebserviceChkBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.SoapWebserviceChkBx.Name = "SoapWebserviceChkBx";
            this.SoapWebserviceChkBx.ReadOnly = false;
            this.SoapWebserviceChkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SoapWebserviceChkBx.Ripple = true;
            this.SoapWebserviceChkBx.Size = new System.Drawing.Size(154, 37);
            this.SoapWebserviceChkBx.TabIndex = 30;
            this.SoapWebserviceChkBx.Text = "Soap webservice";
            this.SoapWebserviceChkBx.UseVisualStyleBackColor = true;
            this.SoapWebserviceChkBx.CheckedChanged += new System.EventHandler(this.SoapWebserviceChkBx_CheckedChanged);
            // 
            // AddWebserviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 193);
            this.Controls.Add(this.SoapWebserviceChkBx);
            this.Controls.Add(this.AddWebserviceBttn);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.NewWebserviceNaamTxtBx);
            this.MinimumSize = new System.Drawing.Size(424, 193);
            this.Name = "AddWebserviceForm";
            this.Text = "Webservice toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblName;
        private MaterialSkin.Controls.MaterialMaskedTextBox NewWebserviceNaamTxtBx;
        private System.Windows.Forms.Button AddWebserviceBttn;
        private MaterialSkin.Controls.MaterialCheckbox SoapWebserviceChkBx;
    }
}