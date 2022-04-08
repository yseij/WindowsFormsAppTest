
namespace WindowsFormsAppTest
{
    partial class AllHttpsForm
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
            this.PasHttpAanBtn = new System.Windows.Forms.Button();
            this.AddHttpBtn = new System.Windows.Forms.Button();
            this.DeleteHttpBttn = new System.Windows.Forms.Button();
            this.HttpTxtBx = new MaterialSkin.Controls.MaterialTextBox();
            this.LblUrl = new MaterialSkin.Controls.MaterialLabel();
            this.LblBewerken = new MaterialSkin.Controls.MaterialLabel();
            this.AllHttpsKrMaterialLstBx = new WindowsFormsAppTest.KrMaterialListBox();
            this.SuspendLayout();
            // 
            // PasHttpAanBtn
            // 
            this.PasHttpAanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasHttpAanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.PasHttpAanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasHttpAanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasHttpAanBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PasHttpAanBtn.Location = new System.Drawing.Point(693, 250);
            this.PasHttpAanBtn.Name = "PasHttpAanBtn";
            this.PasHttpAanBtn.Size = new System.Drawing.Size(112, 43);
            this.PasHttpAanBtn.TabIndex = 72;
            this.PasHttpAanBtn.Text = "HTTP AANPASSEN";
            this.PasHttpAanBtn.UseVisualStyleBackColor = false;
            this.PasHttpAanBtn.Click += new System.EventHandler(this.PasHttpAanBtn_Click);
            // 
            // AddHttpBtn
            // 
            this.AddHttpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHttpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.AddHttpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHttpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHttpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddHttpBtn.Location = new System.Drawing.Point(575, 251);
            this.AddHttpBtn.Name = "AddHttpBtn";
            this.AddHttpBtn.Size = new System.Drawing.Size(112, 43);
            this.AddHttpBtn.TabIndex = 71;
            this.AddHttpBtn.Text = "HTTP TOEVOEGEN";
            this.AddHttpBtn.UseVisualStyleBackColor = false;
            this.AddHttpBtn.Click += new System.EventHandler(this.AddHttpBtn_Click);
            // 
            // DeleteHttpBttn
            // 
            this.DeleteHttpBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteHttpBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(160)))), ((int)(((byte)(244)))));
            this.DeleteHttpBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteHttpBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteHttpBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteHttpBttn.Location = new System.Drawing.Point(306, 250);
            this.DeleteHttpBttn.Name = "DeleteHttpBttn";
            this.DeleteHttpBttn.Size = new System.Drawing.Size(112, 43);
            this.DeleteHttpBttn.TabIndex = 70;
            this.DeleteHttpBttn.Text = "HTTP VERWIJDEREN";
            this.DeleteHttpBttn.UseVisualStyleBackColor = false;
            this.DeleteHttpBttn.Click += new System.EventHandler(this.DeleteHttpBttn_Click);
            // 
            // HttpTxtBx
            // 
            this.HttpTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HttpTxtBx.AnimateReadOnly = false;
            this.HttpTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HttpTxtBx.Depth = 0;
            this.HttpTxtBx.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HttpTxtBx.LeadingIcon = null;
            this.HttpTxtBx.Location = new System.Drawing.Point(405, 98);
            this.HttpTxtBx.MaxLength = 50;
            this.HttpTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.HttpTxtBx.Multiline = false;
            this.HttpTxtBx.Name = "HttpTxtBx";
            this.HttpTxtBx.Size = new System.Drawing.Size(400, 50);
            this.HttpTxtBx.TabIndex = 64;
            this.HttpTxtBx.Text = "";
            this.HttpTxtBx.TrailingIcon = null;
            // 
            // LblUrl
            // 
            this.LblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUrl.AutoSize = true;
            this.LblUrl.Depth = 0;
            this.LblUrl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblUrl.Location = new System.Drawing.Point(303, 101);
            this.LblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(48, 19);
            this.LblUrl.TabIndex = 63;
            this.LblUrl.Text = "Naam:";
            // 
            // LblBewerken
            // 
            this.LblBewerken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBewerken.AutoSize = true;
            this.LblBewerken.Depth = 0;
            this.LblBewerken.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBewerken.Location = new System.Drawing.Point(303, 72);
            this.LblBewerken.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBewerken.Name = "LblBewerken";
            this.LblBewerken.Size = new System.Drawing.Size(106, 19);
            this.LblBewerken.TabIndex = 60;
            this.LblBewerken.Text = "Http bewerken:";
            // 
            // AllHttpsKrMaterialLstBx
            // 
            this.AllHttpsKrMaterialLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllHttpsKrMaterialLstBx.BackColor = System.Drawing.Color.White;
            this.AllHttpsKrMaterialLstBx.BorderColor = System.Drawing.Color.LightGray;
            this.AllHttpsKrMaterialLstBx.Depth = 0;
            this.AllHttpsKrMaterialLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllHttpsKrMaterialLstBx.Location = new System.Drawing.Point(6, 67);
            this.AllHttpsKrMaterialLstBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllHttpsKrMaterialLstBx.Name = "AllHttpsKrMaterialLstBx";
            this.AllHttpsKrMaterialLstBx.SelectedIndex = -1;
            this.AllHttpsKrMaterialLstBx.SelectedItem = null;
            this.AllHttpsKrMaterialLstBx.Size = new System.Drawing.Size(291, 226);
            this.AllHttpsKrMaterialLstBx.TabIndex = 67;
            this.AllHttpsKrMaterialLstBx.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.AllHttpsKrMaterialLstBx_SelectedIndexChanged);
            // 
            // AllHttpsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 310);
            this.Controls.Add(this.PasHttpAanBtn);
            this.Controls.Add(this.AddHttpBtn);
            this.Controls.Add(this.DeleteHttpBttn);
            this.Controls.Add(this.AllHttpsKrMaterialLstBx);
            this.Controls.Add(this.HttpTxtBx);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblBewerken);
            this.MinimumSize = new System.Drawing.Size(817, 310);
            this.Name = "AllHttpsForm";
            this.Text = "AllHttpsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PasHttpAanBtn;
        private System.Windows.Forms.Button AddHttpBtn;
        private System.Windows.Forms.Button DeleteHttpBttn;
        private KrMaterialListBox AllHttpsKrMaterialLstBx;
        private MaterialSkin.Controls.MaterialTextBox HttpTxtBx;
        private MaterialSkin.Controls.MaterialLabel LblUrl;
        private MaterialSkin.Controls.MaterialLabel LblBewerken;
    }
}