
namespace AES_Encrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEncryption = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your string";
            // 
            // tbUserString
            // 
            this.tbUserString.Location = new System.Drawing.Point(38, 36);
            this.tbUserString.Multiline = true;
            this.tbUserString.Name = "tbUserString";
            this.tbUserString.Size = new System.Drawing.Size(359, 65);
            this.tbUserString.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encryption";
            // 
            // tbEncryption
            // 
            this.tbEncryption.Enabled = false;
            this.tbEncryption.Location = new System.Drawing.Point(39, 186);
            this.tbEncryption.Multiline = true;
            this.tbEncryption.Name = "tbEncryption";
            this.tbEncryption.Size = new System.Drawing.Size(359, 70);
            this.tbEncryption.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(325, 108);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(39, 107);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(325, 262);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 303);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbEncryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEncryption;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

