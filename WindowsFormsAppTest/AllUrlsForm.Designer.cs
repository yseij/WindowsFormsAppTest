
namespace WindowsFormsAppTest
{
    partial class AllUrlsForm
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
            this.LblBewerken = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SecurityIdTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.UrlTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblUrl = new MaterialSkin.Controls.MaterialLabel();
            this.WebServiceCmbx = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.AllUrlsLstBx = new System.Windows.Forms.ListBox();
            this.DeleteUrlBttn = new MaterialSkin.Controls.MaterialButton();
            this.AddUrlBtn = new MaterialSkin.Controls.MaterialButton();
            this.PasUrlAanBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // LblBewerken
            // 
            this.LblBewerken.AutoSize = true;
            this.LblBewerken.Depth = 0;
            this.LblBewerken.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBewerken.Location = new System.Drawing.Point(411, 68);
            this.LblBewerken.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBewerken.Name = "LblBewerken";
            this.LblBewerken.Size = new System.Drawing.Size(91, 19);
            this.LblBewerken.TabIndex = 40;
            this.LblBewerken.Text = "Url bewerken";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(411, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "SecurityID:";
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.AnimateReadOnly = false;
            this.SecurityIdTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecurityIdTxtBx.Depth = 0;
            this.SecurityIdTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SecurityIdTxtBx.LeadingIcon = null;
            this.SecurityIdTxtBx.Location = new System.Drawing.Point(507, 88);
            this.SecurityIdTxtBx.MaxLength = 50;
            this.SecurityIdTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.SecurityIdTxtBx.Multiline = false;
            this.SecurityIdTxtBx.Name = "SecurityIdTxtBx";
            this.SecurityIdTxtBx.Size = new System.Drawing.Size(282, 50);
            this.SecurityIdTxtBx.TabIndex = 43;
            this.SecurityIdTxtBx.Text = "";
            this.SecurityIdTxtBx.TrailingIcon = null;
            this.SecurityIdTxtBx.TextChanged += new System.EventHandler(this.SecurityIdTxtBx_TextChanged);
            // 
            // UrlTxtBx
            // 
            this.UrlTxtBx.AnimateReadOnly = false;
            this.UrlTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrlTxtBx.Depth = 0;
            this.UrlTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UrlTxtBx.LeadingIcon = null;
            this.UrlTxtBx.Location = new System.Drawing.Point(507, 144);
            this.UrlTxtBx.MaxLength = 50;
            this.UrlTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.UrlTxtBx.Multiline = false;
            this.UrlTxtBx.Name = "UrlTxtBx";
            this.UrlTxtBx.Size = new System.Drawing.Size(282, 50);
            this.UrlTxtBx.TabIndex = 45;
            this.UrlTxtBx.Text = "";
            this.UrlTxtBx.TrailingIcon = null;
            this.UrlTxtBx.TextChanged += new System.EventHandler(this.UrlTxtBx_TextChanged);
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Depth = 0;
            this.LblUrl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblUrl.Location = new System.Drawing.Point(411, 150);
            this.LblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(24, 19);
            this.LblUrl.TabIndex = 44;
            this.LblUrl.Text = "Url:";
            // 
            // WebServiceCmbx
            // 
            this.WebServiceCmbx.AutoResize = false;
            this.WebServiceCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WebServiceCmbx.Depth = 0;
            this.WebServiceCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WebServiceCmbx.DropDownHeight = 174;
            this.WebServiceCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebServiceCmbx.DropDownWidth = 121;
            this.WebServiceCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WebServiceCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WebServiceCmbx.FormattingEnabled = true;
            this.WebServiceCmbx.IntegralHeight = false;
            this.WebServiceCmbx.ItemHeight = 43;
            this.WebServiceCmbx.Location = new System.Drawing.Point(507, 200);
            this.WebServiceCmbx.MaxDropDownItems = 4;
            this.WebServiceCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebServiceCmbx.Name = "WebServiceCmbx";
            this.WebServiceCmbx.Size = new System.Drawing.Size(282, 49);
            this.WebServiceCmbx.StartIndex = 0;
            this.WebServiceCmbx.TabIndex = 46;
            this.WebServiceCmbx.SelectedIndexChanged += new System.EventHandler(this.WebServiceCmbx_SelectedIndexChanged);
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(507, 255);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(282, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 47;
            this.materialComboBox2.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(411, 202);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 48;
            this.materialLabel3.Text = "Webservice:";
            // 
            // LblKlant
            // 
            this.LblKlant.AutoSize = true;
            this.LblKlant.Depth = 0;
            this.LblKlant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblKlant.Location = new System.Drawing.Point(411, 257);
            this.LblKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblKlant.Name = "LblKlant";
            this.LblKlant.Size = new System.Drawing.Size(38, 19);
            this.LblKlant.TabIndex = 49;
            this.LblKlant.Text = "Klant";
            // 
            // AllUrlsLstBx
            // 
            this.AllUrlsLstBx.FormattingEnabled = true;
            this.AllUrlsLstBx.Location = new System.Drawing.Point(6, 67);
            this.AllUrlsLstBx.Name = "AllUrlsLstBx";
            this.AllUrlsLstBx.Size = new System.Drawing.Size(399, 342);
            this.AllUrlsLstBx.TabIndex = 50;
            this.AllUrlsLstBx.SelectedIndexChanged += new System.EventHandler(this.AllUrlsLstBx_SelectedIndexChanged);
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteUrlBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteUrlBttn.Depth = 0;
            this.DeleteUrlBttn.HighEmphasis = true;
            this.DeleteUrlBttn.Icon = null;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(507, 373);
            this.DeleteUrlBttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteUrlBttn.MaximumSize = new System.Drawing.Size(100, 0);
            this.DeleteUrlBttn.MinimumSize = new System.Drawing.Size(100, 0);
            this.DeleteUrlBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteUrlBttn.Size = new System.Drawing.Size(100, 36);
            this.DeleteUrlBttn.TabIndex = 51;
            this.DeleteUrlBttn.Text = "Url verwijderen";
            this.DeleteUrlBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteUrlBttn.UseAccentColor = false;
            this.DeleteUrlBttn.UseVisualStyleBackColor = true;
            this.DeleteUrlBttn.Click += new System.EventHandler(this.DeleteUrlBttn_Click);
            // 
            // AddUrlBtn
            // 
            this.AddUrlBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddUrlBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddUrlBtn.Depth = 0;
            this.AddUrlBtn.HighEmphasis = true;
            this.AddUrlBtn.Icon = null;
            this.AddUrlBtn.Location = new System.Drawing.Point(689, 373);
            this.AddUrlBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddUrlBtn.MaximumSize = new System.Drawing.Size(100, 0);
            this.AddUrlBtn.MinimumSize = new System.Drawing.Size(100, 0);
            this.AddUrlBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddUrlBtn.Name = "AddUrlBtn";
            this.AddUrlBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddUrlBtn.Size = new System.Drawing.Size(100, 36);
            this.AddUrlBtn.TabIndex = 52;
            this.AddUrlBtn.Text = "Url toevoegen";
            this.AddUrlBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddUrlBtn.UseAccentColor = false;
            this.AddUrlBtn.UseVisualStyleBackColor = true;
            this.AddUrlBtn.Click += new System.EventHandler(this.AddUrlBtn_Click);
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasUrlAanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PasUrlAanBtn.Depth = 0;
            this.PasUrlAanBtn.HighEmphasis = true;
            this.PasUrlAanBtn.Icon = null;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(507, 313);
            this.PasUrlAanBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PasUrlAanBtn.MaximumSize = new System.Drawing.Size(282, 0);
            this.PasUrlAanBtn.MinimumSize = new System.Drawing.Size(282, 0);
            this.PasUrlAanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PasUrlAanBtn.Size = new System.Drawing.Size(282, 36);
            this.PasUrlAanBtn.TabIndex = 53;
            this.PasUrlAanBtn.Text = "Pas gegevens aan";
            this.PasUrlAanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PasUrlAanBtn.UseAccentColor = false;
            this.PasUrlAanBtn.UseVisualStyleBackColor = true;
            this.PasUrlAanBtn.Click += new System.EventHandler(this.PasUrlAanBtn_Click);
            // 
            // AllUrlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.PasUrlAanBtn);
            this.Controls.Add(this.AddUrlBtn);
            this.Controls.Add(this.DeleteUrlBttn);
            this.Controls.Add(this.AllUrlsLstBx);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialComboBox2);
            this.Controls.Add(this.WebServiceCmbx);
            this.Controls.Add(this.UrlTxtBx);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.SecurityIdTxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.LblBewerken);
            this.Name = "AllUrlsForm";
            this.Text = "Urls beheren";
            this.Load += new System.EventHandler(this.AllUrlsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LblBewerken;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox SecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialTextBox UrlTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private MaterialSkin.Controls.MaterialComboBox WebServiceCmbx;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private System.Windows.Forms.ListBox AllUrlsLstBx;
        private MaterialSkin.Controls.MaterialButton DeleteUrlBttn;
        private MaterialSkin.Controls.MaterialButton AddUrlBtn;
        private MaterialSkin.Controls.MaterialButton PasUrlAanBtn;
    }
}