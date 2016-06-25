namespace ActivityEntrance
{
    partial class ActivityEntranceForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.activityName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.freePlaces = new System.Windows.Forms.Label();
            this.reservedPlaces = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalPlaces = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.activityDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.userInfo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.typeOfPlace = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.braceletSerialNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusValue = new System.Windows.Forms.Label();
            this.readerNumberValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_RFID
            // 
            this.open_RFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_RFID.Location = new System.Drawing.Point(17, 396);
            this.open_RFID.Name = "open_RFID";
            this.open_RFID.Size = new System.Drawing.Size(134, 44);
            this.open_RFID.TabIndex = 0;
            this.open_RFID.Text = "Open reader";
            this.open_RFID.UseVisualStyleBackColor = true;
            this.open_RFID.Click += new System.EventHandler(this.open_RFID_Click);
            // 
            // close_RFID
            // 
            this.close_RFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_RFID.Location = new System.Drawing.Point(18, 459);
            this.close_RFID.Name = "close_RFID";
            this.close_RFID.Size = new System.Drawing.Size(133, 43);
            this.close_RFID.TabIndex = 1;
            this.close_RFID.Text = "Close reader";
            this.close_RFID.UseVisualStyleBackColor = true;
            this.close_RFID.Click += new System.EventHandler(this.close_RFID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Activity name:";
            // 
            // activityName
            // 
            this.activityName.AutoSize = true;
            this.activityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activityName.Location = new System.Drawing.Point(175, 44);
            this.activityName.Name = "activityName";
            this.activityName.Size = new System.Drawing.Size(0, 25);
            this.activityName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Activity date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.freePlaces);
            this.groupBox1.Controls.Add(this.reservedPlaces);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.totalPlaces);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.activityDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.activityName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 358);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity details";
            // 
            // freePlaces
            // 
            this.freePlaces.AutoSize = true;
            this.freePlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freePlaces.Location = new System.Drawing.Point(146, 316);
            this.freePlaces.Name = "freePlaces";
            this.freePlaces.Size = new System.Drawing.Size(0, 25);
            this.freePlaces.TabIndex = 17;
            // 
            // reservedPlaces
            // 
            this.reservedPlaces.AutoSize = true;
            this.reservedPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservedPlaces.Location = new System.Drawing.Point(175, 169);
            this.reservedPlaces.Name = "reservedPlaces";
            this.reservedPlaces.Size = new System.Drawing.Size(0, 25);
            this.reservedPlaces.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Reserved places:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Free places:";
            // 
            // totalPlaces
            // 
            this.totalPlaces.AutoSize = true;
            this.totalPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPlaces.Location = new System.Drawing.Point(175, 129);
            this.totalPlaces.Name = "totalPlaces";
            this.totalPlaces.Size = new System.Drawing.Size(0, 25);
            this.totalPlaces.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total places:";
            // 
            // activityDate
            // 
            this.activityDate.AutoSize = true;
            this.activityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activityDate.Location = new System.Drawing.Point(175, 87);
            this.activityDate.Name = "activityDate";
            this.activityDate.Size = new System.Drawing.Size(0, 25);
            this.activityDate.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.userInfo);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.typeOfPlace);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.braceletSerialNumber);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(788, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 358);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visitor/Bracelet details";
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(19, 316);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(62, 32);
            this.userInfo.TabIndex = 11;
            this.userInfo.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(20, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 25);
            this.label18.TabIndex = 10;
            // 
            // typeOfPlace
            // 
            this.typeOfPlace.AutoSize = true;
            this.typeOfPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfPlace.Location = new System.Drawing.Point(199, 87);
            this.typeOfPlace.Name = "typeOfPlace";
            this.typeOfPlace.Size = new System.Drawing.Size(46, 25);
            this.typeOfPlace.TabIndex = 9;
            this.typeOfPlace.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Type of place:";
            // 
            // braceletSerialNumber
            // 
            this.braceletSerialNumber.AutoSize = true;
            this.braceletSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.braceletSerialNumber.Location = new System.Drawing.Point(199, 44);
            this.braceletSerialNumber.Name = "braceletSerialNumber";
            this.braceletSerialNumber.Size = new System.Drawing.Size(147, 25);
            this.braceletSerialNumber.TabIndex = 7;
            this.braceletSerialNumber.Text = "Scan bracelet...";
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
            this.groupBox2.Location = new System.Drawing.Point(182, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reader details";
            // 
            // statusValue
            // 
            this.statusValue.AutoSize = true;
            this.statusValue.Location = new System.Drawing.Point(131, 57);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(0, 20);
            this.statusValue.TabIndex = 15;
            // 
            // readerNumberValue
            // 
            this.readerNumberValue.AutoSize = true;
            this.readerNumberValue.Location = new System.Drawing.Point(131, 27);
            this.readerNumberValue.Name = "readerNumberValue";
            this.readerNumberValue.Size = new System.Drawing.Size(0, 20);
            this.readerNumberValue.TabIndex = 14;
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
            // proceedButton
            // 
            this.proceedButton.Enabled = false;
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proceedButton.Location = new System.Drawing.Point(1285, 12);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(51, 268);
            this.proceedButton.TabIndex = 13;
            this.proceedButton.Text = "PROCEED";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // ActivityEntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 525);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close_RFID);
            this.Controls.Add(this.open_RFID);
            this.Name = "ActivityEntranceForm";
            this.Text = "Activity Entrance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivityEntranceForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_RFID;
        private System.Windows.Forms.Button close_RFID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label activityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label reservedPlaces;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalPlaces;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label activityDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label braceletSerialNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusValue;
        private System.Windows.Forms.Label readerNumberValue;
        private System.Windows.Forms.Label typeOfPlace;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label freePlaces;
        private System.Windows.Forms.Label userInfo;
    }
}

