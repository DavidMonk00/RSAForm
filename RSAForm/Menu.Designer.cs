﻿namespace RSAForm
{
    partial class Menu
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
            this.buttonKeyGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKeyGen
            // 
            this.buttonKeyGen.AutoSize = true;
            this.buttonKeyGen.Location = new System.Drawing.Point(105, 34);
            this.buttonKeyGen.Name = "buttonKeyGen";
            this.buttonKeyGen.Size = new System.Drawing.Size(90, 30);
            this.buttonKeyGen.TabIndex = 0;
            this.buttonKeyGen.Text = "Key Generation";
            this.buttonKeyGen.UseVisualStyleBackColor = true;
            this.buttonKeyGen.Click += new System.EventHandler(this.buttonKeyGen_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonKeyGen);
            this.Name = "Menu";
            this.Text = "RSA Encryption Service";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKeyGen;
    }
}
