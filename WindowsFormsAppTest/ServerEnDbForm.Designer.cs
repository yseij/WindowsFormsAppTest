
namespace WindowsFormsAppTest
{
    partial class ServerEnDbForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ServerNaamTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ServerKeuze = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.PlaatsDbOpslaanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Server naam:";
            // 
            // ServerNaamTxtBx
            // 
            this.ServerNaamTxtBx.AllowPromptAsInput = true;
            this.ServerNaamTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ServerNaamTxtBx.Location = new System.Drawing.Point(6, 90);
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
            this.ServerNaamTxtBx.Size = new System.Drawing.Size(369, 48);
            this.ServerNaamTxtBx.SkipLiterals = true;
            this.ServerNaamTxtBx.TabIndex = 1;
            this.ServerNaamTxtBx.TabStop = false;
            this.ServerNaamTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServerNaamTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ServerNaamTxtBx.TrailingIcon = null;
            this.ServerNaamTxtBx.UseSystemPasswordChar = false;
            this.ServerNaamTxtBx.ValidatingType = null;
            // 
            // ServerKeuze
            // 
            this.ServerKeuze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerKeuze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.ServerKeuze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerKeuze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerKeuze.ForeColor = System.Drawing.SystemColors.Control;
            this.ServerKeuze.Location = new System.Drawing.Point(279, 192);
            this.ServerKeuze.Name = "ServerKeuze";
            this.ServerKeuze.Size = new System.Drawing.Size(96, 43);
            this.ServerKeuze.TabIndex = 60;
            this.ServerKeuze.Text = "Opslaan";
            this.ServerKeuze.UseVisualStyleBackColor = false;
            this.ServerKeuze.Click += new System.EventHandler(this.ServerEnDatabase_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(181, 19);
            this.materialLabel2.TabIndex = 62;
            this.materialLabel2.Text = "Plaats opslaan database:";
            // 
            // PlaatsDbOpslaanBtn
            // 
            this.PlaatsDbOpslaanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PlaatsDbOpslaanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaatsDbOpslaanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaatsDbOpslaanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PlaatsDbOpslaanBtn.Location = new System.Drawing.Point(203, 143);
            this.PlaatsDbOpslaanBtn.Name = "PlaatsDbOpslaanBtn";
            this.PlaatsDbOpslaanBtn.Size = new System.Drawing.Size(172, 43);
            this.PlaatsDbOpslaanBtn.TabIndex = 63;
            this.PlaatsDbOpslaanBtn.Text = "Opslaan DB";
            this.PlaatsDbOpslaanBtn.UseVisualStyleBackColor = false;
            this.PlaatsDbOpslaanBtn.Click += new System.EventHandler(this.PlaatsDbOpslaanBtn_Click);
            // 
            // ServerEnDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.PlaatsDbOpslaanBtn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ServerKeuze);
            this.Controls.Add(this.ServerNaamTxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ServerEnDbForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox ServerNaamTxtBx;
        private System.Windows.Forms.Button ServerKeuze;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button PlaatsDbOpslaanBtn;
    }
}