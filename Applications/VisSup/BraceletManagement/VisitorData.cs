using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletManagement
{
    public class VisitorData
    {

        //--------Properties and Fields:
        // it has all the following properties of the visitor: 
        // EMAIL, FNAME, LNAME, SECCODE, BRACELET_ID, STATUS

        public int UserId
        {
            get;
            private set;
        }

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
        public List<Payment> ListPayments
        {
            get; private set;
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
        public VisitorData(int id, string email, string fName, string lName, string secCode, string chipNum, int visitStatus)
        {
            this.UserId = id;
            this.Email = email;
            this.FirstName = fName;
            this.LastName = lName;
            this.Code = secCode;
            this.ChipNumber = chipNum;
            this.Status = (StatusTypes.visitStatus)visitStatus;
            this.ListPayments = new List<Payment>();

            if (chipNum != "NULL")
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

        public bool UpdateData(string em = "", string fn = "", string ln = "")
        {
            return this.myDBHelper.UpdateVisitorData(this.UserId, em, fn, ln);
        }

        public void FillPayments()
        {
            this.ListPayments = this.myDBHelper.GetPaymentLog(this.UserId);
        }

    }

    public class Payment
    {// used to store the data about the payments done by the visitor
        //DATE as PAYTIME, TYPE as REASON, PAYSUM as AMOUNT, DESCRIPTION
        public DateTime Paytime
        {
            get; private set;
        }
        public string Reason
        {
            get; private set;
        }
        public int Amount
        {
            get; private set;
        }
        public string Desription
        {
            get; private set;
        }
        /// <summary>
        /// used to store the data about all the payments done by the visitor
        /// including shops and services
        /// </summary>
        /// <param name="paytime"></param>
        /// <param name="reason"></param>
        /// <param name="amount"></param>
        /// <param name="desription"></param>
        public Payment(DateTime paytime, string reason, int amount, string desription)
        {
            this.Amount = amount;
            this.Desription = desription;
            this.Paytime = paytime;
            this.Reason = reason;
        }

        public override string ToString()
        {
            return this.Paytime + ": " + this.Amount + System.Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol + " at " + this.Reason + "; " + this.Desription;
        }

    }


    public class EmailClashException : Exception
    {
        public EmailClashException()
        {
        }

        public EmailClashException(string message)
            : base(message)
        {
        }
    }
}
