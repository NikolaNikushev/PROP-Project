using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace BraceletManagement
{
    public partial class Form1 : Form
    {
        private VisitorData myVisitor;
        private DBHelper myDBHelper;
        private bool foundVisitor;


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
            this.foundVisitor = false;
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
                    foundVisitor = true;
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
                }
            }
            else
            {
                this.lbSearchLog.Items.Insert(0, System.DateTime.Now + " Search unsuccessful");
                this.gbPayments.Enabled = false;
                this.gbVisitorInfo.Enabled = false;
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
    }
}
