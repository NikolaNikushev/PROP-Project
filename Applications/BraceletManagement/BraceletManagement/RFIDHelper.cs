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
        public RFID myRFIDReader
        {
            get;
            private set;
        }

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
                // event! 
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);

                StringResultRep = "Successful connection";
            }
            catch
            {
                StringResultRep = "Unsuccessful connection";
            }
        }

        /// <summary>
        /// Tries to start the connection, returns the string depicting the failure
        /// </summary>
        /// <returns></returns>
        public string StartConnection()
        {
            string methodResult = "";
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;

                methodResult = "RFID-reader is found and opened.";
            }
            catch (PhidgetException)
            {
                methodResult = "RFID-reader could not be opened.";
            }
            return methodResult;
        }


        public string StopConnection()
        {
            string methodResult = "";
            try
            {
                myRFIDReader.LED = false;
                myRFIDReader.Antenna = false;
                myRFIDReader.close();
                methodResult = "RFID-reader is closed.";
            }
            catch
            {
                methodResult = "RFID-reader can not be closed.";
            }

            return methodResult;
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            this.RetrievedBraceletData = new RFIDData(e.Tag.ToString());
        }


    }
}
