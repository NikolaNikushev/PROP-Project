using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;

namespace BraceletManagement
{
    class RFIDReader
    {
        //--------Properties and Fields:

        public String InitializationResult
        {
            get;
            private set;
        }
        public RFID myRFID;


        //--------Constructors:

        public RFIDReader()
        {
            try
            {
                myRFID = new RFID();
                InitializationResult = "Successful connection";
            }
            catch
            {
                InitializationResult = "Unsuccessful connection";
            }
        }
        



    }
}
