﻿namespace QuanLyTaiLieu
{
    partial class frmTrichDanNhieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tree_catalogue = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.list_Docs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểu trích dẫn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(730, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(811, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Harvard",
            "Chicago",
            "APA"});
            this.comboBox1.Location = new System.Drawing.Point(105, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // tree_catalogue
            // 
            this.tree_catalogue.Location = new System.Drawing.Point(15, 33);
            this.tree_catalogue.Name = "tree_catalogue";
            this.tree_catalogue.Size = new System.Drawing.Size(190, 416);
            this.tree_catalogue.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(211, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(675, 209);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // list_Docs
            // 
            this.list_Docs.Location = new System.Drawing.Point(211, 33);
            this.list_Docs.Name = "list_Docs";
            this.list_Docs.Size = new System.Drawing.Size(675, 172);
            this.list_Docs.TabIndex = 11;
            this.list_Docs.UseCompatibleStateImageBehavior = false;
            this.list_Docs.View = System.Windows.Forms.View.Details;
            // 
            // frmTrichDanNhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 461);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tree_catalogue);
            this.Controls.Add(this.list_Docs);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "frmTrichDanNhieu";
            this.Text = "frmTrichDanNhieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TreeView tree_catalogue;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView list_Docs;
    }
}