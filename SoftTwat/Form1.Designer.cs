
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
            this.folderTextBox1 = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.folderTextBox2 = new System.Windows.Forms.TextBox();
            this.folderTextBox3 = new System.Windows.Forms.TextBox();
            this.combineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // folderTextBox1
            // 
            this.folderTextBox1.Location = new System.Drawing.Point(141, 52);
            this.folderTextBox1.Name = "folderTextBox1";
            this.folderTextBox1.Size = new System.Drawing.Size(461, 22);
            this.folderTextBox1.TabIndex = 1;
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
            // folderTextBox2
            // 
            this.folderTextBox2.Location = new System.Drawing.Point(141, 95);
            this.folderTextBox2.Name = "folderTextBox2";
            this.folderTextBox2.Size = new System.Drawing.Size(461, 22);
            this.folderTextBox2.TabIndex = 3;
            // 
            // folderTextBox3
            // 
            this.folderTextBox3.Location = new System.Drawing.Point(141, 142);
            this.folderTextBox3.Name = "folderTextBox3";
            this.folderTextBox3.Size = new System.Drawing.Size(461, 22);
            this.folderTextBox3.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(141, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input up to three directories of game folders";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.folderTextBox3);
            this.Controls.Add(this.folderTextBox2);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.folderTextBox1);
            this.Controls.Add(this.listButton);
            this.Name = "MainForm";
            this.Text = "Soft Twat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.TextBox folderTextBox1;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.TextBox folderTextBox2;
        private System.Windows.Forms.TextBox folderTextBox3;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.Label label1;
    }
}

