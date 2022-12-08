
namespace SoftTwat
{
    partial class MainForm
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
            this.listButton = new System.Windows.Forms.Button();
            this.compareButton = new System.Windows.Forms.Button();
            this.combineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFolderButton1 = new System.Windows.Forms.Button();
            this.selectFolderButton3 = new System.Windows.Forms.Button();
            this.selectFolderButton2 = new System.Windows.Forms.Button();
            this.folderComboBox1 = new System.Windows.Forms.ComboBox();
            this.folderComboBox2 = new System.Windows.Forms.ComboBox();
            this.folderComboBox3 = new System.Windows.Forms.ComboBox();
            this.showAliasesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(572, 324);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(117, 71);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "Get Folders";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click_1);
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(67, 324);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(129, 71);
            this.compareButton.TabIndex = 2;
            this.compareButton.Text = "Compare Libraries";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // combineButton
            // 
            this.combineButton.Location = new System.Drawing.Point(308, 324);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(128, 71);
            this.combineButton.TabIndex = 5;
            this.combineButton.Text = "Combine Library Lists";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input up to three directories of game folders";
            // 
            // selectFolderButton1
            // 
            this.selectFolderButton1.Location = new System.Drawing.Point(572, 58);
            this.selectFolderButton1.Name = "selectFolderButton1";
            this.selectFolderButton1.Size = new System.Drawing.Size(117, 23);
            this.selectFolderButton1.TabIndex = 7;
            this.selectFolderButton1.Text = "Choose Folder";
            this.selectFolderButton1.UseVisualStyleBackColor = true;
            this.selectFolderButton1.Click += new System.EventHandler(this.selectFolderButton1_Click);
            // 
            // selectFolderButton3
            // 
            this.selectFolderButton3.Location = new System.Drawing.Point(572, 147);
            this.selectFolderButton3.Name = "selectFolderButton3";
            this.selectFolderButton3.Size = new System.Drawing.Size(117, 23);
            this.selectFolderButton3.TabIndex = 8;
            this.selectFolderButton3.Text = "Choose Folder";
            this.selectFolderButton3.UseVisualStyleBackColor = true;
            this.selectFolderButton3.Click += new System.EventHandler(this.selectFolderButton3_Click);
            // 
            // selectFolderButton2
            // 
            this.selectFolderButton2.Location = new System.Drawing.Point(572, 101);
            this.selectFolderButton2.Name = "selectFolderButton2";
            this.selectFolderButton2.Size = new System.Drawing.Size(117, 23);
            this.selectFolderButton2.TabIndex = 9;
            this.selectFolderButton2.Text = "Choose Folder";
            this.selectFolderButton2.UseVisualStyleBackColor = true;
            this.selectFolderButton2.Click += new System.EventHandler(this.selectFolderButton2_Click);
            // 
            // folderComboBox1
            // 
            this.folderComboBox1.FormattingEnabled = true;
            this.folderComboBox1.Location = new System.Drawing.Point(64, 58);
            this.folderComboBox1.Name = "folderComboBox1";
            this.folderComboBox1.Size = new System.Drawing.Size(461, 24);
            this.folderComboBox1.TabIndex = 10;
            // 
            // folderComboBox2
            // 
            this.folderComboBox2.FormattingEnabled = true;
            this.folderComboBox2.Location = new System.Drawing.Point(64, 101);
            this.folderComboBox2.Name = "folderComboBox2";
            this.folderComboBox2.Size = new System.Drawing.Size(461, 24);
            this.folderComboBox2.TabIndex = 11;
            // 
            // folderComboBox3
            // 
            this.folderComboBox3.FormattingEnabled = true;
            this.folderComboBox3.Location = new System.Drawing.Point(64, 147);
            this.folderComboBox3.Name = "folderComboBox3";
            this.folderComboBox3.Size = new System.Drawing.Size(461, 24);
            this.folderComboBox3.TabIndex = 12;
            // 
            // showAliasesCheckBox
            // 
            this.showAliasesCheckBox.AutoSize = true;
            this.showAliasesCheckBox.Location = new System.Drawing.Point(572, 247);
            this.showAliasesCheckBox.Name = "showAliasesCheckBox";
            this.showAliasesCheckBox.Size = new System.Drawing.Size(164, 21);
            this.showAliasesCheckBox.TabIndex = 14;
            this.showAliasesCheckBox.Text = "Print Game Platforms";
            this.showAliasesCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAliasesCheckBox);
            this.Controls.Add(this.folderComboBox3);
            this.Controls.Add(this.folderComboBox2);
            this.Controls.Add(this.folderComboBox1);
            this.Controls.Add(this.selectFolderButton2);
            this.Controls.Add(this.selectFolderButton3);
            this.Controls.Add(this.selectFolderButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.listButton);
            this.Name = "MainForm";
            this.Text = "Soft Twat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectFolderButton1;
        private System.Windows.Forms.Button selectFolderButton3;
        private System.Windows.Forms.Button selectFolderButton2;
        private System.Windows.Forms.ComboBox folderComboBox1;
        private System.Windows.Forms.ComboBox folderComboBox2;
        private System.Windows.Forms.ComboBox folderComboBox3;
        private System.Windows.Forms.CheckBox showAliasesCheckBox;
    }
}

