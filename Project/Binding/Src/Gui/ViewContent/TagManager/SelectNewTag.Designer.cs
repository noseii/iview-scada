﻿namespace Aimirim.iView
{
    partial class SelectNewTag
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
        	this.listBox1 = new System.Windows.Forms.ListBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// listBox1
        	// 
        	this.listBox1.FormattingEnabled = true;
        	this.listBox1.Items.AddRange(new object[] {
        	        	        	"Digital",
        	        	        	"Analog",
        	        	        	"Sql"});
        	this.listBox1.Location = new System.Drawing.Point(9, 10);
        	this.listBox1.Margin = new System.Windows.Forms.Padding(2);
        	this.listBox1.Name = "listBox1";
        	this.listBox1.Size = new System.Drawing.Size(108, 82);
        	this.listBox1.TabIndex = 0;
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(9, 96);
        	this.button1.Margin = new System.Windows.Forms.Padding(2);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(51, 36);
        	this.button1.TabIndex = 1;
        	this.button1.Text = "Ok";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button2
        	// 
        	this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.button2.Location = new System.Drawing.Point(64, 96);
        	this.button2.Margin = new System.Windows.Forms.Padding(2);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(53, 36);
        	this.button2.TabIndex = 1;
        	this.button2.Text = "Cancel";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// SelectNewTag
        	// 
        	this.AcceptButton = this.button1;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.button2;
        	this.ClientSize = new System.Drawing.Size(128, 141);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.listBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "SelectNewTag";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "New";
        	this.Load += new System.EventHandler(this.SelectNewTagLoad);
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBox1;
    }
}