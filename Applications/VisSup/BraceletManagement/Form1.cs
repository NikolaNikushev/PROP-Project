using System;
using System.Windows.Forms;

namespace BraceletManagement
{
    public partial class Form1 : Form
    {
        private VisitorData myVisitor;
        private DBHelper myDBHelper;


        private void UpdateVisitorInfo()
        {
            this.tbVisitorEmail.Text = this.myVisitor.Email;
            this.tbVisitorCode.Text = this.myVisitor.Code;
            this.tbVisitorFirstName.Text = this.myVisitor.FirstName;
            this.tbVisitorLastName.Text = this.myVisitor.LastName;
            this.tbVisitorRfid.Text = this.myVisitor.ChipNumber;
            this.tbVisitorStatus.Text = this.myVisitor.Status.ToString();
            this.tbVisitorRFIDStatus.Text = this.myVisitor.RFIDStatus.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            cmbxSearchType.Items.Clear();
            myDBHelper = new DBHelper();
            this.gbPayments.Enabled = false;
            this.gbVisitorInfo.Enabled = false;
            // solution from StackOverflow
            foreach (var searchType in Enum.GetValues(typeof(StatusTypes.SearchType)))
            {
                cmbxSearchType.Items.Add(searchType);
            }
        }

        private void btnSearchVisitor_Click(object sender, EventArgs e)
        {
            if (this.cmbxSearchType.SelectedItem != null && this.tbSearchVisitorText.Text != "")
            {
                // searchs for a correct visitor
                myVisitor = myDBHelper.getVisitorData((StatusTypes.SearchType)this.cmbxSearchType.SelectedItem, this.tbSearchVisitorText.Text);
                if (myVisitor != null)
                {
                    // replaced by a method
                    UpdateVisitorInfo();
                    this.lbSearchLog.Items.Insert(0, System.DateTime.Now + " Search found visitor " + this.myVisitor.FirstName + " " + this.myVisitor.LastName);
                    this.gbVisitorInfo.Enabled = true;
                    this.gbPayments.Enabled = true;
                }
                else
                {
                    this.lbSearchLog.Items.Insert(0, System.DateTime.Now + " Search returned no visitors");
                    this.gbPayments.Enabled = false;
                    this.gbVisitorInfo.Enabled = false;
                    this.lbPaymentLog.Items.Clear();
                }
            }
            else
            {
                this.lbSearchLog.Items.Insert(0, System.DateTime.Now + " Search unsuccessful");
                this.gbPayments.Enabled = false;
                this.gbVisitorInfo.Enabled = false;
                this.lbPaymentLog.Items.Clear();
            }

        }

        private void btnUpdateVisData_Click(object sender, EventArgs e)
        {
           
                if(this.myVisitor.UpdateData(this.tbVisitorEmail.Text, this.tbVisitorFirstName.Text, this.tbVisitorLastName.Text))
                {
                    this.lbActivityLog.Items.Insert(0, System.DateTime.Now + " Updated account");
            }
            else
            {
                this.lbActivityLog.Items.Insert(0, System.DateTime.Now + " Something went wrong, couldn't update account");
            }
        }

        private void btnGetPaymentsData_Click(object sender, EventArgs e)
        {
            if(myVisitor!=null)
            {
                this.myVisitor.FillPayments();
                this.lbPaymentLog.Items.AddRange(this.myVisitor.ListPayments.ToArray());
            }
        }

        private void btnSavePaymentData_Click(object sender, EventArgs e)
        {
            this.sfdPaymentLogExport.Title = "Save your text";
            //saveFileDialog1.CheckFileExists = true;
            //saveFileDialog1.CheckPathExists = true;
            // sets a filter for the files displayed in the dialog
            this.sfdPaymentLogExport.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.sfdPaymentLogExport.DefaultExt = "txt";
            this.sfdPaymentLogExport.RestoreDirectory = true;
            String FilePath = "";
            String[] paymentLines = new String[this.myVisitor.ListPayments.Count];
            int i = 0;
            foreach (Payment p in this.myVisitor.ListPayments)
            {
                paymentLines[i] = p.ToString();
                i++;
            }

            if (this.sfdPaymentLogExport.ShowDialog() == DialogResult.OK)
            {
                FilePath = this.sfdPaymentLogExport.FileName;
                TextFileHelper.TextFileHelper.SaveFile(FilePath, paymentLines);
            }
        }
    }
}
