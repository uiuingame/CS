﻿namespace UIG_CS_02
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
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(12, 12);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "Click Me";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(121, 64);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(121, 20);
        	this.textBox1.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(12, 67);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(103, 21);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "This is a textBox";
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Items.AddRange(new object[] {
        	        	        	"Ran",
        	        	        	"Anat",
        	        	        	"Yuval",
        	        	        	"Eitan"});
        	this.comboBox1.Location = new System.Drawing.Point(121, 90);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(121, 21);
        	this.comboBox1.TabIndex = 3;
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(12, 90);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(103, 21);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "This is a combobox";
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(93, 14);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(179, 21);
        	this.label3.TabIndex = 5;
        	this.label3.Text = "Lesson 02";
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(284, 261);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.button1);
        	this.Name = "Form1";
        	this.Text = "UIG_CS_02";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

