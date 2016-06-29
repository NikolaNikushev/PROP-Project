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
                    // replaced by a method
                    UpdateVisitorInfo();
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
                // assign the according method to the delegate
                this.manageBracelet = new ManageBraceletHandler(this.DeactiveVisBracelet);

                manageBracelet();
            }

        }

        private void btnAssignNewRfid_Click(object sender, EventArgs e)
        {
            if (this.foundVisitor)
            {
                // assign the according method to the delegate
                this.manageBracelet = new ManageBraceletHandler(this.AssignVisBracelet);
                
                manageBracelet();
            }
        }






        /// <summary>
        /// Deacivates the bracelet retrieved from the visitor data
        ///  Will and has to be executed only if the user has the bracelet.
        /// If he does not posses one, it will be ignored
        /// </summary>
        private void DeactiveVisBracelet()
        {
            if (myVisitor.ChipNumber != "NULL" && myVisitor.RFIDStatus == StatusTypes.BraceletStatus.ACTIVE)
            {
                //then we can deactivate his current bracelet. for that we use the dbhelper
                if (this.myDBHelper.DeactivateBracelet(this.myVisitor.ChipNumber))
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
                this.lbActivityLog.Items.Insert(0, "<< Visitor has no active bracelet");
            }
        }

        private void DeactivateScannedBracelet()
        {
            if (scannedRFID != null && scannedRFID.Status == StatusTypes.BraceletStatus.ACTIVE)
            {
                //then we can deactivate his current bracelet. for that we use the dbhelper
                if (this.myDBHelper.DeactivateBracelet(this.scannedRFID.RFIDNumber))
                {
                    if(myVisitor != null && myVisitor.ChipNumber == scannedRFID.RFIDNumber)
                    {
                        this.myVisitor.SetRFIDStatus(this.myDBHelper.getRFIDStatus(this.myVisitor.ChipNumber));
                        this.tbVisitorRFIDStatus.Text = this.myVisitor.RFIDStatus.ToString();
                        this.lbActivityLog.Items.Insert(0, ">> Bracelet was deactivated for: " + myVisitor.FirstName + " " + myVisitor.LastName);
                    }
                    this.scannedRFID.Status = StatusTypes.BraceletStatus.DEACTIVATED;
                    this.tbScannedRFIDStatus.Text = this.scannedRFID.Status.ToString();
                    this.lbReaderLog.Items.Insert(0, ">> Successfully deactivated bracelet #: " + this.scannedRFID.RFIDNumber);
                }
                else
                {
                    this.lbReaderLog.Items.Insert(0, "<< Something went wrong");
                }
            }
            else
            {
                this.lbReaderLog.Items.Insert(0, "<< This bracelet is not activated");
            }
        }

        /// <summary>
        /// Assigns a new bracelet to the visitor
        /// </summary>
        private void AssignVisBracelet()
        {
            // first we deactivate his old one
            this.DeactiveVisBracelet();
            //new method
            try
            {
                if (this.scannedRFID.RFIDNumber != this.myVisitor.ChipNumber &&
                                (this.scannedRFID.Status == StatusTypes.BraceletStatus.STAND_BY || this.scannedRFID.Status == StatusTypes.BraceletStatus.NOT_VALID))
                {
                    if (this.myDBHelper.UpdateVisitorBracelet(this.scannedRFID, this.myVisitor.Email))
                    {
                        string email = this.myVisitor.Email;
                        myVisitor = myDBHelper.getVisitorData(StatusTypes.SearchType.EMAIL, email);
                        UpdateVisitorInfo();
                        // kinda bad to access it directly, but alright for now
                        this.scannedRFID.Status = StatusTypes.BraceletStatus.ACTIVE;
                        this.tbScannedRFIDStatus.Text = this.scannedRFID.Status.ToString();
                        this.lbActivityLog.Items.Insert(0, ">> Sucessfully Assigned");
                        this.lbReaderLog.Items.Insert(0, ">> Sucessfully Assigned");
                    }
                    else
                    {
                        lbReaderLog.Items.Insert(0, "<< Could not assign");
                    }
                }
                else
                {
                    AutoClosingMessageBox.Show("This Bracelet can not be assigned, please scan a new one!", "NOT A VALID BRACELET", 1000);
                    lbReaderLog.Items.Insert(0, "<< Tried to assign a not-valid bracelet");
                }
            }
            catch
            {
                AutoClosingMessageBox.Show("Something went wrong", "NOT A VALID BRACELET", 1000);
                lbReaderLog.Items.Insert(0, "<< Operation abort");
            }
            
        }

        private void btnDeactivateScannedBrac_Click(object sender, EventArgs e)
        {
            if(this.scannedRFID != null)
            {
                this.manageBracelet = new ManageBraceletHandler(this.DeactivateScannedBracelet);

                manageBracelet();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myRFIDHelper.StopConnection();
        }



        
    }
}
