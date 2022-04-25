
namespace WindowsFormsAppTest
{
    partial class UserForm
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
            this.UserEmailTxtBx = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.GegevensOpslaanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserEmailTxtBx
            // 
            this.UserEmailTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserEmailTxtBx.AnimateReadOnly = false;
            this.UserEmailTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserEmailTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserEmailTxtBx.Depth = 0;
            this.UserEmailTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserEmailTxtBx.HideSelection = true;
            this.UserEmailTxtBx.LeadingIcon = null;
            this.UserEmailTxtBx.Location = new System.Drawing.Point(57, 67);
            this.UserEmailTxtBx.MaxLength = 32767;
            this.UserEmailTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.UserEmailTxtBx.Name = "UserEmailTxtBx";
            this.UserEmailTxtBx.PasswordChar = '\0';
            this.UserEmailTxtBx.PrefixSuffixText = null;
            this.UserEmailTxtBx.ReadOnly = false;
            this.UserEmailTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserEmailTxtBx.SelectedText = "";
            this.UserEmailTxtBx.SelectionLength = 0;
            this.UserEmailTxtBx.SelectionStart = 0;
            this.UserEmailTxtBx.ShortcutsEnabled = true;
            this.UserEmailTxtBx.Size = new System.Drawing.Size(258, 48);
            this.UserEmailTxtBx.TabIndex = 5;
            this.UserEmailTxtBx.TabStop = false;
            this.UserEmailTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserEmailTxtBx.TrailingIcon = null;
            this.UserEmailTxtBx.UseSystemPasswordChar = false;
            this.UserEmailTxtBx.TextChanged += new System.EventHandler(this.UserEmailTxtBx_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 79);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(45, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Email:";
            // 
            // GegevensOpslaanBtn
            // 
            this.GegevensOpslaanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GegevensOpslaanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.GegevensOpslaanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GegevensOpslaanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GegevensOpslaanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.GegevensOpslaanBtn.Location = new System.Drawing.Point(193, 121);
            this.GegevensOpslaanBtn.Name = "GegevensOpslaanBtn";
            this.GegevensOpslaanBtn.Size = new System.Drawing.Size(122, 43);
            this.GegevensOpslaanBtn.TabIndex = 64;
            this.GegevensOpslaanBtn.Text = "Gegevens opslaan";
            this.GegevensOpslaanBtn.UseVisualStyleBackColor = false;
            this.GegevensOpslaanBtn.Click += new System.EventHandler(this.GegevensOpslaanBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 169);
            this.Controls.Add(this.GegevensOpslaanBtn);
            this.Controls.Add(this.UserEmailTxtBx);
            this.Controls.Add(this.materialLabel2);
            this.MinimumSize = new System.Drawing.Size(313, 169);
            this.Name = "UserForm";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 UserEmailTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button GegevensOpslaanBtn;
    }
}