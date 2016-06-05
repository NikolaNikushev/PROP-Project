using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActivityEntrance;
namespace ChooseActivityForm
{
    public partial class ChooseActivityForm : Form
    {
        private DBHelper myDBHelper = new DBHelper();
        public ChooseActivityForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(myDBHelper.RetrieveActivityNames().ToArray());
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            ActivityEntranceForm aef = new ActivityEntranceForm();
            List<string> activityData = new List<string>();
            aef.Show();
            string selectedActivity = comboBox1.SelectedItem.ToString();
            activityData = myDBHelper.RetrieveActivityDetails(selectedActivity);
            aef.ActivityName = activityData[0];
            aef.ActivityDate = activityData[1];
            //this.Hide();
            
        }
    }
}
