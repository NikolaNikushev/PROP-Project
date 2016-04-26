using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;

namespace BraceletManagement
{
    class RFIDHelper
    {
        //--------Properties and Fields:

        public String StringResultRep
        {
            get;
            private set;
        }
        // the reader itself - the class RFIDReader is just an overlay of all the dirty work
        private RFID myRFIDReader;
        public RFIDData RetrievedBraceletData
        {
            get;
            private set;
        }


        //--------Constructors:

        public RFIDHelper()
        {
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                StringResultRep = "Successful connection";
            }
            catch
            {
                StringResultRep = "Unsuccessful connection";
            }
        }

        public string StartConnection()
        {
            string methodResult = "";
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;

                methodResult = "an RFID-reader is found and opened.";
            }
            catch (PhidgetException)
            {
                methodResult = "RFID-reader could not be opened.";
            }
            return methodResult;
        }


        public string CloseConnection()
        {
            string methodResult = "";

            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();

            methodResult = "an RFID-reader is closed.";

            return methodResult;
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            this.RetrievedBraceletData = new RFIDData(e.Tag);
        }


    }
}
