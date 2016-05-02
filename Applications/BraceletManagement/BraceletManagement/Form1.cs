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
        private RFIDHelper myRFIDHelper;
        private VisitorData myVisitor;
        private RFIDData scannedRFID;
        private DBHelper myDBHelper;
        // to prevent accidentally scanning rfids
        private bool scannedOnce;
        private bool foundVisitor;

        private delegate void ManageBraceletHandler();
        private ManageBraceletHandler manageBracelet;

        public Form1()
        {
            InitializeComponent();
            myRFIDHelper = new RFIDHelper();
            cmbxSearchType.Items.Clear();
            myDBHelper = new DBHelper();
            this.foundVisitor = false;
            this.myRFIDHelper.myRFIDReader.Tag += new Phidgets.Events.TagEventHandler(UpdateScannedTag);

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
                    this.tbVisitorEmail.Text = this.myVisitor.Email;
                    this.tbVisitorCode.Text = this.myVisitor.Code;
                    this.tbVisitorFirstName.Text = this.myVisitor.FirstName;
                    this.tbVisitorLastName.Text = this.myVisitor.LastName;
                    this.tbVisitorRfid.Text = this.myVisitor.ChipNumber;
                    this.tbVisitorStatus.Text = this.myVisitor.Status.ToString();
                    this.tbVisitorRFIDStatus.Text = this.myVisitor.RFIDStatus.ToString();
                    this.lbSearchLog.Items.Insert(0, System.DateTime.Now + " Search found visitor " + this.myVisitor.FirstName + " " + this.myVisitor.LastName);
                }
                else
                {
                    this.lbSearchLog.Items.Insert(0, System.DateTime.Now + " Search returned no visitors");
                }
            }
            else
            {
                this.lbSearchLog.Items.Insert(0, System.DateTime.Now + " Search unsuccessful");
            }

        }

        private void btnActivateReader_Click(object sender, EventArgs e)
        {
            this.lbReaderLog.Items.Insert(0, myRFIDHelper.StartConnection());
        }

        private void btnStopReader_Click(object sender, EventArgs e)
        {
            this.lbReaderLog.Items.Insert(0, myRFIDHelper.StopConnection());
        }

        private void UpdateScannedTag(object sender, TagEventArgs e)
        {
            if (scannedOnce == false)
            {
                this.scannedRFID = this.myRFIDHelper.RetrievedBraceletData;
                this.tbScannedRFDNmb.Text = scannedRFID.RFIDNumber;
                this.tbScannedRFIDStatus.Text = scannedRFID.Status.ToString();
                if (this.scannedRFID.Status != StatusTypes.BraceletStatus.NOT_VALID)
                {
                    lbReaderLog.Items.Insert(0, ">> Retrieved and RFID #:" + scannedRFID.RFIDNumber);
                    scannedOnce = true;
                }
                else
                {
                    lbReaderLog.Items.Insert(0, "<< Or something went wrong");
                    lbReaderLog.Items.Insert(0, "<< Scanned RFID is not valid");
                    scannedOnce = false;
                }
            }
            else
            {
                lbReaderLog.Items.Insert(0, "<< Press the button to scan again.");
                lbReaderLog.Items.Insert(0, "<< You have already scanned once.");
            }

        }

        private void btnScanAgain_Click(object sender, EventArgs e)
        {
            this.scannedOnce = false;
        }

        private void btnDeactivateRFID_Click(object sender, EventArgs e)
        {
            if (this.foundVisitor)
            {
                this.manageBracelet = new ManageBraceletHandler(this.DeactiveVisBracelet);

                manageBracelet();
            }

        }

        private void btnAssignNewRfid_Click(object sender, EventArgs e)
        {
            if (this.foundVisitor)
            {
                this.manageBracelet = new ManageBraceletHandler(this.AssignVisBracelet);

                manageBracelet();
            }
        }






        /// <summary>
        ///  Will and has to be executed only if the user has the bracelet.
        /// If he does not posses one, it will be ignored
        /// </summary>
        private void DeactiveVisBracelet()
        {
            if (myVisitor.ChipNumber != "NULL")
            {
                //then we can deactivate his current bracelet. for that we use the dbhelper
                if (this.myDBHelper.DeactivateBracelet(this.myVisitor.ChipNumber,this.myVisitor.Code))
                {
                    this.myVisitor.SetRFIDStatus(this.myDBHelper.getRFIDStatus(this.myVisitor.ChipNumber));
                    this.tbVisitorRFIDStatus.Text = this.myVisitor.RFIDStatus.ToString();
                    this.lbActivityLog.Items.Insert(0, ">> Sucessfully deactivated");
                }
                else
                {
                    this.lbActivityLog.Items.Insert(0, "<< Something went wrong");
                }
            }
            else
            {
                this.lbActivityLog.Items.Insert(0, "<< Visitor has no bracelet");
            }
        }

        private void AssignVisBracelet()
        {
            this.DeactiveVisBracelet();
            //new method
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myRFIDHelper.StopConnection();
        }
    }
}
