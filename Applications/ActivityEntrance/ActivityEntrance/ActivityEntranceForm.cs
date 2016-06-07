using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace ActivityEntrance
{

    public partial class ActivityEntranceForm : Form
    {
        private RFID myRFIDReader;
        public DBHelper myDBHelper;
        private string RFIDTag;
        public string activityID;
        public ActivityEntranceForm()
        {
            InitializeComponent();

            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                statusValue.Text = "Running ..";
            }
            catch (PhidgetException) { statusValue.Text = "Error at start"; }


        }

        //making the controls I need accesible, so i can use them in the other form 
        public string ActivityName
        {
            get
            {
                return activityName.Text;
            }
            set
            {
                activityName.Text = value;
            }
        }
        public string ActivityDate
        {
            get
            {
                return activityDate.Text;
            }
            set
            {
                activityDate.Text = value;
            }

        }
        public string TotalPlaces
        {
            get
            {
                return totalPlaces.Text;
            }
            set
            {
                totalPlaces.Text = value;
            }
        }
        public string ReservedPlaces
        {
            get
            {
                return reservedPlaces.Text;
            }
            set
            {
                reservedPlaces.Text = value;
            }
        }
        public string FreePlaces
        {
            get
            {
                return freePlaces.Text;
            }
            set
            {
                freePlaces.Text = value;
            }
        }

        private void open_RFID_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                statusValue.Text = "Opened";
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException) { statusValue.Text = "Error, couldn't open reader"; }
        }

        private void close_RFID_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.LED = false;
                myRFIDReader.Antenna = false;
                myRFIDReader.close();
                statusValue.Text = "Reader closed";
            }
            catch (Exception)
            {
                statusValue.Text = "Error occured on closing";
            }

        }
        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            readerNumberValue.Text = e.Device.SerialNumber.ToString();

        }
        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            readerNumberValue.Text = e.Device.SerialNumber.ToString() + " - Detached";
        }
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            string braceletData;
            try
            {

                RFIDTag = e.Tag;
                braceletData = myDBHelper.RetrieveBraceletData(RFIDTag);
                typeOfPlace.Text = braceletData;
                braceletSerialNumber.Text = RFIDTag;
                proceedButton.Enabled = true;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            // here I change some labels and and execute update queries to the database
            List<string> placesData = new List<string>();
            userInfo.Text = myDBHelper.Entrance(RFIDTag);
            placesData = myDBHelper.RetrievePlacesDetails(activityID);
            TotalPlaces = placesData[0];
            ReservedPlaces = placesData[1];
            FreePlaces = placesData[2];
            braceletSerialNumber.Text = "Scan bracelet...";
            typeOfPlace.Text = "N/A";
            proceedButton.Enabled = false;
        }

        private void ActivityEntranceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
