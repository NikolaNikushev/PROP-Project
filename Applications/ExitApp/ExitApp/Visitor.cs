using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitApp
{
    public class Visitor
    {
        // EMAIL FNA LNAME DOB BALANCE PAID BRACELET_ID CAMPING_ID STATUS
        private int user_id;
        private string password;
        private string email;
        private string fname;
        private string lname;
        private DateTime dob;
        private double balance;
        private bool paid;
        private string bracelet_id;
        private int camping_id;
        private int status;

        public Visitor(int u_id, string pass, string mail, string fnm, string lnm, DateTime db, double blnc, bool pay, string b_id, int c_id, int stat)
        {
            this.user_id = u_id;
            this.password = pass;
            this.email = mail;
            this.fname = fnm;
            this.lname = lnm;
            this.dob = db;
            this.balance = blnc;
            this.paid = pay;
            this.bracelet_id = b_id;
            this.camping_id = c_id;
            this.status = stat;
        }

        public string getInfo()
        {
            return this.user_id.ToString() + "- " + this.password + "- " + this.email + "- " + this.fname + "- " + this.lname + "- " + this.dob.ToString() + "- " + this.balance.ToString() + "- " + this.paid.ToString() + "- " + this.bracelet_id + "- " + this.camping_id.ToString() + "- " + this.status.ToString();
        }
    }
}
