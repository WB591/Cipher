namespace Cipher
{
    partial class Cipher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TranslateTextButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextTextBox = new System.Windows.Forms.TextBox();
            this.secetWordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.TranslateTextButton);
            this.panel1.Location = new System.Drawing.Point(17, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 98);
            this.panel1.TabIndex = 13;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(487, 26);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 39);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(169, 26);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(109, 39);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TranslateTextButton
            // 
            this.TranslateTextButton.Location = new System.Drawing.Point(22, 26);
            this.TranslateTextButton.Name = "TranslateTextButton";
            this.TranslateTextButton.Size = new System.Drawing.Size(126, 39);
            this.TranslateTextButton.TabIndex = 2;
            this.TranslateTextButton.Text = "Translate Text";
            this.TranslateTextButton.UseVisualStyleBackColor = true;
            this.TranslateTextButton.Click += new System.EventHandler(this.TranslateTextButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(270, 202);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(343, 79);
            this.OutputTextBox.TabIndex = 12;
            this.OutputTextBox.TabStop = false;
            // 
            // InputTextTextBox
            // 
            this.InputTextTextBox.Location = new System.Drawing.Point(270, 99);
            this.InputTextTextBox.Multiline = true;
            this.InputTextTextBox.Name = "InputTextTextBox";
            this.InputTextTextBox.Size = new System.Drawing.Size(343, 79);
            this.InputTextTextBox.TabIndex = 9;
            // 
            // secetWordTextBox
            // 
            this.secetWordTextBox.Location = new System.Drawing.Point(270, 37);
            this.secetWordTextBox.Name = "secetWordTextBox";
            this.secetWordTextBox.Size = new System.Drawing.Size(173, 22);
            this.secetWordTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cipher \"Secret\" Word:";
            // 
            // Cipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(676, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextTextBox);
            this.Controls.Add(this.secetWordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cipher";
            this.Text = "Cipher";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button TranslateTextButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.TextBox InputTextTextBox;
        private System.Windows.Forms.TextBox secetWordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

