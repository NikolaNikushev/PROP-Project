using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletManagement
{
    class RFIDData: SomeAbstractData, IDataContainer
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
            private set;
        } 



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
            this.Status = DBHelper.getRFIDStatus(this.RFIDNumber);
        }

    }
}
