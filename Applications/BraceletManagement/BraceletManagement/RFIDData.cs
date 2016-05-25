using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletManagement
{
    public class RFIDData: SomeAbstractData
    {
        //--------Properties and Fields:
        public String RFIDNumber
        {
            get;
            private set;
        }


        public StatusTypes.BraceletStatus Status
        {
            get;
            set;
        }

        private DBHelper myDBHelper = new DBHelper();


        //--------Methods:

        //private StatusTypes.BraceletStatus GetStatus(string chipNum)
        //{
        //    //Database interaction here:
        //    StatusTypes.BraceletStatus tempData = DBHelper.getRFIDStatus(this.RFIDNumber);
        //    return tempData;
        //}

        //--------Constructors:

        public RFIDData(string rfidNumber)
        {
            this.RFIDNumber = rfidNumber;
            this.Status = myDBHelper.getRFIDStatus(this.RFIDNumber);
        }

    }
}
