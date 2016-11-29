﻿namespace ECE_480_Project
{
    partial class AdminModeWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.wordDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ngramDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.selectLang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.writeToDict = new System.Windows.Forms.CheckBox();
            this.testButton = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngramDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add Word";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Word";
            // 
            // wordDataGrid
            // 
            this.wordDataGrid.AllowUserToAddRows = false;
            this.wordDataGrid.AllowUserToDeleteRows = false;
            this.wordDataGrid.AllowUserToResizeColumns = false;
            this.wordDataGrid.AllowUserToResizeRows = false;
            this.wordDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordDataGrid.Location = new System.Drawing.Point(274, 88);
            this.wordDataGrid.Name = "wordDataGrid";
            this.wordDataGrid.Size = new System.Drawing.Size(244, 269);
            this.wordDataGrid.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "N-Gram";
            // 
            // ngramDataGrid
            // 
            this.ngramDataGrid.AllowUserToAddRows = false;
            this.ngramDataGrid.AllowUserToDeleteRows = false;
            this.ngramDataGrid.AllowUserToResizeColumns = false;
            this.ngramDataGrid.AllowUserToResizeRows = false;
            this.ngramDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ngramDataGrid.Location = new System.Drawing.Point(12, 88);
            this.ngramDataGrid.Name = "ngramDataGrid";
            this.ngramDataGrid.ReadOnly = true;
            this.ngramDataGrid.Size = new System.Drawing.Size(244, 269);
            this.ngramDataGrid.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select Language";
            // 
            // selectLang
            // 
            this.selectLang.FormattingEnabled = true;
            this.selectLang.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "Russian"});
            this.selectLang.Location = new System.Drawing.Point(12, 25);
            this.selectLang.Name = "selectLang";
            this.selectLang.Size = new System.Drawing.Size(121, 21);
            this.selectLang.TabIndex = 21;
            this.selectLang.Text = "English";
            this.selectLang.SelectedIndexChanged += new System.EventHandler(this.selectLang_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.writeToDict);
            this.groupBox1.Controls.Add(this.testButton);
            this.groupBox1.Controls.Add(this.inputText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 118);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testing mode";
            // 
            // writeToDict
            // 
            this.writeToDict.AutoSize = true;
            this.writeToDict.Location = new System.Drawing.Point(6, 21);
            this.writeToDict.Name = "writeToDict";
            this.writeToDict.Size = new System.Drawing.Size(113, 17);
            this.writeToDict.TabIndex = 32;
            this.writeToDict.Text = "Write to Dictionary";
            this.writeToDict.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(6, 42);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(97, 25);
            this.testButton.TabIndex = 31;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(205, 18);
            this.inputText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(283, 79);
            this.inputText.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Input to test";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 43);
            this.button3.TabIndex = 31;
            this.button3.Text = "Back to Main Window";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.backToMain_click);
            // 
            // AdminModeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 520);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wordDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ngramDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectLang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminModeWindow";
            this.Text = "AdminModeWindow";
            this.Load += new System.EventHandler(this.AdminModeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngramDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView wordDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ngramDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectLang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox writeToDict;
    }
}