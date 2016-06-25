namespace PinCodeGen
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
            this.tbToEncrypt = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbToEncrypt
            // 
            this.tbToEncrypt.Location = new System.Drawing.Point(12, 41);
            this.tbToEncrypt.Name = "tbToEncrypt";
            this.tbToEncrypt.Size = new System.Drawing.Size(117, 20);
            this.tbToEncrypt.TabIndex = 0;
            // 
            // lbResults
            // 
            this.lbResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(143, 0);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(273, 263);
            this.lbResults.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 136);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(117, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(12, 85);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(117, 20);
            this.tbKey.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Input";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 69);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 263);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.tbToEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToEncrypt;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

