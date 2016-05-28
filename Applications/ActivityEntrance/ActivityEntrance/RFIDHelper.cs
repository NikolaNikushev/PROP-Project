using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityEntrance
{
    public class RFIDHelper
    {
        private RFID myRFIDReader;
        //public void InitialiseRFID()
        //{
        //    myRFIDReader = new RFID();
        //    myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
        //    myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
        //    myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);

        //}
        //private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        //{
        //    listBox1.Items.Add("RFIDReader attached!, serial nr: " + e.Device.SerialNumber.ToString());
        //}
        //private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        //{
        //    listBox1.Items.Add("RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString());
        //}

    }
}
