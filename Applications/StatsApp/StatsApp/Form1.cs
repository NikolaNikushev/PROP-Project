using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modules;

namespace StatsApp
{
    public partial class Form1 : Form
    {
        DBHelper dbh;
        BinaryFileHelper bfh = new BinaryFileHelper();
        int time;
        string date;
        Label[] financialLabels = new Label[0];
        public Form1()
        {
            InitializeComponent();
            dbh = new DBHelper();

            label2.Text = dbh.GetNrCurrentVisitors().ToString();
            timer1.Start();

            this.VisitorCntrlrInit();
            this.tmrVisCDataPrt.Start();

            timer2.Interval = 5000 /*(uncomment for an hourly interval * 60 * 60 */;
            time = System.DateTime.Now.Hour;
            date = DateTime.Now.ToString("dd");
            Label[] ar = { completeRevenueLabel, revenueSalesLabel, revenueServicesLabel, balanceCapacityLabel };
            financialLabels = ar;

        }

        /// <summary>
        /// Used to initialize the visitor controller - i.e to populate all the data again
        /// </summary>
        private void VisitorCntrlrInit()
        {
            // sending labels as parameters is dumb - I started to suppose (dmitry)
            Label[] labelUsStatGroup = { this.lblNmbrPresentVal, this.lblNmbrExpectedVal, this.lblNmbrFestAcVal };
            Label[] labelCampersAndBuyersGroup = { this.lblNmbrCampersVal, this.lblNmbrCampingGroupsVal, this.lblNmbrBuyersVal };
            VisitorsCntrl VSC = new VisitorsCntrl(this.dgvBracelets, this.lblBracNmbrVal, labelUsStatGroup, labelCampersAndBuyersGroup);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = dbh.GetNrCurrentVisitors().ToString();
            // one of the festival dates
            if ((Convert.ToString(DateTime.Now.ToString("dd_MM_yyyy")) == "27_06_2016" || Convert.ToString(DateTime.Now.ToString("dd_MM_yyyy")) == "28_06_2016" || Convert.ToString(DateTime.Now.ToString("dd_MM_yyyy")) == "29_06_2016") && timer2.Enabled != true)
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
            if (date != newdate)
            {
                listBox1.Items.Clear();
                date = DateTime.Now.ToString("dd");
                listBox1.Items.Add("The date is " + Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy")));
            }

            int newtime = System.DateTime.Now.Hour;
            if (newtime != time)
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
            List<string> data = bfh.LoadFromBinaryFile("../../DAY_27_06_2016");
            foreach (string a in data)
            {
                listBox2.Items.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<string> data = bfh.LoadFromBinaryFile("../../DAY_28_06_2016");
            foreach (string a in data)
            {
                listBox2.Items.Add(a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<string> data = bfh.LoadFromBinaryFile("../../DAY_29_06_2016");
            foreach (string a in data)
            {
                listBox2.Items.Add(a);
            }
        }

        private void btnDisplayProducts_Click(object sender, EventArgs e)
        {
            int selectedType = this.cmbStorageSelect.SelectedIndex;

            switch (selectedType)
            {
                case 0:
                    WareHouseCntrl.PopulateGridData(this.dgvProductStock, StorageTypes.GLOBAL);
                    break;
                case -1:
                    MessageBox.Show("Select a type first!");
                    break;
                default:
                    WareHouseCntrl.PopulateGridData(this.dgvProductStock, StorageTypes.LOCAL, this.cmbStorageSelect.SelectedItem.ToString());
                    break;

            }


        }

        private void tabModules_TabIndexChanged(object sender, EventArgs e)
        {
            switch (tabModules.SelectedIndex)
            {
                case 0: //visitors
                    this.VisitorCntrlrInit();
                    this.tmrVisCDataPrt.Start();
                    break;
                case 1: //warehouse
                    this.tmrVisCDataPrt.Stop();
                    // just so that the arguments fit
                    Label[] lbls = { this.lblTotPurchVal, this.lblGrossAmPaidVal, this.lblHotHourVal };
                    WareHouseCntrl WHC = new WareHouseCntrl(this.cmbStorageSelect, this.cmbSelectStoreForHistory, this.lbTopPopProd, lbls);
                    //WareHouseCntrl.PopulateComboBox(this.cmbStorageSelect);
                    break;
                case 2: //finance
                    this.tmrVisCDataPrt.Stop();
                    Finance.PupulateFinanceData(financialLabels);
                    break;
            }
        }

        private void btnRefreshGeneralOverview_Click(object sender, EventArgs e)
        {
            WareHouseCntrl.UpdateOverview(this.lbTopPopProd, this.lblTotPurchVal, this.lblGrossAmPaidVal, this.lblHotHourVal);

        }

        private void cmbSelectStoreForHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            WareHouseCntrl.PopulateProdOfStoreComboBox(this.cmbSelectHisotryProduct, this.cmbSelectStoreForHistory.SelectedItem.ToString());
            this.cmbSelectStoreForHistory.Enabled = false;
            this.cmbSelectHisotryProduct.Enabled = true;
        }

        private void btnChangeStore_Click(object sender, EventArgs e)
        {
            this.cmbSelectStoreForHistory.Enabled = true;
            this.cmbSelectHisotryProduct.Items.Clear();
            this.cmbSelectHisotryProduct.Text = "Select a product";
            this.cmbSelectHisotryProduct.Enabled = false;
        }

        private void btnDisplayHistory_Click(object sender, EventArgs e)
        {
            try
            {
                WareHouseCntrl.GetHistoricalData(this.chartProductHistory, this.cmbSelectStoreForHistory.SelectedItem.ToString(), this.cmbSelectHisotryProduct.SelectedItem.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // timer refresh
        private void tmrVisCDataPrt_Tick(object sender, EventArgs e)
        {
            Label[] labelUsStatGroup = { this.lblNmbrPresentVal, this.lblNmbrExpectedVal, this.lblNmbrFestAcVal };
            Label[] labelCampersAndBuyersGroup = { this.lblNmbrCampersVal, this.lblNmbrCampingGroupsVal, this.lblNmbrBuyersVal };
            VisitorsCntrl.PopulateCampersAndBuyersData(labelCampersAndBuyersGroup);
            VisitorsCntrl.PopulateVisitorGroupData(labelUsStatGroup);

        }
        // force refresh
        private void btnVisRefresh_Click(object sender, EventArgs e)
        {
            this.VisitorCntrlrInit();
        }

        private void btnBracRefresh_Click(object sender, EventArgs e)
        {
            VisitorsCntrl.PopulateBraceletSection(this.dgvBracelets, this.lblBracNmbrVal);
        }
    }
}
