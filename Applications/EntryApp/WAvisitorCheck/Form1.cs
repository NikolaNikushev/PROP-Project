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
           int paid = dbh.CheckIfPaid(e.Tag);
            if (paid == 1)
            {
                
                pictureBox1.BackColor = Color.Green;
                //Start timer, your program continues execution normaly
                timer1.Start();
                //If you use sleep(2000) your program stop working for two seconds.
                //listBox1.Items.Add(paid.ToString());
                dbh.UpdateStatus(e.Tag);

            }
            else if(paid==0)
            {
                pictureBox1.BackColor = Color.Red;
                //Start timer, your program continues execution normaly
                timer1.Start();
                //If you use sleep(2000) your program stop working for two seconds.
                //listBox1.Items.Add(paid.ToString());
                AutoClosingMessageBox.Show("This person has not payed","capiton",1000);
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
                //Start timer, your program continues execution normaly
                timer1.Start();
                //If you use sleep(2000) your program stop working for two seconds.
                //listBox1.Items.Add(paid.ToString());
                AutoClosingMessageBox.Show("this rfid is not registered", "capiton", 1000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           List<Visitor> temp = dbh.GetAllVisitors();
            foreach(Visitor visitor in temp)
            {
                listBox1.Items.Add(visitor.getInfo());
            }
        }


    }
}
