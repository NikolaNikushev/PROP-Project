namespace ApplicationRunner
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
            this.ApplicationsListBox = new System.Windows.Forms.ListBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplicationsListBox
            // 
            this.ApplicationsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApplicationsListBox.Font = new System.Drawing.Font("Tekton Pro Ext", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationsListBox.FormattingEnabled = true;
            this.ApplicationsListBox.ItemHeight = 28;
            this.ApplicationsListBox.Location = new System.Drawing.Point(1, 5);
            this.ApplicationsListBox.Name = "ApplicationsListBox";
            this.ApplicationsListBox.Size = new System.Drawing.Size(321, 224);
            this.ApplicationsListBox.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.SystemColors.Window;
            this.RunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunButton.Font = new System.Drawing.Font("Tekton Pro Ext", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(1, 225);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(321, 33);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ApplicationsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Application Runner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ApplicationsListBox;
        private System.Windows.Forms.Button RunButton;
    }
}

