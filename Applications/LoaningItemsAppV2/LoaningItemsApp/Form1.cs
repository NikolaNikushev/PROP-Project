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

namespace LoaningItemsApp
{
    public partial class Form1 : Form
    {
        
        DBHelper dbh;
        private RFID RFIDReader;
        LoanShopp JobsDone = new LoanShopp("Job's Done");
        double balance;
        string tag;
        double totalprice;

        public Form1()
        {
            InitializeComponent();
            this.Text = JobsDone.Name;
            dbh = new DBHelper();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RFIDReader = new RFID();
                RFIDReader.open();
                RFIDReader.waitForAttachment(4000);
                RFIDReader.Antenna = true;
                RFIDReader.LED = true;
                RFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                


            }
            catch(PhidgetException)
            {
                MessageBox.Show("Couldn't open RFID reader");
            }
        }
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            int paid = dbh.CheckIfPaid(e.Tag);
            if (paid == 1)
            {

                
                balance = dbh.getBalance(e.Tag);
                textBox1.Text = Convert.ToString(balance);
                tag = e.Tag;
               
                

            }
            else
            {
                MessageBox.Show("Invalid tag");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            foreach(Item i in JobsDone.LoanItems)
            {
                lBoxItemsForLoan.Items.Add(i.AsString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                RFIDReader.LED = false;
                RFIDReader.Antenna = false;
                RFIDReader.close();
            }
            catch
            {
                MessageBox.Show("You haven't opened the reader yet");
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to loan this item?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try {
                    Item i;
                    int index = lBoxItemsForLoan.SelectedIndex;
                    i = JobsDone.LoanItems[index];
                    if (i.Loaned == 1)
                    {
                        MessageBox.Show("Item is alredy loaned out");
                    }
                    else
                    {
                        balance = dbh.getBalance(tag);
                        DateTime startdate = DateTime.Now;
                       
                        dbh.SetStartDate(i.Article_id, startdate);
                        dbh.SetLoanStatus(i.Article_id);
                        i.Loaned = 1;
                        lBoxItemsForLoan.Items.Remove(i);
                        lBoxLoanedItems.Items.Add(i.AsString());
                        DateTime duedate = dateTimePicker1.Value.Date;
                        i.Returndate = duedate;
                        int totaldays = (duedate - startdate).Days;
                        if (totaldays == 0)
                        {
                            totalprice = i.Priceperday;
                            txtBoxPrice.Text = totalprice.ToString();
                        }
                        else {
                            int ppday = i.Priceperday;
                            totaldays++;
                            totalprice = ppday * totaldays;
                            txtBoxPrice.Text = totalprice.ToString();
                        }
                        double newbalance = balance - totalprice;
                        dbh.UpdateBalance(tag, newbalance);
                        textBox1.Text = Convert.ToString(newbalance);

                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    MessageBox.Show("You have not selected an item");
                }
            }
            else if(dialogResult == DialogResult.No)
            {
                lBoxItemsForLoan.SelectedIndex = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lBoxItemsForLoan.Items.Clear();
            lBoxLoanedItems.Items.Clear();
            txtBoxPrice.Clear();
            lBoxItemsForLoan.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item var;
            int index = listBox1.SelectedIndex;
            var = JobsDone.LoanItems[index];
            int articleId = var.Article_id;
            dbh.SetLoanStatusToFalse(articleId);
            
            listBox1.Items.Remove(index);
            lBoxReturnedItems.Items.Add(var.AsString());
        }

        

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Item i in JobsDone.LoanItems)
            {
                listBox1.Items.Add(i.AsString());
            }
        }
    }

}


