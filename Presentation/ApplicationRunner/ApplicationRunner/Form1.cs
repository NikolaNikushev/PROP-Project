using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationRunner
{
    public partial class Form1 : Form
    {
        string[] appNames = { "Bracelet management", "Event entrance", "Camping entrance", "Shop", "Statistics", "Visitor support" };
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < appNames.Length; i++)
            {
                ApplicationsListBox.Items.Add(appNames[i]);
            }
            //adding some styles to the button
            RunButton.TabStop = false;
            RunButton.FlatStyle = FlatStyle.Flat;
            RunButton.FlatAppearance.BorderSize = 0;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var root = System.IO.Directory.GetCurrentDirectory();
            switch (ApplicationsListBox.SelectedItem.ToString())
            {
                //"../../../../../Applications/BraceletManagement/BraceletManagement/bin/Debug/BraceletManagement.exe"
                case "Bracelet management":
                    Process.Start(root + "/../../../../../Applications/BraceletManagement/BraceletManagement/bin/Debug/BraceletManagement.exe");
                    break;
                case "Event entrance":
                    Process.Start(root + "/../../../../../Applications/EntryApp/WAvisitorCheck/bin/Debug/WAvisitorCheck.exe");
                    break;
                case "Camping entrance":
                    Process.Start(root + "/../../../../../Applications/CampingEntryApp/CampingEntryApp/bin/Debug/CampingEntryApp.exe");
                    break;
                case "Shop":
                    Process.Start(root + "/../../../../../Applications/ShopAppStable/ShopApp/bin/Debug/ShopApp.exe");
                    break;
                case "Statistics":
                    Process.Start(root + "/../../../../../Applications/StatsApp/StatsApp/bin/Debug/StatsApp.exe");
                    break;
                case "Visitor support":
                    Process.Start(root + "/../../../../../Applications/VisSup/BraceletManagement/bin/Debug/BraceletManagement.exe");
                    break;
                default:
                    break;
            }
        }
    }
}
