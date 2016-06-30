using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityEntrance
{
    public class RFIDHelper
    {
        private RFID myRFIDReader;
        //private ActivityReservationForm arf = new ActivityReservationForm();
        public void InitialiseRFID()
        {
            myRFIDReader = new RFID();
            myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
            //myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
            //myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);

        }
        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
       
        }
        //private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        //{
        //    listBox1.Items.Add("RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString());
        //}

    }
}
