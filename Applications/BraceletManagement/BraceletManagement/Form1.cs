using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BraceletManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxSearchType.SelectedItem != null)
            {
                if (cmbxSearchType.SelectedItem.ToString() == StatusTypes.SearchType.NAME.ToString())
                {
                    this.tbSearchLastName.ReadOnly = false;
                }
                else
                {
                    this.tbSearchLastName.Text = "";
                    this.tbSearchLastName.ReadOnly = true;

                }
            }
            
        }
    }
}
