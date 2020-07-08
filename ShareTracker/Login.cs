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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string FullName = string.Empty;
        public static int UserId = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string str = "Select Login_Info_Id from login_info where Username = '" + txtUser.Text + "' and Password = '" + txtpassword.Text + " '";
            DBFunction dBFunction = new DBFunction();
            string result = dBFunction.FetchScalarFromDatabase("Bharat", str);
            if (result != string.Empty && Convert.ToInt32(result) > 0)
            {
                str = "Select * from login_info where Login_Info_Id = " + result;
                DataTable dataTable = dBFunction.FetchDataFromDatabase("Bharat", str);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    FullName = Convert.ToString(dataTable.Rows[0]["First_Name"]) + " " + Convert.ToString(dataTable.Rows[0]["Last_Name"]);
                    UserId = Convert.ToInt32(dataTable.Rows[0]["Login_Info_Id"]);
                }
                this.Hide();
                Share form1 = new Share();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Username does not exist.");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
