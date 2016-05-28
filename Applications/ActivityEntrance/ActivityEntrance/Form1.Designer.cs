namespace ActivityEntrance
{
    partial class ActivityReservationForm
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
            this.open_RFID = new System.Windows.Forms.Button();
            this.close_RFID = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // open_RFID
            // 
            this.open_RFID.Location = new System.Drawing.Point(26, 29);
            this.open_RFID.Name = "open_RFID";
            this.open_RFID.Size = new System.Drawing.Size(75, 23);
            this.open_RFID.TabIndex = 0;
            this.open_RFID.Text = "Start";
            this.open_RFID.UseVisualStyleBackColor = true;
            this.open_RFID.Click += new System.EventHandler(this.open_RFID_Click);
            // 
            // close_RFID
            // 
            this.close_RFID.Location = new System.Drawing.Point(26, 93);
            this.close_RFID.Name = "close_RFID";
            this.close_RFID.Size = new System.Drawing.Size(75, 23);
            this.close_RFID.TabIndex = 1;
            this.close_RFID.Text = "Close";
            this.close_RFID.UseVisualStyleBackColor = true;
            this.close_RFID.Click += new System.EventHandler(this.close_RFID_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(140, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(746, 244);
            this.listBox1.TabIndex = 2;
            // 
            // ActivityReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 455);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.close_RFID);
            this.Controls.Add(this.open_RFID);
            this.Name = "ActivityReservationForm";
            this.Text = "ActivityReservationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_RFID;
        private System.Windows.Forms.Button close_RFID;
        private System.Windows.Forms.ListBox listBox1;
    }
}

