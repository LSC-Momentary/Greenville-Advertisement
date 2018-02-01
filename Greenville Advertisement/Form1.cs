using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenville_Advertisement
{
    public partial class greenvilleAd : Form
    {
        public greenvilleAd()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            subNameLabel2.Text = nameBox.Text;
            subAddressLabel2.Text = addressBox.Text;
            subActLabel2.Text = actBox.SelectedItem.ToString();

            if (genderRadio1.Checked == true)
                {
                subGenderLabel2.Text = "Male";
            }

            else if (genderRadio2.Checked == true)
            {
                subGenderLabel2.Text = "Female";
            }

            else
            {
                MessageBox.Show("Please Select a Gender");
                return;
            }

            subNameLabel2.Visible = true;
            subGenderLabel2.Visible = true;
            subAddressLabel2.Visible = true;
            subActLabel2.Visible = true;


        }

        private void greenvilleAd_Load(object sender, EventArgs e)
        {

        }
    }
}
