
namespace WindowsFormsAppTest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.httpTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUrls = new System.Windows.Forms.ComboBox();
            this.PasUrlAanButton = new System.Windows.Forms.Button();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxKraanDLL = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanIni = new System.Windows.Forms.CheckBox();
            this.checkBoxKraanDatabase = new System.Windows.Forms.CheckBox();
            this.textBoxWebservice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUrlButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UrlChangeTextBox = new System.Windows.Forms.TextBox();
            this.SecurityChangeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Route";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // httpTextBox
            // 
            this.httpTextBox.Location = new System.Drawing.Point(16, 25);
            this.httpTextBox.Name = "httpTextBox";
            this.httpTextBox.ReadOnly = true;
            this.httpTextBox.Size = new System.Drawing.Size(144, 20);
            this.httpTextBox.TabIndex = 3;
            this.httpTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // comboBoxUrls
            // 
            this.comboBoxUrls.FormattingEnabled = true;
            this.comboBoxUrls.Location = new System.Drawing.Point(184, 24);
            this.comboBoxUrls.Name = "comboBoxUrls";
            this.comboBoxUrls.Size = new System.Drawing.Size(478, 21);
            this.comboBoxUrls.TabIndex = 7;
            this.comboBoxUrls.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PasUrlAanButton
            // 
            this.PasUrlAanButton.Location = new System.Drawing.Point(745, 205);
            this.PasUrlAanButton.Name = "PasUrlAanButton";
            this.PasUrlAanButton.Size = new System.Drawing.Size(80, 56);
            this.PasUrlAanButton.TabIndex = 8;
            this.PasUrlAanButton.Text = "Pas de gegevens aan";
            this.PasUrlAanButton.UseVisualStyleBackColor = true;
            this.PasUrlAanButton.Click += new System.EventHandler(this.PasUrlAanButton_Click);
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Location = new System.Drawing.Point(16, 205);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.Size = new System.Drawing.Size(642, 193);
            this.ResponseTextBox.TabIndex = 6;
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
            // textBoxWebservice
            // 
            this.textBoxWebservice.Location = new System.Drawing.Point(114, 14);
            this.textBoxWebservice.Name = "textBoxWebservice";
            this.textBoxWebservice.Size = new System.Drawing.Size(217, 20);
            this.textBoxWebservice.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Webservice versie:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddUrlButton
            // 
            this.AddUrlButton.Location = new System.Drawing.Point(676, 306);
            this.AddUrlButton.Name = "AddUrlButton";
            this.AddUrlButton.Size = new System.Drawing.Size(214, 44);
            this.AddUrlButton.TabIndex = 15;
            this.AddUrlButton.Text = "Add url";
            this.AddUrlButton.UseVisualStyleBackColor = true;
            this.AddUrlButton.Click += new System.EventHandler(this.AddUrlButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxWebservice);
            this.groupBox1.Controls.Add(this.checkBoxKraanDatabase);
            this.groupBox1.Controls.Add(this.checkBoxKraanIni);
            this.groupBox1.Controls.Add(this.checkBoxKraanDLL);
            this.groupBox1.Location = new System.Drawing.Point(16, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 126);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "SecurityID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Log";
            // 
            // UrlChangeTextBox
            // 
            this.UrlChangeTextBox.Location = new System.Drawing.Point(676, 134);
            this.UrlChangeTextBox.Multiline = true;
            this.UrlChangeTextBox.Name = "UrlChangeTextBox";
            this.UrlChangeTextBox.Size = new System.Drawing.Size(214, 65);
            this.UrlChangeTextBox.TabIndex = 21;
            this.UrlChangeTextBox.TextChanged += new System.EventHandler(this.UrlChangeTextBox_TextChanged_1);
            // 
            // SecurityChangeTextBox
            // 
            this.SecurityChangeTextBox.Location = new System.Drawing.Point(676, 40);
            this.SecurityChangeTextBox.Multiline = true;
            this.SecurityChangeTextBox.Name = "SecurityChangeTextBox";
            this.SecurityChangeTextBox.Size = new System.Drawing.Size(214, 65);
            this.SecurityChangeTextBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 410);
            this.Controls.Add(this.SecurityChangeTextBox);
            this.Controls.Add(this.UrlChangeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddUrlButton);
            this.Controls.Add(this.PasUrlAanButton);
            this.Controls.Add(this.comboBoxUrls);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.httpTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox httpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUrls;
        private System.Windows.Forms.Button PasUrlAanButton;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.CheckBox checkBoxKraanDLL;
        private System.Windows.Forms.CheckBox checkBoxKraanIni;
        private System.Windows.Forms.CheckBox checkBoxKraanDatabase;
        private System.Windows.Forms.TextBox textBoxWebservice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUrlButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UrlChangeTextBox;
        private System.Windows.Forms.TextBox SecurityChangeTextBox;
    }
}

