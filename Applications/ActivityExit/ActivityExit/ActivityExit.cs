using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;


namespace ActivityExit
{
    public partial class ActivityExit : Form
    {

        private RFID myRFIDReader;
        public DBHelper myDBHelper;
        public string selectedItem;
        string RFIDTag;
        public ActivityExit()
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
            try
            {
                RFIDTag = e.Tag;
                serialNumer.Text = RFIDTag;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        

        
        private void open_RFID_Click_1(object sender, EventArgs e)
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

        private void close_RFID_Click_1(object sender, EventArgs e)
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

        private void ActivityExit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            myDBHelper.IncreasePlaces(selectedItem);
           response.Text = myDBHelper.InsertIntoHistory(RFIDTag);
            //izvikvame metod na koito podavame taga i selectirame neshtata na koito otgovarq tva neshto
            // ot braceleta vzimame usera, ot usera activity idto i posle tva za maxa
        }
    }
}
