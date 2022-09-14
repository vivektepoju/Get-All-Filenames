namespace FilesNamesExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.chkExtension = new System.Windows.Forms.CheckBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.rtbFileNames = new System.Windows.Forms.RichTextBox();
            this.chkDisplayExtension = new System.Windows.Forms.CheckBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.chkIncludeDirectories = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbFileSize = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(77, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(337, 20);
            this.txtPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(191, 78);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // chkExtension
            // 
            this.chkExtension.AutoSize = true;
            this.chkExtension.Location = new System.Drawing.Point(31, 49);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(72, 17);
            this.chkExtension.TabIndex = 3;
            this.chkExtension.Text = "Extension";
            this.chkExtension.UseVisualStyleBackColor = true;
            this.chkExtension.CheckedChanged += new System.EventHandler(this.ChkExtension_CheckedChanged);
            // 
            // txtExtension
            // 
            this.txtExtension.Enabled = false;
            this.txtExtension.Location = new System.Drawing.Point(109, 47);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(62, 20);
            this.txtExtension.TabIndex = 4;
            this.txtExtension.Text = "txt";
            // 
            // rtbFileNames
            // 
            this.rtbFileNames.BackColor = System.Drawing.Color.PaleGreen;
            this.rtbFileNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFileNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFileNames.Location = new System.Drawing.Point(3, 3);
            this.rtbFileNames.Name = "rtbFileNames";
            this.rtbFileNames.ReadOnly = true;
            this.rtbFileNames.Size = new System.Drawing.Size(440, 227);
            this.rtbFileNames.TabIndex = 5;
            this.rtbFileNames.Text = "";
            // 
            // chkDisplayExtension
            // 
            this.chkDisplayExtension.AutoSize = true;
            this.chkDisplayExtension.Checked = true;
            this.chkDisplayExtension.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayExtension.Location = new System.Drawing.Point(293, 49);
            this.chkDisplayExtension.Name = "chkDisplayExtension";
            this.chkDisplayExtension.Size = new System.Drawing.Size(109, 17);
            this.chkDisplayExtension.TabIndex = 6;
            this.chkDisplayExtension.Text = "Display Extension";
            this.chkDisplayExtension.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(387, 105);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Count 0";
            // 
            // chkIncludeDirectories
            // 
            this.chkIncludeDirectories.AutoSize = true;
            this.chkIncludeDirectories.Location = new System.Drawing.Point(31, 73);
            this.chkIncludeDirectories.Name = "chkIncludeDirectories";
            this.chkIncludeDirectories.Size = new System.Drawing.Size(98, 17);
            this.chkIncludeDirectories.TabIndex = 8;
            this.chkIncludeDirectories.Text = "Include Folders";
            this.chkIncludeDirectories.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(337, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "vivek";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 259);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbFileNames);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Names";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbFileSize);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Size";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbFileSize
            // 
            this.rtbFileSize.BackColor = System.Drawing.Color.Khaki;
            this.rtbFileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFileSize.Location = new System.Drawing.Point(3, 3);
            this.rtbFileSize.Name = "rtbFileSize";
            this.rtbFileSize.Size = new System.Drawing.Size(440, 227);
            this.rtbFileSize.TabIndex = 0;
            this.rtbFileSize.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkIncludeDirectories);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.chkDisplayExtension);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.chkExtension);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Folder Files Extractor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.CheckBox chkExtension;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.RichTextBox rtbFileNames;
        private System.Windows.Forms.CheckBox chkDisplayExtension;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chkIncludeDirectories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbFileSize;
    }
}

