
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
            this.GegevensOpslaanBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // UserEmailTxtBx
            // 
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
            this.UserEmailTxtBx.Size = new System.Drawing.Size(250, 48);
            this.UserEmailTxtBx.TabIndex = 5;
            this.UserEmailTxtBx.TabStop = false;
            this.UserEmailTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserEmailTxtBx.TrailingIcon = null;
            this.UserEmailTxtBx.UseSystemPasswordChar = false;
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
            this.GegevensOpslaanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GegevensOpslaanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GegevensOpslaanBtn.Depth = 0;
            this.GegevensOpslaanBtn.HighEmphasis = true;
            this.GegevensOpslaanBtn.Icon = null;
            this.GegevensOpslaanBtn.Location = new System.Drawing.Point(141, 124);
            this.GegevensOpslaanBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GegevensOpslaanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GegevensOpslaanBtn.Name = "GegevensOpslaanBtn";
            this.GegevensOpslaanBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GegevensOpslaanBtn.Size = new System.Drawing.Size(166, 36);
            this.GegevensOpslaanBtn.TabIndex = 6;
            this.GegevensOpslaanBtn.Text = "Gegevens opslaan";
            this.GegevensOpslaanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GegevensOpslaanBtn.UseAccentColor = false;
            this.GegevensOpslaanBtn.UseVisualStyleBackColor = true;
            this.GegevensOpslaanBtn.Click += new System.EventHandler(this.GegevensOpslaanBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 169);
            this.Controls.Add(this.GegevensOpslaanBtn);
            this.Controls.Add(this.UserEmailTxtBx);
            this.Controls.Add(this.materialLabel2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 UserEmailTxtBx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton GegevensOpslaanBtn;
    }
}