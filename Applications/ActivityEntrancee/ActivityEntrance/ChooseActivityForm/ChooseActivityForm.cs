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
        private DBHelper myDBHelper;
        public string selectedActivity;
        public ChooseActivityForm()
        {
            InitializeComponent();
            myDBHelper = new DBHelper();
            //inserting values that are retrieved from the database in the combobox 
            comboBox1.Items.AddRange(myDBHelper.RetrieveActivityNames().ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            List<string> activityData = new List<string>();
            List<string> placesData = new List<string>();
            string activityID;
            //starting the new form for the activity entrance
            ActivityEntranceForm aef = new ActivityEntranceForm();           
            aef.Show();

            selectedActivity = comboBox1.SelectedItem.ToString();
            //overwriting the the dbhelper, using the second constructor, so I can make use of the selected activity
            //which was retrieved on top
            
            myDBHelper = new DBHelper(selectedActivity);
            //retrieveing data with the selected name from the combobox
            activityData = myDBHelper.RetrieveActivityDetails(selectedActivity);

            //assiging the data to the public propertis of the Activity entrance form
            aef.ActivityName = activityData[0];
            aef.ActivityDate = activityData[1];
            activityID = activityData[2];
            aef.activityID = activityID;
            placesData = myDBHelper.RetrievePlacesDetails(activityID);

            //assiging the data to the public propertis of the Activity entrance form
            aef.TotalPlaces = placesData[0];
            aef.ReservedPlaces = placesData[1];
            aef.FreePlaces = placesData[2];
            aef.OpenPlacesTaken = placesData[3];
            // setting the dbhelper object to the one referring to activity reservation form, so it can make
            //use of the same variables
            aef.myDBHelper = this.myDBHelper;

            this.Hide();

        }
    }
}
