using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;

namespace ShareTracker
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DBFunction dBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            if (txtUsername.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Please enter the username");
            }
            else
            {
                ldict.Add("Username", txtUsername.Text);
            }
            if (txtPassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Please enter the password");
            }
            else
            {
                ldict.Add("Password", txtPassword.Text);
            }
            if (txtConfirmPassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Please enter the confirm password");
            }
            if (txtFirstname.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Please enter the first name");
            }
            else
            {
                ldict.Add("First_Name", txtFirstname.Text);
            }
            if (txtlastname.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Please enter the last name");
            }
            else
            {
                ldict.Add("Last_Name", txtlastname.Text);
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtPassword, "Password and Confirm Password did not match");
                errorProvider1.SetError(txtConfirmPassword, "Password and Confirm Password did not match");
            }
            if (!radioMale.Checked && !radioFemale.Checked)
            {
                errorProvider1.SetError(radioFemale, "Please enter the gender");
            }
            else
            {
                string str = radioMale.Checked ? "Male" : radioFemale.Checked ? "Female" : string.Empty;
                ldict.Add("Gender", str);
            }
            int Id = dBFunction.InsertIntoTable("Bharat", "Login_Info", ldict);
            if (Id > 0)
            {
                MessageBox.Show("Registration Successfully");
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
