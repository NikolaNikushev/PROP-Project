namespace BraceletManagement
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
            this.tbSearchVisitorText = new System.Windows.Forms.TextBox();
            this.cmbxSearchType = new System.Windows.Forms.ComboBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.pnlMainSearch = new System.Windows.Forms.Panel();
            this.btnSearchVisitor = new System.Windows.Forms.Button();
            this.gbVisitorInfo = new System.Windows.Forms.GroupBox();
            this.btnDeactivateRFID = new System.Windows.Forms.Button();
            this.btnAssignNewRfid = new System.Windows.Forms.Button();
            this.tbVisitorRfid = new System.Windows.Forms.TextBox();
            this.tbVisitorStatus = new System.Windows.Forms.TextBox();
            this.tbVisitorCode = new System.Windows.Forms.TextBox();
            this.tbVisitorLastName = new System.Windows.Forms.TextBox();
            this.tbVisitorFirstName = new System.Windows.Forms.TextBox();
            this.lblVisitorRfid = new System.Windows.Forms.Label();
            this.lblVisitorStatus = new System.Windows.Forms.Label();
            this.lbActivityLog = new System.Windows.Forms.ListBox();
            this.lblVisitorCode = new System.Windows.Forms.Label();
            this.lblVisitorLastName = new System.Windows.Forms.Label();
            this.lblVisitorFirstName = new System.Windows.Forms.Label();
            this.gbScannedRFID = new System.Windows.Forms.GroupBox();
            this.btnScanAgain = new System.Windows.Forms.Button();
            this.btnStopReader = new System.Windows.Forms.Button();
            this.pcbxRdrColorIndic = new System.Windows.Forms.PictureBox();
            this.lbReaderLog = new System.Windows.Forms.ListBox();
            this.tbScannedRFIDStatus = new System.Windows.Forms.TextBox();
            this.tbScannedRFDNmb = new System.Windows.Forms.TextBox();
            this.btnActivateReader = new System.Windows.Forms.Button();
            this.lblScannedRfidStatus = new System.Windows.Forms.Label();
            this.lblScannedRfidNmb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSearchLog = new System.Windows.Forms.ListBox();
            this.tbVisitorEmail = new System.Windows.Forms.TextBox();
            this.lblVisitorEmail = new System.Windows.Forms.Label();
            this.tbVisitorRFIDStatus = new System.Windows.Forms.TextBox();
            this.lblVisitorRFIDStatus = new System.Windows.Forms.Label();
            this.pnlMainSearch.SuspendLayout();
            this.gbVisitorInfo.SuspendLayout();
            this.gbScannedRFID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRdrColorIndic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchVisitorText
            // 
            this.tbSearchVisitorText.Location = new System.Drawing.Point(175, 6);
            this.tbSearchVisitorText.Name = "tbSearchVisitorText";
            this.tbSearchVisitorText.Size = new System.Drawing.Size(321, 20);
            this.tbSearchVisitorText.TabIndex = 0;
            // 
            // cmbxSearchType
            // 
            this.cmbxSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSearchType.FormattingEnabled = true;
            this.cmbxSearchType.Items.AddRange(new object[] {
            "CODE",
            "EMAIL"});
            this.cmbxSearchType.Location = new System.Drawing.Point(68, 5);
            this.cmbxSearchType.Name = "cmbxSearchType";
            this.cmbxSearchType.Size = new System.Drawing.Size(101, 21);
            this.cmbxSearchType.TabIndex = 1;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(6, 9);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(56, 13);
            this.lblSearchType.TabIndex = 3;
            this.lblSearchType.Text = "Search By";
            this.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMainSearch
            // 
            this.pnlMainSearch.Controls.Add(this.tbSearchVisitorText);
            this.pnlMainSearch.Controls.Add(this.lblSearchType);
            this.pnlMainSearch.Controls.Add(this.cmbxSearchType);
            this.pnlMainSearch.Location = new System.Drawing.Point(6, 19);
            this.pnlMainSearch.Name = "pnlMainSearch";
            this.pnlMainSearch.Size = new System.Drawing.Size(502, 29);
            this.pnlMainSearch.TabIndex = 4;
            // 
            // btnSearchVisitor
            // 
            this.btnSearchVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchVisitor.Location = new System.Drawing.Point(168, 54);
            this.btnSearchVisitor.Name = "btnSearchVisitor";
            this.btnSearchVisitor.Size = new System.Drawing.Size(166, 29);
            this.btnSearchVisitor.TabIndex = 6;
            this.btnSearchVisitor.Text = "Search";
            this.btnSearchVisitor.UseVisualStyleBackColor = true;
            this.btnSearchVisitor.Click += new System.EventHandler(this.btnSearchVisitor_Click);
            // 
            // gbVisitorInfo
            // 
            this.gbVisitorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbVisitorInfo.Controls.Add(this.tbVisitorRFIDStatus);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorRFIDStatus);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorEmail);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorEmail);
            this.gbVisitorInfo.Controls.Add(this.btnDeactivateRFID);
            this.gbVisitorInfo.Controls.Add(this.btnAssignNewRfid);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorRfid);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorStatus);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorCode);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorLastName);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorFirstName);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorRfid);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorStatus);
            this.gbVisitorInfo.Controls.Add(this.lbActivityLog);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorCode);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorLastName);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorFirstName);
            this.gbVisitorInfo.Location = new System.Drawing.Point(0, 185);
            this.gbVisitorInfo.Name = "gbVisitorInfo";
            this.gbVisitorInfo.Size = new System.Drawing.Size(250, 385);
            this.gbVisitorInfo.TabIndex = 7;
            this.gbVisitorInfo.TabStop = false;
            this.gbVisitorInfo.Text = "Visitor";
            // 
            // btnDeactivateRFID
            // 
            this.btnDeactivateRFID.Location = new System.Drawing.Point(6, 222);
            this.btnDeactivateRFID.Name = "btnDeactivateRFID";
            this.btnDeactivateRFID.Size = new System.Drawing.Size(99, 23);
            this.btnDeactivateRFID.TabIndex = 12;
            this.btnDeactivateRFID.Text = "Deactivate RFID";
            this.btnDeactivateRFID.UseVisualStyleBackColor = true;
            // 
            // btnAssignNewRfid
            // 
            this.btnAssignNewRfid.Location = new System.Drawing.Point(126, 222);
            this.btnAssignNewRfid.Name = "btnAssignNewRfid";
            this.btnAssignNewRfid.Size = new System.Drawing.Size(99, 23);
            this.btnAssignNewRfid.TabIndex = 11;
            this.btnAssignNewRfid.Text = "Assign New RFID";
            this.btnAssignNewRfid.UseVisualStyleBackColor = true;
            // 
            // tbVisitorRfid
            // 
            this.tbVisitorRfid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorRfid.Location = new System.Drawing.Point(92, 155);
            this.tbVisitorRfid.Name = "tbVisitorRfid";
            this.tbVisitorRfid.ReadOnly = true;
            this.tbVisitorRfid.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorRfid.TabIndex = 10;
            // 
            // tbVisitorStatus
            // 
            this.tbVisitorStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorStatus.Location = new System.Drawing.Point(92, 129);
            this.tbVisitorStatus.Name = "tbVisitorStatus";
            this.tbVisitorStatus.ReadOnly = true;
            this.tbVisitorStatus.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorStatus.TabIndex = 9;
            // 
            // tbVisitorCode
            // 
            this.tbVisitorCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorCode.Location = new System.Drawing.Point(92, 103);
            this.tbVisitorCode.Name = "tbVisitorCode";
            this.tbVisitorCode.ReadOnly = true;
            this.tbVisitorCode.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorCode.TabIndex = 8;
            // 
            // tbVisitorLastName
            // 
            this.tbVisitorLastName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorLastName.Location = new System.Drawing.Point(92, 77);
            this.tbVisitorLastName.Name = "tbVisitorLastName";
            this.tbVisitorLastName.ReadOnly = true;
            this.tbVisitorLastName.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorLastName.TabIndex = 7;
            // 
            // tbVisitorFirstName
            // 
            this.tbVisitorFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorFirstName.Location = new System.Drawing.Point(92, 51);
            this.tbVisitorFirstName.Name = "tbVisitorFirstName";
            this.tbVisitorFirstName.ReadOnly = true;
            this.tbVisitorFirstName.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorFirstName.TabIndex = 6;
            // 
            // lblVisitorRfid
            // 
            this.lblVisitorRfid.AutoSize = true;
            this.lblVisitorRfid.Location = new System.Drawing.Point(6, 158);
            this.lblVisitorRfid.Name = "lblVisitorRfid";
            this.lblVisitorRfid.Size = new System.Drawing.Size(75, 13);
            this.lblVisitorRfid.TabIndex = 5;
            this.lblVisitorRfid.Text = "RFID Number:";
            // 
            // lblVisitorStatus
            // 
            this.lblVisitorStatus.AutoSize = true;
            this.lblVisitorStatus.Location = new System.Drawing.Point(6, 133);
            this.lblVisitorStatus.Name = "lblVisitorStatus";
            this.lblVisitorStatus.Size = new System.Drawing.Size(40, 13);
            this.lblVisitorStatus.TabIndex = 4;
            this.lblVisitorStatus.Text = "Status:";
            // 
            // lbActivityLog
            // 
            this.lbActivityLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbActivityLog.FormattingEnabled = true;
            this.lbActivityLog.Location = new System.Drawing.Point(0, 251);
            this.lbActivityLog.Name = "lbActivityLog";
            this.lbActivityLog.Size = new System.Drawing.Size(250, 121);
            this.lbActivityLog.TabIndex = 3;
            // 
            // lblVisitorCode
            // 
            this.lblVisitorCode.AutoSize = true;
            this.lblVisitorCode.Location = new System.Drawing.Point(6, 107);
            this.lblVisitorCode.Name = "lblVisitorCode";
            this.lblVisitorCode.Size = new System.Drawing.Size(35, 13);
            this.lblVisitorCode.TabIndex = 2;
            this.lblVisitorCode.Text = "Code:";
            // 
            // lblVisitorLastName
            // 
            this.lblVisitorLastName.AutoSize = true;
            this.lblVisitorLastName.Location = new System.Drawing.Point(6, 81);
            this.lblVisitorLastName.Name = "lblVisitorLastName";
            this.lblVisitorLastName.Size = new System.Drawing.Size(58, 13);
            this.lblVisitorLastName.TabIndex = 1;
            this.lblVisitorLastName.Text = "Last Name";
            // 
            // lblVisitorFirstName
            // 
            this.lblVisitorFirstName.AutoSize = true;
            this.lblVisitorFirstName.Location = new System.Drawing.Point(6, 55);
            this.lblVisitorFirstName.Name = "lblVisitorFirstName";
            this.lblVisitorFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblVisitorFirstName.TabIndex = 0;
            this.lblVisitorFirstName.Text = "First Name:";
            // 
            // gbScannedRFID
            // 
            this.gbScannedRFID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScannedRFID.Controls.Add(this.btnScanAgain);
            this.gbScannedRFID.Controls.Add(this.btnStopReader);
            this.gbScannedRFID.Controls.Add(this.pcbxRdrColorIndic);
            this.gbScannedRFID.Controls.Add(this.lbReaderLog);
            this.gbScannedRFID.Controls.Add(this.tbScannedRFIDStatus);
            this.gbScannedRFID.Controls.Add(this.tbScannedRFDNmb);
            this.gbScannedRFID.Controls.Add(this.btnActivateReader);
            this.gbScannedRFID.Controls.Add(this.lblScannedRfidStatus);
            this.gbScannedRFID.Controls.Add(this.lblScannedRfidNmb);
            this.gbScannedRFID.Location = new System.Drawing.Point(256, 185);
            this.gbScannedRFID.Name = "gbScannedRFID";
            this.gbScannedRFID.Size = new System.Drawing.Size(250, 385);
            this.gbScannedRFID.TabIndex = 8;
            this.gbScannedRFID.TabStop = false;
            this.gbScannedRFID.Text = "RFID Reader";
            // 
            // btnScanAgain
            // 
            this.btnScanAgain.Location = new System.Drawing.Point(12, 222);
            this.btnScanAgain.Name = "btnScanAgain";
            this.btnScanAgain.Size = new System.Drawing.Size(224, 23);
            this.btnScanAgain.TabIndex = 12;
            this.btnScanAgain.Text = "Scan Again";
            this.btnScanAgain.UseVisualStyleBackColor = true;
            // 
            // btnStopReader
            // 
            this.btnStopReader.Location = new System.Drawing.Point(161, 17);
            this.btnStopReader.Name = "btnStopReader";
            this.btnStopReader.Size = new System.Drawing.Size(83, 26);
            this.btnStopReader.TabIndex = 9;
            this.btnStopReader.Text = "Stop Reader";
            this.btnStopReader.UseVisualStyleBackColor = true;
            // 
            // pcbxRdrColorIndic
            // 
            this.pcbxRdrColorIndic.Location = new System.Drawing.Point(5, 49);
            this.pcbxRdrColorIndic.Name = "pcbxRdrColorIndic";
            this.pcbxRdrColorIndic.Size = new System.Drawing.Size(239, 29);
            this.pcbxRdrColorIndic.TabIndex = 8;
            this.pcbxRdrColorIndic.TabStop = false;
            // 
            // lbReaderLog
            // 
            this.lbReaderLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReaderLog.FormattingEnabled = true;
            this.lbReaderLog.Location = new System.Drawing.Point(0, 250);
            this.lbReaderLog.Name = "lbReaderLog";
            this.lbReaderLog.Size = new System.Drawing.Size(250, 121);
            this.lbReaderLog.TabIndex = 4;
            // 
            // tbScannedRFIDStatus
            // 
            this.tbScannedRFIDStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScannedRFIDStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbScannedRFIDStatus.Location = new System.Drawing.Point(95, 139);
            this.tbScannedRFIDStatus.Name = "tbScannedRFIDStatus";
            this.tbScannedRFIDStatus.ReadOnly = true;
            this.tbScannedRFIDStatus.Size = new System.Drawing.Size(141, 20);
            this.tbScannedRFIDStatus.TabIndex = 3;
            // 
            // tbScannedRFDNmb
            // 
            this.tbScannedRFDNmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScannedRFDNmb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbScannedRFDNmb.Location = new System.Drawing.Point(95, 107);
            this.tbScannedRFDNmb.Name = "tbScannedRFDNmb";
            this.tbScannedRFDNmb.ReadOnly = true;
            this.tbScannedRFDNmb.Size = new System.Drawing.Size(141, 20);
            this.tbScannedRFDNmb.TabIndex = 2;
            // 
            // btnActivateReader
            // 
            this.btnActivateReader.Location = new System.Drawing.Point(5, 19);
            this.btnActivateReader.Name = "btnActivateReader";
            this.btnActivateReader.Size = new System.Drawing.Size(97, 26);
            this.btnActivateReader.TabIndex = 7;
            this.btnActivateReader.Text = "Activate Reader";
            this.btnActivateReader.UseVisualStyleBackColor = true;
            // 
            // lblScannedRfidStatus
            // 
            this.lblScannedRfidStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScannedRfidStatus.AutoSize = true;
            this.lblScannedRfidStatus.Location = new System.Drawing.Point(10, 142);
            this.lblScannedRfidStatus.Name = "lblScannedRfidStatus";
            this.lblScannedRfidStatus.Size = new System.Drawing.Size(68, 13);
            this.lblScannedRfidStatus.TabIndex = 1;
            this.lblScannedRfidStatus.Text = "RFID Status:";
            // 
            // lblScannedRfidNmb
            // 
            this.lblScannedRfidNmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScannedRfidNmb.AutoSize = true;
            this.lblScannedRfidNmb.Location = new System.Drawing.Point(10, 110);
            this.lblScannedRfidNmb.Name = "lblScannedRfidNmb";
            this.lblScannedRfidNmb.Size = new System.Drawing.Size(73, 13);
            this.lblScannedRfidNmb.TabIndex = 0;
            this.lblScannedRfidNmb.Text = "RFID number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSearchLog);
            this.groupBox1.Controls.Add(this.pnlMainSearch);
            this.groupBox1.Controls.Add(this.btnSearchVisitor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Visitor";
            // 
            // lbSearchLog
            // 
            this.lbSearchLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchLog.FormattingEnabled = true;
            this.lbSearchLog.Location = new System.Drawing.Point(6, 89);
            this.lbSearchLog.Name = "lbSearchLog";
            this.lbSearchLog.Size = new System.Drawing.Size(496, 82);
            this.lbSearchLog.TabIndex = 7;
            // 
            // tbVisitorEmail
            // 
            this.tbVisitorEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorEmail.Location = new System.Drawing.Point(92, 23);
            this.tbVisitorEmail.Name = "tbVisitorEmail";
            this.tbVisitorEmail.ReadOnly = true;
            this.tbVisitorEmail.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorEmail.TabIndex = 14;
            // 
            // lblVisitorEmail
            // 
            this.lblVisitorEmail.AutoSize = true;
            this.lblVisitorEmail.Location = new System.Drawing.Point(6, 27);
            this.lblVisitorEmail.Name = "lblVisitorEmail";
            this.lblVisitorEmail.Size = new System.Drawing.Size(35, 13);
            this.lblVisitorEmail.TabIndex = 13;
            this.lblVisitorEmail.Text = "Email:";
            // 
            // tbVisitorRFIDStatus
            // 
            this.tbVisitorRFIDStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorRFIDStatus.Location = new System.Drawing.Point(92, 183);
            this.tbVisitorRFIDStatus.Name = "tbVisitorRFIDStatus";
            this.tbVisitorRFIDStatus.ReadOnly = true;
            this.tbVisitorRFIDStatus.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorRFIDStatus.TabIndex = 16;
            // 
            // lblVisitorRFIDStatus
            // 
            this.lblVisitorRFIDStatus.AutoSize = true;
            this.lblVisitorRFIDStatus.Location = new System.Drawing.Point(6, 186);
            this.lblVisitorRFIDStatus.Name = "lblVisitorRFIDStatus";
            this.lblVisitorRFIDStatus.Size = new System.Drawing.Size(68, 13);
            this.lblVisitorRFIDStatus.TabIndex = 15;
            this.lblVisitorRFIDStatus.Text = "RFID Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbScannedRFID);
            this.Controls.Add(this.gbVisitorInfo);
            this.MinimumSize = new System.Drawing.Size(524, 538);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMainSearch.ResumeLayout(false);
            this.pnlMainSearch.PerformLayout();
            this.gbVisitorInfo.ResumeLayout(false);
            this.gbVisitorInfo.PerformLayout();
            this.gbScannedRFID.ResumeLayout(false);
            this.gbScannedRFID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRdrColorIndic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchVisitorText;
        private System.Windows.Forms.ComboBox cmbxSearchType;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Panel pnlMainSearch;
        private System.Windows.Forms.Button btnSearchVisitor;
        private System.Windows.Forms.GroupBox gbVisitorInfo;
        private System.Windows.Forms.GroupBox gbScannedRFID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVisitorCode;
        private System.Windows.Forms.Label lblVisitorLastName;
        private System.Windows.Forms.Label lblVisitorFirstName;
        private System.Windows.Forms.Button btnActivateReader;
        private System.Windows.Forms.TextBox tbScannedRFIDStatus;
        private System.Windows.Forms.TextBox tbScannedRFDNmb;
        private System.Windows.Forms.Label lblScannedRfidStatus;
        private System.Windows.Forms.Label lblScannedRfidNmb;
        private System.Windows.Forms.ListBox lbActivityLog;
        private System.Windows.Forms.Button btnStopReader;
        private System.Windows.Forms.PictureBox pcbxRdrColorIndic;
        private System.Windows.Forms.ListBox lbReaderLog;
        private System.Windows.Forms.Button btnAssignNewRfid;
        private System.Windows.Forms.TextBox tbVisitorRfid;
        private System.Windows.Forms.TextBox tbVisitorStatus;
        private System.Windows.Forms.TextBox tbVisitorCode;
        private System.Windows.Forms.TextBox tbVisitorLastName;
        private System.Windows.Forms.TextBox tbVisitorFirstName;
        private System.Windows.Forms.Label lblVisitorRfid;
        private System.Windows.Forms.Label lblVisitorStatus;
        private System.Windows.Forms.Button btnScanAgain;
        private System.Windows.Forms.Button btnDeactivateRFID;
        private System.Windows.Forms.ListBox lbSearchLog;
        private System.Windows.Forms.TextBox tbVisitorRFIDStatus;
        private System.Windows.Forms.Label lblVisitorRFIDStatus;
        private System.Windows.Forms.TextBox tbVisitorEmail;
        private System.Windows.Forms.Label lblVisitorEmail;
    }
}

