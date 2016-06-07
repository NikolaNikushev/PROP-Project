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

namespace CampingExitApp
{
    public partial class Form1 : Form
    {
        private RFID myRFIDReader;
        private DBHelper dbh;
        int workingRFID;
        public Form1()
        {
            InitializeComponent();
            workingRFID = 0;
            dbh = new DBHelper();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                listBox1.Items.Add("WELCOME");
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                listBox1.Items.Add("an RFID-reader is found and opened.");
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException) { listBox1.Items.Add("error at start-up."); }
            pictureBox1.BackColor = Color.White;

        }


        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            //listBox1.Items.Add("rfid has tag-nr: " + e.Tag);
            //some fields
            int paid = dbh.CheckIfPaid(e.Tag);
            int user_id = dbh.GetUserID(e.Tag);

            if (workingRFID == 0) //Prevents from accidentally scanning your RFID twice
            {
                if (paid == 1) //Prevents from people that haven't paid for the event (just in case)
                {
                        dbh.UpdateLocationExit(user_id.ToString());
                        pictureBox1.BackColor = Color.Green;
                        workingRFID = 1;
                        //Start timer, your program continues execution normaly
                        timer1.Start();
                        //If you use sleep(2000) your program stop working for two seconds.
                        //listBox1.Items.Add(paid.ToString());
                        //dbh.UpdateStatus(e.Tag);
                 
                }
                else if (paid == 0)
                {
                    pictureBox1.BackColor = Color.Red;
                    //Start timer, your program continues execution normaly
                    timer1.Start();
                    //If you use sleep(2000) your program stop working for two seconds.
                    //listBox1.Items.Add(paid.ToString());
                    AutoClosingMessageBox.Show("This person has not payed for the event - KICK HIM OUT!", "capiton", 1000);
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.BackColor = Color.White;
            workingRFID = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();
            listBox1.Items.Add("an RFID-reader is closed.");
        }
    }
}
