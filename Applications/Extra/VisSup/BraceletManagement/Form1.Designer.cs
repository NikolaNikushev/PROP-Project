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
            this.tbVisitorRFIDStatus = new System.Windows.Forms.TextBox();
            this.lblVisitorRFIDStatus = new System.Windows.Forms.Label();
            this.tbVisitorEmail = new System.Windows.Forms.TextBox();
            this.lblVisitorEmail = new System.Windows.Forms.Label();
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
            this.gbPayments = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSearchLog = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPaymentLog = new System.Windows.Forms.ListBox();
            this.btnGetPaymentsData = new System.Windows.Forms.Button();
            this.btnSavePaymentData = new System.Windows.Forms.Button();
            this.btnUpdateVisData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMainSearch.SuspendLayout();
            this.gbVisitorInfo.SuspendLayout();
            this.gbPayments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchVisitorText
            // 
            this.tbSearchVisitorText.Location = new System.Drawing.Point(178, 5);
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
            this.pnlMainSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainSearch.Location = new System.Drawing.Point(3, 16);
            this.pnlMainSearch.Name = "pnlMainSearch";
            this.pnlMainSearch.Size = new System.Drawing.Size(502, 29);
            this.pnlMainSearch.TabIndex = 4;
            // 
            // btnSearchVisitor
            // 
            this.btnSearchVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchVisitor.Location = new System.Drawing.Point(339, 48);
            this.btnSearchVisitor.Name = "btnSearchVisitor";
            this.btnSearchVisitor.Size = new System.Drawing.Size(166, 29);
            this.btnSearchVisitor.TabIndex = 6;
            this.btnSearchVisitor.Text = "Search";
            this.btnSearchVisitor.UseVisualStyleBackColor = true;
            this.btnSearchVisitor.Click += new System.EventHandler(this.btnSearchVisitor_Click);
            // 
            // gbVisitorInfo
            // 
            this.gbVisitorInfo.Controls.Add(this.btnUpdateVisData);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorRFIDStatus);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorRFIDStatus);
            this.gbVisitorInfo.Controls.Add(this.tbVisitorEmail);
            this.gbVisitorInfo.Controls.Add(this.lblVisitorEmail);
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
            this.gbVisitorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisitorInfo.Location = new System.Drawing.Point(0, 0);
            this.gbVisitorInfo.Name = "gbVisitorInfo";
            this.gbVisitorInfo.Size = new System.Drawing.Size(256, 390);
            this.gbVisitorInfo.TabIndex = 7;
            this.gbVisitorInfo.TabStop = false;
            this.gbVisitorInfo.Text = "Visitor";
            // 
            // tbVisitorRFIDStatus
            // 
            this.tbVisitorRFIDStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorRFIDStatus.Location = new System.Drawing.Point(111, 184);
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
            // tbVisitorEmail
            // 
            this.tbVisitorEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbVisitorEmail.Location = new System.Drawing.Point(111, 24);
            this.tbVisitorEmail.Name = "tbVisitorEmail";
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
            // tbVisitorRfid
            // 
            this.tbVisitorRfid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorRfid.Location = new System.Drawing.Point(111, 156);
            this.tbVisitorRfid.Name = "tbVisitorRfid";
            this.tbVisitorRfid.ReadOnly = true;
            this.tbVisitorRfid.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorRfid.TabIndex = 10;
            // 
            // tbVisitorStatus
            // 
            this.tbVisitorStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorStatus.Location = new System.Drawing.Point(111, 130);
            this.tbVisitorStatus.Name = "tbVisitorStatus";
            this.tbVisitorStatus.ReadOnly = true;
            this.tbVisitorStatus.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorStatus.TabIndex = 9;
            // 
            // tbVisitorCode
            // 
            this.tbVisitorCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVisitorCode.Location = new System.Drawing.Point(111, 104);
            this.tbVisitorCode.Name = "tbVisitorCode";
            this.tbVisitorCode.ReadOnly = true;
            this.tbVisitorCode.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorCode.TabIndex = 8;
            // 
            // tbVisitorLastName
            // 
            this.tbVisitorLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbVisitorLastName.Location = new System.Drawing.Point(111, 78);
            this.tbVisitorLastName.Name = "tbVisitorLastName";
            this.tbVisitorLastName.Size = new System.Drawing.Size(133, 20);
            this.tbVisitorLastName.TabIndex = 7;
            // 
            // tbVisitorFirstName
            // 
            this.tbVisitorFirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbVisitorFirstName.Location = new System.Drawing.Point(111, 52);
            this.tbVisitorFirstName.Name = "tbVisitorFirstName";
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
            this.lbActivityLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbActivityLog.FormattingEnabled = true;
            this.lbActivityLog.Location = new System.Drawing.Point(3, 266);
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
            // gbPayments
            // 
            this.gbPayments.Controls.Add(this.lbPaymentLog);
            this.gbPayments.Controls.Add(this.panel1);
            this.gbPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPayments.Location = new System.Drawing.Point(0, 0);
            this.gbPayments.Name = "gbPayments";
            this.gbPayments.Size = new System.Drawing.Size(252, 390);
            this.gbPayments.TabIndex = 8;
            this.gbPayments.TabStop = false;
            this.gbPayments.Text = "Payments";
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
            this.lbSearchLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbSearchLog.FormattingEnabled = true;
            this.lbSearchLog.Location = new System.Drawing.Point(3, 94);
            this.lbSearchLog.Name = "lbSearchLog";
            this.lbSearchLog.Size = new System.Drawing.Size(502, 82);
            this.lbSearchLog.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSavePaymentData);
            this.panel1.Controls.Add(this.btnGetPaymentsData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 52);
            this.panel1.TabIndex = 0;
            // 
            // lbPaymentLog
            // 
            this.lbPaymentLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPaymentLog.FormattingEnabled = true;
            this.lbPaymentLog.Location = new System.Drawing.Point(3, 68);
            this.lbPaymentLog.Name = "lbPaymentLog";
            this.lbPaymentLog.Size = new System.Drawing.Size(246, 319);
            this.lbPaymentLog.TabIndex = 1;
            // 
            // btnGetPaymentsData
            // 
            this.btnGetPaymentsData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPaymentsData.Location = new System.Drawing.Point(3, 3);
            this.btnGetPaymentsData.Name = "btnGetPaymentsData";
            this.btnGetPaymentsData.Size = new System.Drawing.Size(94, 46);
            this.btnGetPaymentsData.TabIndex = 0;
            this.btnGetPaymentsData.Text = "Get Payments";
            this.btnGetPaymentsData.UseVisualStyleBackColor = true;
            // 
            // btnSavePaymentData
            // 
            this.btnSavePaymentData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePaymentData.Location = new System.Drawing.Point(147, 3);
            this.btnSavePaymentData.Name = "btnSavePaymentData";
            this.btnSavePaymentData.Size = new System.Drawing.Size(94, 46);
            this.btnSavePaymentData.TabIndex = 1;
            this.btnSavePaymentData.Text = "Save as .txt";
            this.btnSavePaymentData.UseVisualStyleBackColor = true;
            // 
            // btnUpdateVisData
            // 
            this.btnUpdateVisData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVisData.Location = new System.Drawing.Point(9, 223);
            this.btnUpdateVisData.Name = "btnUpdateVisData";
            this.btnUpdateVisData.Size = new System.Drawing.Size(235, 23);
            this.btnUpdateVisData.TabIndex = 17;
            this.btnUpdateVisData.Text = "Update Data";
            this.btnUpdateVisData.UseVisualStyleBackColor = true;
            this.btnUpdateVisData.Click += new System.EventHandler(this.btnUpdateVisData_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbVisitorInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 390);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbPayments);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(256, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 390);
            this.panel3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(524, 538);
            this.Name = "Form1";
            this.Text = "Visitor Support";
            this.pnlMainSearch.ResumeLayout(false);
            this.pnlMainSearch.PerformLayout();
            this.gbVisitorInfo.ResumeLayout(false);
            this.gbVisitorInfo.PerformLayout();
            this.gbPayments.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchVisitorText;
        private System.Windows.Forms.ComboBox cmbxSearchType;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Panel pnlMainSearch;
        private System.Windows.Forms.Button btnSearchVisitor;
        private System.Windows.Forms.GroupBox gbVisitorInfo;
        private System.Windows.Forms.GroupBox gbPayments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVisitorCode;
        private System.Windows.Forms.Label lblVisitorLastName;
        private System.Windows.Forms.Label lblVisitorFirstName;
        private System.Windows.Forms.ListBox lbActivityLog;
        private System.Windows.Forms.TextBox tbVisitorRfid;
        private System.Windows.Forms.TextBox tbVisitorStatus;
        private System.Windows.Forms.TextBox tbVisitorCode;
        private System.Windows.Forms.TextBox tbVisitorLastName;
        private System.Windows.Forms.TextBox tbVisitorFirstName;
        private System.Windows.Forms.Label lblVisitorRfid;
        private System.Windows.Forms.Label lblVisitorStatus;
        private System.Windows.Forms.ListBox lbSearchLog;
        private System.Windows.Forms.TextBox tbVisitorRFIDStatus;
        private System.Windows.Forms.Label lblVisitorRFIDStatus;
        private System.Windows.Forms.TextBox tbVisitorEmail;
        private System.Windows.Forms.Label lblVisitorEmail;
        private System.Windows.Forms.Button btnUpdateVisData;
        private System.Windows.Forms.ListBox lbPaymentLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSavePaymentData;
        private System.Windows.Forms.Button btnGetPaymentsData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

