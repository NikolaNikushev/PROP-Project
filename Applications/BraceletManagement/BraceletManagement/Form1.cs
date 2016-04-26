using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BraceletManagement
{
    public partial class Form1 : Form
    {
        private RFIDHelper myRFIDHelper;
        private VisitorData myVisitor;
        private RFIDData scannedRFID;
       

        public Form1()
        {
            InitializeComponent();
            myRFIDHelper = new RFIDHelper();
            cmbxSearchType.Items.Clear();
            // solution from StackOverflow
            foreach(var searchType in Enum.GetValues(typeof(StatusTypes.SearchType)))
            {
                cmbxSearchType.Items.Add(searchType);
            }
        }

        private void btnSearchVisitor_Click(object sender, EventArgs e)
        {
            if(this.cmbxSearchType.SelectedItem != null && this.tbSearchVisitorText.Text != "")
            {
                // searchs for a correct visitor
                myVisitor = DBHelper.getVisitorData((StatusTypes.SearchType)this.cmbxSearchType.SelectedItem, this.tbSearchVisitorText.Text);
                if(myVisitor != null)
                {
                    this.tbVisitorEmail.Text = this.myVisitor.Email;
                    this.tbVisitorCode.Text = this.myVisitor.Code;
                    this.tbVisitorFirstName.Text = this.myVisitor.FirstName;
                    this.tbVisitorLastName.Text = this.myVisitor.LastName;
                    this.tbVisitorRfid.Text = this.myVisitor.ChipNumber;
                    this.tbVisitorStatus.Text = this.myVisitor.Status.ToString();
                    this.tbVisitorRFIDStatus.Text = this.myVisitor.RFIDStatus.ToString();
                }
                else
                {
                    this.lbSearchLog.Items.Insert(0, "Search returned no visitors");
                }
            }
            else
            {
                this.lbSearchLog.Items.Insert(0, "Search unsuccessful");
            }
            
        }
    }
}
