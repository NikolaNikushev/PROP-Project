using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseActivity
{
    public partial class ChooseActivity : Form
    {
        DBHelper myDBHelper = new DBHelper();
        public ChooseActivity()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(myDBHelper.RetrieveActivityNames().ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string selectedItem = comboBox1.SelectedItem.ToString(); 
            ActivityExit.ActivityExit aExitForm = new ActivityExit.ActivityExit();
            aExitForm.selectedItem = selectedItem;
            aExitForm.myDBHelper = myDBHelper;
            aExitForm.Show();
            this.Hide();
        }
    }
}
