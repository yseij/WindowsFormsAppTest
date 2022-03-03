
namespace WindowsFormsAppTest
{
    partial class WebServicesByKlantForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WebserviceLbl = new System.Windows.Forms.Label();
            this.textBoxWebservice = new System.Windows.Forms.TextBox();
            this.checkBoxKraanDatabase = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanIni = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanDLL = new System.Windows.Forms.CheckBox();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrVwAll = new System.Windows.Forms.TreeView();
            this.TestAllBtn = new System.Windows.Forms.Button();
            this.KlantsCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WebserviceLbl);
            this.groupBox1.Controls.Add(this.textBoxWebservice);
            this.groupBox1.Controls.Add(this.checkBoxKraanDatabase);
            this.groupBox1.Controls.Add(this.checkBoxKraanIni);
            this.groupBox1.Controls.Add(this.checkBoxKraanDLL);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 126);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // WebserviceLbl
            // 
            this.WebserviceLbl.AutoSize = true;
            this.WebserviceLbl.Location = new System.Drawing.Point(10, 17);
            this.WebserviceLbl.Name = "WebserviceLbl";
            this.WebserviceLbl.Size = new System.Drawing.Size(98, 13);
            this.WebserviceLbl.TabIndex = 14;
            this.WebserviceLbl.Text = "Webservice versie:";
            // 
            // textBoxWebservice
            // 
            this.textBoxWebservice.Location = new System.Drawing.Point(114, 14);
            this.textBoxWebservice.Name = "textBoxWebservice";
            this.textBoxWebservice.ReadOnly = true;
            this.textBoxWebservice.Size = new System.Drawing.Size(217, 20);
            this.textBoxWebservice.TabIndex = 13;
            // 
            // checkBoxKraanDatabase
            // 
            this.checkBoxKraanDatabase.AutoSize = true;
            this.checkBoxKraanDatabase.Location = new System.Drawing.Point(8, 93);
            this.checkBoxKraanDatabase.Name = "checkBoxKraanDatabase";
            this.checkBoxKraanDatabase.Size = new System.Drawing.Size(100, 17);
            this.checkBoxKraanDatabase.TabIndex = 12;
            this.checkBoxKraanDatabase.Text = "KraanDatabase";
            this.checkBoxKraanDatabase.UseVisualStyleBackColor = true;
            // 
            // checkBoxKraanIni
            // 
            this.checkBoxKraanIni.AutoSize = true;
            this.checkBoxKraanIni.Location = new System.Drawing.Point(8, 70);
            this.checkBoxKraanIni.Name = "checkBoxKraanIni";
            this.checkBoxKraanIni.Size = new System.Drawing.Size(65, 17);
            this.checkBoxKraanIni.TabIndex = 11;
            this.checkBoxKraanIni.Text = "KraanIni";
            this.checkBoxKraanIni.UseVisualStyleBackColor = true;
            // 
            // checkBoxKraanDLL
            // 
            this.checkBoxKraanDLL.AutoSize = true;
            this.checkBoxKraanDLL.Location = new System.Drawing.Point(8, 47);
            this.checkBoxKraanDLL.Name = "checkBoxKraanDLL";
            this.checkBoxKraanDLL.Size = new System.Drawing.Size(74, 17);
            this.checkBoxKraanDLL.TabIndex = 10;
            this.checkBoxKraanDLL.Text = "KraanDLL";
            this.checkBoxKraanDLL.UseVisualStyleBackColor = true;
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Location = new System.Drawing.Point(12, 229);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResponseTextBox.Size = new System.Drawing.Size(339, 207);
            this.ResponseTextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Log";
            // 
            // TrVwAll
            // 
            this.TrVwAll.Location = new System.Drawing.Point(366, 28);
            this.TrVwAll.Name = "TrVwAll";
            this.TrVwAll.Size = new System.Drawing.Size(508, 408);
            this.TrVwAll.TabIndex = 21;
            // 
            // TestAllBtn
            // 
            this.TestAllBtn.Location = new System.Drawing.Point(12, 55);
            this.TestAllBtn.Name = "TestAllBtn";
            this.TestAllBtn.Size = new System.Drawing.Size(339, 23);
            this.TestAllBtn.TabIndex = 20;
            this.TestAllBtn.Text = "Test All";
            this.TestAllBtn.UseVisualStyleBackColor = true;
            this.TestAllBtn.Click += new System.EventHandler(this.TestAllBtn_Click);
            // 
            // KlantsCmbx
            // 
            this.KlantsCmbx.FormattingEnabled = true;
            this.KlantsCmbx.Location = new System.Drawing.Point(12, 28);
            this.KlantsCmbx.Name = "KlantsCmbx";
            this.KlantsCmbx.Size = new System.Drawing.Size(339, 21);
            this.KlantsCmbx.TabIndex = 19;
            this.KlantsCmbx.SelectedIndexChanged += new System.EventHandler(this.WebServiceCmbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Klanten";
            // 
            // WebServicesByKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrVwAll);
            this.Controls.Add(this.TestAllBtn);
            this.Controls.Add(this.KlantsCmbx);
            this.Controls.Add(this.label1);
            this.Name = "WebServicesByKlantForm";
            this.Text = "WebServicesByKlantForm";
            this.Load += new System.EventHandler(this.WebServicesByKlantForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label WebserviceLbl;
        private System.Windows.Forms.TextBox textBoxWebservice;
        private System.Windows.Forms.CheckBox checkBoxKraanDatabase;
        private System.Windows.Forms.CheckBox checkBoxKraanIni;
        private System.Windows.Forms.CheckBox checkBoxKraanDLL;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TrVwAll;
        private System.Windows.Forms.Button TestAllBtn;
        private System.Windows.Forms.ComboBox KlantsCmbx;
        private System.Windows.Forms.Label label1;
    }
}