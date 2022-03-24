
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.LblKlant = new MaterialSkin.Controls.MaterialLabel();
            this.AllUrlsKrMaterialLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.WebserviceKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.KlantKrMaterialCmbx = new WindowsFormsAppTest.KrMaterialCombobox();
            this.DeleteUrlBttn = new System.Windows.Forms.Button();
            this.AddUrlBtn = new System.Windows.Forms.Button();
            this.PasUrlAanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblBewerken
            // 
            this.LblBewerken.AutoSize = true;
            this.LblBewerken.Depth = 0;
            this.LblBewerken.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBewerken.Location = new System.Drawing.Point(692, 70);
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
            this.materialLabel1.Location = new System.Drawing.Point(692, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "SecurityID:";
            // 
            // SecurityIdTxtBx
            // 
            this.SecurityIdTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityIdTxtBx.AnimateReadOnly = false;
            this.SecurityIdTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecurityIdTxtBx.Depth = 0;
            this.SecurityIdTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SecurityIdTxtBx.LeadingIcon = null;
            this.SecurityIdTxtBx.Location = new System.Drawing.Point(788, 90);
            this.SecurityIdTxtBx.MaxLength = 50;
            this.SecurityIdTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.SecurityIdTxtBx.Multiline = false;
            this.SecurityIdTxtBx.Name = "SecurityIdTxtBx";
            this.SecurityIdTxtBx.Size = new System.Drawing.Size(400, 50);
            this.SecurityIdTxtBx.TabIndex = 43;
            this.SecurityIdTxtBx.Text = "";
            this.SecurityIdTxtBx.TrailingIcon = null;
            this.SecurityIdTxtBx.TextChanged += new System.EventHandler(this.SecurityIdTxtBx_TextChanged);
            // 
            // UrlTxtBx
            // 
            this.UrlTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTxtBx.AnimateReadOnly = false;
            this.UrlTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrlTxtBx.Depth = 0;
            this.UrlTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UrlTxtBx.LeadingIcon = null;
            this.UrlTxtBx.Location = new System.Drawing.Point(788, 146);
            this.UrlTxtBx.MaxLength = 50;
            this.UrlTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.UrlTxtBx.Multiline = false;
            this.UrlTxtBx.Name = "UrlTxtBx";
            this.UrlTxtBx.Size = new System.Drawing.Size(400, 50);
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
            this.LblUrl.Location = new System.Drawing.Point(692, 152);
            this.LblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(24, 19);
            this.LblUrl.TabIndex = 44;
            this.LblUrl.Text = "Url:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(692, 204);
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
            this.LblKlant.Location = new System.Drawing.Point(692, 259);
            this.LblKlant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblKlant.Name = "LblKlant";
            this.LblKlant.Size = new System.Drawing.Size(38, 19);
            this.LblKlant.TabIndex = 49;
            this.LblKlant.Text = "Klant";
            // 
            // AllUrlsKrMaterialLstBx
            // 
            this.AllUrlsKrMaterialLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllUrlsKrMaterialLstBx.BackColor = System.Drawing.Color.White;
            this.AllUrlsKrMaterialLstBx.BorderColor = System.Drawing.Color.LightGray;
            this.AllUrlsKrMaterialLstBx.Depth = 0;
            this.AllUrlsKrMaterialLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllUrlsKrMaterialLstBx.Location = new System.Drawing.Point(6, 70);
            this.AllUrlsKrMaterialLstBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllUrlsKrMaterialLstBx.Name = "AllUrlsKrMaterialLstBx";
            this.AllUrlsKrMaterialLstBx.SelectedIndex = -1;
            this.AllUrlsKrMaterialLstBx.SelectedItem = null;
            this.AllUrlsKrMaterialLstBx.Size = new System.Drawing.Size(680, 289);
            this.AllUrlsKrMaterialLstBx.TabIndex = 54;
            this.AllUrlsKrMaterialLstBx.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.AllUrlsKrMaterialLstBx_SelectedIndexChanged);
            // 
            // WebserviceKrMaterialCmbx
            // 
            this.WebserviceKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebserviceKrMaterialCmbx.AutoResize = false;
            this.WebserviceKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WebserviceKrMaterialCmbx.Depth = 0;
            this.WebserviceKrMaterialCmbx.DisplayMember = "Name";
            this.WebserviceKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WebserviceKrMaterialCmbx.DropDownHeight = 174;
            this.WebserviceKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebserviceKrMaterialCmbx.DropDownWidth = 121;
            this.WebserviceKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WebserviceKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WebserviceKrMaterialCmbx.FormattingEnabled = true;
            this.WebserviceKrMaterialCmbx.IntegralHeight = false;
            this.WebserviceKrMaterialCmbx.ItemHeight = 43;
            this.WebserviceKrMaterialCmbx.Location = new System.Drawing.Point(788, 203);
            this.WebserviceKrMaterialCmbx.MaxDropDownItems = 4;
            this.WebserviceKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.WebserviceKrMaterialCmbx.Name = "WebserviceKrMaterialCmbx";
            this.WebserviceKrMaterialCmbx.Size = new System.Drawing.Size(400, 49);
            this.WebserviceKrMaterialCmbx.StartIndex = 0;
            this.WebserviceKrMaterialCmbx.TabIndex = 55;
            this.WebserviceKrMaterialCmbx.ValueMember = "Id";
            this.WebserviceKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.WebserviceKrMaterialCmbx_SelectedIndexChanged);
            // 
            // KlantKrMaterialCmbx
            // 
            this.KlantKrMaterialCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KlantKrMaterialCmbx.AutoResize = false;
            this.KlantKrMaterialCmbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.KlantKrMaterialCmbx.Depth = 0;
            this.KlantKrMaterialCmbx.DisplayMember = "Name";
            this.KlantKrMaterialCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.KlantKrMaterialCmbx.DropDownHeight = 174;
            this.KlantKrMaterialCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlantKrMaterialCmbx.DropDownWidth = 121;
            this.KlantKrMaterialCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.KlantKrMaterialCmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KlantKrMaterialCmbx.FormattingEnabled = true;
            this.KlantKrMaterialCmbx.IntegralHeight = false;
            this.KlantKrMaterialCmbx.ItemHeight = 43;
            this.KlantKrMaterialCmbx.Location = new System.Drawing.Point(788, 259);
            this.KlantKrMaterialCmbx.MaxDropDownItems = 4;
            this.KlantKrMaterialCmbx.MouseState = MaterialSkin.MouseState.OUT;
            this.KlantKrMaterialCmbx.Name = "KlantKrMaterialCmbx";
            this.KlantKrMaterialCmbx.Size = new System.Drawing.Size(400, 49);
            this.KlantKrMaterialCmbx.StartIndex = 0;
            this.KlantKrMaterialCmbx.TabIndex = 56;
            this.KlantKrMaterialCmbx.ValueMember = "Id";
            this.KlantKrMaterialCmbx.SelectedIndexChanged += new System.EventHandler(this.KlantKrMaterialCmbx_SelectedIndexChanged);
            // 
            // DeleteUrlBttn
            // 
            this.DeleteUrlBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUrlBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteUrlBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUrlBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUrlBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUrlBttn.Location = new System.Drawing.Point(693, 314);
            this.DeleteUrlBttn.Name = "DeleteUrlBttn";
            this.DeleteUrlBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteUrlBttn.TabIndex = 57;
            this.DeleteUrlBttn.Text = "URL VERWIJDEREN";
            this.DeleteUrlBttn.UseVisualStyleBackColor = false;
            this.DeleteUrlBttn.Click += new System.EventHandler(this.DeleteUrlBttn_Click);
            // 
            // AddUrlBtn
            // 
            this.AddUrlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUrlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddUrlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUrlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUrlBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUrlBtn.Location = new System.Drawing.Point(962, 315);
            this.AddUrlBtn.Name = "AddUrlBtn";
            this.AddUrlBtn.Size = new System.Drawing.Size(112, 43);
            this.AddUrlBtn.TabIndex = 58;
            this.AddUrlBtn.Text = "URL TOEVOEGEN";
            this.AddUrlBtn.UseVisualStyleBackColor = false;
            // 
            // PasUrlAanBtn
            // 
            this.PasUrlAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasUrlAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasUrlAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasUrlAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasUrlAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasUrlAanBtn.Location = new System.Drawing.Point(1080, 314);
            this.PasUrlAanBtn.Name = "PasUrlAanBtn";
            this.PasUrlAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasUrlAanBtn.TabIndex = 59;
            this.PasUrlAanBtn.Text = "URL AANPASSEN";
            this.PasUrlAanBtn.UseVisualStyleBackColor = false;
            this.PasUrlAanBtn.Click += new System.EventHandler(this.PasUrlAanBtn_Click);
            // 
            // AllUrlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 364);
            this.Controls.Add(this.PasUrlAanBtn);
            this.Controls.Add(this.AddUrlBtn);
            this.Controls.Add(this.DeleteUrlBttn);
            this.Controls.Add(this.KlantKrMaterialCmbx);
            this.Controls.Add(this.WebserviceKrMaterialCmbx);
            this.Controls.Add(this.AllUrlsKrMaterialLstBx);
            this.Controls.Add(this.LblKlant);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.UrlTxtBx);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.SecurityIdTxtBx);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.LblBewerken);
            this.MinimumSize = new System.Drawing.Size(1201, 364);
            this.Name = "AllUrlsForm";
            this.Text = "Urls beheren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LblBewerken;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox SecurityIdTxtBx;
        private MaterialSkin.Controls.MaterialTextBox UrlTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel LblKlant;
        private KrMaterialListBox AllUrlsKrMaterialLstBx;
        private KrMaterialCombobox WebserviceKrMaterialCmbx;
        private KrMaterialCombobox KlantKrMaterialCmbx;
        private System.Windows.Forms.Button DeleteUrlBttn;
        private System.Windows.Forms.Button AddUrlBtn;
        private System.Windows.Forms.Button PasUrlAanBtn;
    }
}