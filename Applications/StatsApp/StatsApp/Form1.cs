using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsApp
{
    public partial class Form1 : Form
    {
        DBHelper dbh;
        BinaryFileHelper bfh = new BinaryFileHelper();
        int time;
        string date;
        public Form1()
        {
            InitializeComponent();
            dbh = new DBHelper();

            label2.Text = dbh.GetNrCurrentVisitors().ToString();
            timer1.Start();

            timer2.Interval = 5000 /*(uncomment for an hourly interval * 60 * 60 */;
            time = System.DateTime.Now.Hour;
            date = DateTime.Now.ToString("dd");


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = dbh.GetNrCurrentVisitors().ToString();
            if((Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy")) == "25.04.2016" || Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy")) == "26.04.2016" || Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy")) == "27.04.2016") && timer2.Enabled!=true)
            {
                timer2.Start();
                listBox1.Items.Add("The date is " + Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy")));
                listBox1.Items.Add(Convert.ToString(System.DateTime.Now.Hour) + "    visitors: " + dbh.GetNrCurrentVisitors().ToString());

                var visitorsList = listBox1.Items.Cast<String>().ToList();
                bfh.SaveToBinaryFile(visitorsList);

            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string newdate = DateTime.Now.ToString("dd");
            if(date != newdate)
            {
                listBox1.Items.Clear();
                date = DateTime.Now.ToString("dd");
                listBox1.Items.Add("The date is " + Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy")));
            }

            int newtime = System.DateTime.Now.Hour;
            if (newtime!=time)
            {
                listBox1.Items.Add(Convert.ToString(System.DateTime.Now.Hour) + "    visitors: " + dbh.GetNrCurrentVisitors().ToString());

                if (time < 23)
                {
                    time++;
                }
                else
                { time = 0; }

                var visitorsList = listBox1.Items.Cast<String>().ToList();
                bfh.SaveToBinaryFile(visitorsList);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //my mistake
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
           List<string> data = bfh.LoadFromBinaryFile("../../DAY_25.04.2016");
            foreach(string a in data)
            {
                listBox2.Items.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<string> data = bfh.LoadFromBinaryFile("../../DAY_26.04.2016");
            foreach (string a in data)
            {
                listBox2.Items.Add(a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<string> data = bfh.LoadFromBinaryFile("../../DAY_27.04.2016");
            foreach (string a in data)
            {
                listBox2.Items.Add(a);
            }
        }
    }
}
