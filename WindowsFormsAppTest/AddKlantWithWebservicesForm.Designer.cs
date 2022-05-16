
namespace WindowsFormsAppTest
{
    partial class AddKlantWithWebservicesForm
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
            this.AddAndUpdateKlantBttn = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BasisUrl1TxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BasisUrl2TxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TableLayoutWebservice = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.LblUrlsByKlant = new MaterialSkin.Controls.MaterialLabel();
            this.UrlsGenererenBtn = new System.Windows.Forms.Button();
            this.UrlsLstBx = new System.Windows.Forms.ListBox();
            this.AnnulerenKlantBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.NewKlantNaamTxtBx.ErrorMessage = "test";
            this.NewKlantNaamTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewKlantNaamTxtBx.HidePromptOnLeave = false;
            this.NewKlantNaamTxtBx.HideSelection = true;
            this.NewKlantNaamTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NewKlantNaamTxtBx.LeadingIcon = null;
            this.NewKlantNaamTxtBx.Location = new System.Drawing.Point(91, 71);
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
            this.NewKlantNaamTxtBx.Size = new System.Drawing.Size(308, 48);
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
            this.LblName.Location = new System.Drawing.Point(6, 75);
            this.LblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(48, 19);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Naam:";
            // 
            // AddAndUpdateKlantBttn
            // 
            this.AddAndUpdateKlantBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddAndUpdateKlantBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAndUpdateKlantBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAndUpdateKlantBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddAndUpdateKlantBttn.Location = new System.Drawing.Point(309, 291);
            this.AddAndUpdateKlantBttn.Name = "AddAndUpdateKlantBttn";
            this.AddAndUpdateKlantBttn.Size = new System.Drawing.Size(90, 43);
            this.AddAndUpdateKlantBttn.TabIndex = 28;
            this.AddAndUpdateKlantBttn.Text = "OK";
            this.AddAndUpdateKlantBttn.UseVisualStyleBackColor = false;
            this.AddAndUpdateKlantBttn.Click += new System.EventHandler(this.AddKlantBttn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 162);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Basis url 1:";
            // 
            // BasisUrl1TxtBx
            // 
            this.BasisUrl1TxtBx.AllowPromptAsInput = true;
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
            this.BasisUrl1TxtBx.Location = new System.Drawing.Point(91, 158);
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
            this.BasisUrl1TxtBx.Size = new System.Drawing.Size(308, 48);
            this.BasisUrl1TxtBx.SkipLiterals = true;
            this.BasisUrl1TxtBx.TabIndex = 30;
            this.BasisUrl1TxtBx.TabStop = false;
            this.BasisUrl1TxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BasisUrl1TxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisUrl1TxtBx.TrailingIcon = null;
            this.BasisUrl1TxtBx.UseSystemPasswordChar = false;
            this.BasisUrl1TxtBx.ValidatingType = null;
            this.BasisUrl1TxtBx.TextChanged += new System.EventHandler(this.BasisUrl1TxtBx_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 241);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Basis url 2:";
            // 
            // BasisUrl2TxtBx
            // 
            this.BasisUrl2TxtBx.AllowPromptAsInput = true;
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
            this.BasisUrl2TxtBx.Location = new System.Drawing.Point(91, 237);
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
            this.BasisUrl2TxtBx.Size = new System.Drawing.Size(308, 48);
            this.BasisUrl2TxtBx.SkipLiterals = true;
            this.BasisUrl2TxtBx.TabIndex = 32;
            this.BasisUrl2TxtBx.TabStop = false;
            this.BasisUrl2TxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BasisUrl2TxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BasisUrl2TxtBx.TrailingIcon = null;
            this.BasisUrl2TxtBx.UseSystemPasswordChar = false;
            this.BasisUrl2TxtBx.ValidatingType = null;
            this.BasisUrl2TxtBx.TextChanged += new System.EventHandler(this.BasisUrl2TxtBx_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 256);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "(eventueel)";
            // 
            // TableLayoutWebservice
            // 
            this.TableLayoutWebservice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutWebservice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TableLayoutWebservice.ColumnCount = 3;
            this.TableLayoutWebservice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutWebservice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutWebservice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutWebservice.Location = new System.Drawing.Point(426, 98);
            this.TableLayoutWebservice.Name = "TableLayoutWebservice";
            this.TableLayoutWebservice.RowCount = 2;
            this.TableLayoutWebservice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutWebservice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutWebservice.Size = new System.Drawing.Size(493, 236);
            this.TableLayoutWebservice.TabIndex = 34;
            // 
            // TableLayoutHeader
            // 
            this.TableLayoutHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TableLayoutHeader.ColumnCount = 3;
            this.TableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutHeader.Location = new System.Drawing.Point(426, 71);
            this.TableLayoutHeader.Name = "TableLayoutHeader";
            this.TableLayoutHeader.RowCount = 1;
            this.TableLayoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutHeader.Size = new System.Drawing.Size(493, 21);
            this.TableLayoutHeader.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(9, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(910, 2);
            this.label3.TabIndex = 81;
            // 
            // LblUrlsByKlant
            // 
            this.LblUrlsByKlant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUrlsByKlant.AutoSize = true;
            this.LblUrlsByKlant.Depth = 0;
            this.LblUrlsByKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblUrlsByKlant.Location = new System.Drawing.Point(6, 339);
            this.LblUrlsByKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrlsByKlant.Name = "LblUrlsByKlant";
            this.LblUrlsByKlant.Size = new System.Drawing.Size(127, 19);
            this.LblUrlsByKlant.TabIndex = 82;
            this.LblUrlsByKlant.Text = "Gegenereerde urls";
            // 
            // UrlsGenererenBtn
            // 
            this.UrlsGenererenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.UrlsGenererenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrlsGenererenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlsGenererenBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UrlsGenererenBtn.Location = new System.Drawing.Point(9, 291);
            this.UrlsGenererenBtn.Name = "UrlsGenererenBtn";
            this.UrlsGenererenBtn.Size = new System.Drawing.Size(103, 43);
            this.UrlsGenererenBtn.TabIndex = 83;
            this.UrlsGenererenBtn.Text = "Urls genereren";
            this.UrlsGenererenBtn.UseVisualStyleBackColor = false;
            this.UrlsGenererenBtn.Click += new System.EventHandler(this.UrlsGenererenBtn_Click);
            // 
            // UrlsLstBx
            // 
            this.UrlsLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlsLstBx.FormattingEnabled = true;
            this.UrlsLstBx.Location = new System.Drawing.Point(7, 358);
            this.UrlsLstBx.Name = "UrlsLstBx";
            this.UrlsLstBx.Size = new System.Drawing.Size(912, 212);
            this.UrlsLstBx.TabIndex = 84;
            // 
            // AnnulerenKlantBttn
            // 
            this.AnnulerenKlantBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AnnulerenKlantBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnulerenKlantBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerenKlantBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.AnnulerenKlantBttn.Location = new System.Drawing.Point(212, 291);
            this.AnnulerenKlantBttn.Name = "AnnulerenKlantBttn";
            this.AnnulerenKlantBttn.Size = new System.Drawing.Size(91, 43);
            this.AnnulerenKlantBttn.TabIndex = 85;
            this.AnnulerenKlantBttn.Text = "ANNUlEREN";
            this.AnnulerenKlantBttn.UseVisualStyleBackColor = false;
            this.AnnulerenKlantBttn.Click += new System.EventHandler(this.AnnulerenKlantBttn_Click);
            // 
            // AddKlantWithWebservicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 576);
            this.Controls.Add(this.AnnulerenKlantBttn);
            this.Controls.Add(this.UrlsLstBx);
            this.Controls.Add(this.UrlsGenererenBtn);
            this.Controls.Add(this.LblUrlsByKlant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TableLayoutHeader);
            this.Controls.Add(this.TableLayoutWebservice);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.BasisUrl2TxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BasisUrl1TxtBx);
            this.Controls.Add(this.AddAndUpdateKlantBttn);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.NewKlantNaamTxtBx);
            this.MinimumSize = new System.Drawing.Size(925, 576);
            this.Name = "AddKlantWithWebservicesForm";
            this.Text = "Klant toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialMaskedTextBox NewKlantNaamTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblName;
        private System.Windows.Forms.Button AddAndUpdateKlantBttn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox BasisUrl1TxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox BasisUrl2TxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TableLayoutPanel TableLayoutWebservice;
        private System.Windows.Forms.TableLayoutPanel TableLayoutHeader;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialLabel LblUrlsByKlant;
        private System.Windows.Forms.Button UrlsGenererenBtn;
        private System.Windows.Forms.ListBox UrlsLstBx;
        private System.Windows.Forms.Button AnnulerenKlantBttn;
    }
}