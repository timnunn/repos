﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = "txtName.Text";
            testSchool.Address = "txtAddress.Text";
            testSchool.City = "txtCity.Text";
            testSchool.State = "txtState.Text";
            testSchool.Zip = "txtZip.Text";
            testSchool.PhoneNumber = "txtPhoneNumber.Text";
            try
            {
                testSchool.TwitterAddress = "textTwitter.Text";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testSchool.ToString());

        }
    }
}
