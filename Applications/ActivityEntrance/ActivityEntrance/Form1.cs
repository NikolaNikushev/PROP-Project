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

namespace ActivityEntrance
{
    public partial class ActivityReservationForm : Form
    {
        private RFID myRFIDReader;
        private DBHelper myDBHelper = new DBHelper();
        public ActivityReservationForm()
        {
            InitializeComponent();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                listBox1.Items.Add("startup: so far so good.");
            }
            catch (PhidgetException) { listBox1.Items.Add("error at start-up."); }
        }

        private void open_RFID_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                listBox1.Items.Add("an RFID-reader is found and opened.");
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException) { listBox1.Items.Add("no RFID-reader opened."); }
        }

        private void close_RFID_Click(object sender, EventArgs e)
        {
            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();
            listBox1.Items.Add("RFID reader closed.");
        }
        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            listBox1.Items.Add("RFIDReader attached!, serial nr: " + e.Device.SerialNumber.ToString());
        }
        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            listBox1.Items.Add("RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString());
        }
        string temp;
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            try
            {
                temp = myDBHelper.IsReserved(e.Tag);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            listBox1.Items.Add("rfid has tag-nr: " + e.Tag + "  " + temp);
        }

    

    }
}
