using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletManagement
{
    class VisitorData: SomeAbstractData
    {

        //--------Properties and Fields:
        // it has all the following properties of the visitor: 
        // EMAIL, FNAME, LNAME, SECCODE, BRACELET_ID, STATUS

        public String Email
        {
            get;
            private set;
        }
        public String FirstName
        {
            get;
            private set;
        }
        public String LastName
        {
            get;
            private set;
        }
        public String Code
        {
            get;
            private set;
        }
        public String ChipNumber
        {
            get;
            private set;
        }
        // this way we will store all the data for the RFID of this guy
        public StatusTypes.BraceletStatus RFIDStatus
        {
            get;
            private set;
        }
        // 0 or 1 originally, but is redirected to the StatusTypes
        public StatusTypes.visitStatus Status
        {
            get;
            private set;
        }
        private DBHelper myDBHelper = new DBHelper();

        //--------Constructors:

        // in fact it does not work like that! :( 
        //T_T T_T T_T T_T T_T T_T T__T T_T T_T T_T T_T T__T T_T T_T
        ///// <summary>
        ///// Get all the value by searching
        ///// </summary>
        ///// <param name="searchBy"></param>
        ///// <param name="searchValue"></param>
        //public VisitorData(StatusTypes.SearchType searchBy, string searchValue)
        //{
        //    DBHelper.getVisitorData(searchBy, searchValue);

        //}


        /// <summary>
        /// Filling each attribute manually
        /// Reserved for the DBHelper, not really to be used anywhere else
        /// </summary>
        /// <param name="email"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="Code"></param>
        /// <param name="ChipNum"></param>
        /// <param name="visitStatus"></param>
        public VisitorData(string email, string fName, string lName, string secCode, string chipNum, int visitStatus)
        {
            this.Email = email;
            this.FirstName = fName;
            this.LastName = lName;
            this.Code = secCode;
            this.ChipNumber = chipNum;
            this.Status = (StatusTypes.visitStatus)visitStatus;
            
            if(chipNum!= "NULL")
            {
                this.RFIDStatus = myDBHelper.getRFIDStatus(chipNum);
            }
            else
            {
                this.RFIDStatus = StatusTypes.BraceletStatus.NOT_VALID;
            }
            // that's all we've got folks
        }

        public void SetRFIDStatus(StatusTypes.BraceletStatus newStatus)
        {
            this.RFIDStatus = newStatus;
        }


    }
}
