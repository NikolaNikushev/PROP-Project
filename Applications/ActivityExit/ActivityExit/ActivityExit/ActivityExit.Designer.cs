namespace ActivityExit
{
    partial class ActivityExit
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.serialNumer = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusValue = new System.Windows.Forms.Label();
            this.readerNumberValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close_RFID = new System.Windows.Forms.Button();
            this.open_RFID = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.response);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.serialNumer);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(35, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 249);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visitor/Bracelet details";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(20, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 25);
            this.label18.TabIndex = 10;
            this.label18.Text = "User allowed to enter";
            // 
            // serialNumer
            // 
            this.serialNumer.AutoSize = true;
            this.serialNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialNumer.Location = new System.Drawing.Point(199, 44);
            this.serialNumer.Name = "serialNumer";
            this.serialNumer.Size = new System.Drawing.Size(75, 25);
            this.serialNumer.TabIndex = 7;
            this.serialNumer.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Serial number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusValue);
            this.groupBox2.Controls.Add(this.readerNumberValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(184, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 109);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reader details";
            // 
            // statusValue
            // 
            this.statusValue.AutoSize = true;
            this.statusValue.Location = new System.Drawing.Point(131, 57);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(18, 20);
            this.statusValue.TabIndex = 15;
            this.statusValue.Text = "s";
            // 
            // readerNumberValue
            // 
            this.readerNumberValue.AutoSize = true;
            this.readerNumberValue.Location = new System.Drawing.Point(131, 27);
            this.readerNumberValue.Name = "readerNumberValue";
            this.readerNumberValue.Size = new System.Drawing.Size(48, 20);
            this.readerNumberValue.TabIndex = 14;
            this.readerNumberValue.Text = "value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Serial number:";
            // 
            // close_RFID
            // 
            this.close_RFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_RFID.Location = new System.Drawing.Point(36, 350);
            this.close_RFID.Name = "close_RFID";
            this.close_RFID.Size = new System.Drawing.Size(133, 43);
            this.close_RFID.TabIndex = 14;
            this.close_RFID.Text = "Close reader";
            this.close_RFID.UseVisualStyleBackColor = true;
            this.close_RFID.Click += new System.EventHandler(this.close_RFID_Click_1);
            // 
            // open_RFID
            // 
            this.open_RFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_RFID.Location = new System.Drawing.Point(35, 293);
            this.open_RFID.Name = "open_RFID";
            this.open_RFID.Size = new System.Drawing.Size(134, 44);
            this.open_RFID.TabIndex = 13;
            this.open_RFID.Text = "Open reader";
            this.open_RFID.UseVisualStyleBackColor = true;
            this.open_RFID.Click += new System.EventHandler(this.open_RFID_Click_1);
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(499, 24);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 222);
            this.proceedButton.TabIndex = 15;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(6, 203);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(93, 32);
            this.response.TabIndex = 11;
            this.response.Text = "label3";
            // 
            // ActivityExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 445);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.close_RFID);
            this.Controls.Add(this.open_RFID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ActivityExit";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivityExit_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label serialNumer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label statusValue;
        private System.Windows.Forms.Label readerNumberValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_RFID;
        private System.Windows.Forms.Button open_RFID;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label response;
    }
}

