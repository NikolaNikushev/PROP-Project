using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace WAvisitorCheck
{
    public partial class Form1 : Form
    {
        private RFID myRFIDReader;
        private DBHelper dbh;
        public Form1()
        {
            InitializeComponent();
            dbh = new DBHelper();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                listBox1.Items.Add("WELCOME");
            }
            catch (PhidgetException) { listBox1.Items.Add("error at start-up."); }
            pictureBox1.BackColor = Color.White;
            lblMode.Text = "Entry";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                listBox1.Items.Add("an RFID-reader is found and opened.");
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException) { listBox1.Items.Add("no RFID-reader opened."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();
            listBox1.Items.Add("an RFID-reader is closed.");
        }
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            //listBox1.Items.Add("rfid has tag-nr: " + e.Tag);
            //some fields
            int paid = dbh.CheckIfPaid(e.Tag);
            int user_id = dbh.GetUserID(e.Tag);
            int camping_id = dbh.GetCampingID(e.Tag);
            DateTime today = DateTime.Today;
            DateTime arrivalDate = dbh.GetArrivalDate(user_id);
            

            if (paid == 1)
            {
                if (camping_id != 0)
                {
                    if (arrivalDate <= today)
                    {
                        dbh.UpdateLocation(user_id.ToString());
                        pictureBox1.BackColor = Color.Green;
                        //Start timer, your program continues execution normaly
                        timer1.Start();
                        //If you use sleep(2000) your program stop working for two seconds.
                        //listBox1.Items.Add(paid.ToString());
                        //dbh.UpdateStatus(e.Tag);
                    }
                    else {
                        pictureBox1.BackColor = Color.Red;
                        //Start timer, your program continues execution normaly
                        timer1.Start();
                        AutoClosingMessageBox.Show("Sorry, you will have to wait until "+arrivalDate+" to enter", "capiton", 1000);
                    }
                }
                else
                {
                    pictureBox1.BackColor = Color.Red;
                    //Start timer, your program continues execution normaly
                    timer1.Start();
                    AutoClosingMessageBox.Show("Sorry, you will have to try to book a tent to enter", "capiton", 1000);

                }

            }
            else if(paid==0)
            {
                pictureBox1.BackColor = Color.Red;
                //Start timer, your program continues execution normaly
                timer1.Start();
                //If you use sleep(2000) your program stop working for two seconds.
                //listBox1.Items.Add(paid.ToString());
                AutoClosingMessageBox.Show("This person has not payed for the event - KICK HIM OUT!","capiton",1000);
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
                //Start timer, your program continues execution normaly
                timer1.Start();
                //If you use sleep(2000) your program stop working for two seconds.
                //listBox1.Items.Add(paid.ToString());
                AutoClosingMessageBox.Show("this rfid is not registered - KICK THIS PERSON OUT!", "capiton", 1000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.BackColor = Color.White;
        }

        public void AddMoneyTag(object sender, TagEventArgs e)
        {
            
            string bracelet_id = e.Tag;
            int paid = dbh.CheckIfPaid(e.Tag);
            int user_id = dbh.GetUserID(e.Tag);
            int camping_id = dbh.GetCampingID(e.Tag);
            DateTime today = DateTime.Today;
            DateTime arrivalDate = dbh.GetArrivalDate(user_id);

            if (paid == 1)
            {
                if (camping_id != 0)
                {
                    dbh.PayForDay(bracelet_id, camping_id);
                }
                else
                {
                    AutoClosingMessageBox.Show("Sorry, you will have to try to book a tent to enter", "capiton", 2000);

                }

            }
            else if (paid == 0)
            {
                AutoClosingMessageBox.Show("This person has not payed for the event - KICK HIM OUT!", "capiton", 2000);
            }
            else
            {
                AutoClosingMessageBox.Show("this rfid is not registered - KICK THIS PERSON OUT!", "capiton", 2000);
            }
            myRFIDReader.Tag -= new TagEventHandler(AddMoneyTag);
            myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
            lblMode.Text = "Entry";
        }
        private void btnAddDay_Click(object sender, EventArgs e)
        {
            myRFIDReader.Tag -= new TagEventHandler(ProcessThisTag);
            myRFIDReader.Tag += new TagEventHandler(AddMoneyTag);
            AutoClosingMessageBox.Show("Scan your RFID", "Nasko e Sexy",2000);
            lblMode.Text = "Adding a day";

        }

    }
}
