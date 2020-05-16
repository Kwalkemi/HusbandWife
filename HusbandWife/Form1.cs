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

namespace HusbandWife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int iintResult { get; set; }
        public int iintUpdateId { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bharatDataSet.Husband_Wife' table. You can move, or remove it, as needed.
            LoadForm();
        }

        private void LoadForm()
        {
            this.husband_WifeTableAdapter.Fill(this.bharatDataSet.Husband_Wife);
            LoadCategory();
            Sum();
            Result();
        }

        private void AddAmount(string astrType, string astrAmt, string adttime, string aintCategoryId)
        {
            DBFunction ldBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("Husband_Wife_Type", astrType);
            ldict.Add("Husband_Wife_Amt", astrAmt);
            ldict.Add("Husband_Wife_Date", adttime);
            ldict.Add("EXPENSES_CATEGORY_ID", aintCategoryId);
            ldBFunction.InsertIntoTable("Bharat", "Husband_Wife", ldict);
        }

        private void UpdateAmount(int aintId, string astrAmt, string adttime, int? ExpenseCtgryId)
        {
            DBFunction ldBFunction = new DBFunction();
            string lstrQuery = "Update Husband_Wife Set Husband_Wife_Amt = " + Convert.ToInt32(astrAmt) + " , Husband_Wife_Date = '" + adttime + "' , EXPENSES_CATEGORY_ID = "+ ExpenseCtgryId +" Where Husband_Wife_Id = " + aintId;
            ldBFunction.UpdateTable("Bharat", lstrQuery);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == "WIFE")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == "HUSB")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
            if (dataGridView1.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
                Result();
        }



        private void btnWife_Click(object sender, EventArgs e)
        {
            if (txtwifespend.Text == string.Empty)
            {
                errorProvider1.SetError(txtwifespend, "Please Enter the Amount");
            }
            else
            {
                string categoryId = "Select Expenses_Category_Id from Expenses_Category where Expenses_Category_Table_Value = 'HUWF' and Expenses_Category_Name = '" + cmbcategory.SelectedItem + "'";
                DBFunction lDBFunction = new DBFunction();
                string lstrId = lDBFunction.FetchScalarFromDatabase("Bharat", categoryId);
                AddAmount("WIFE", txtwifespend.Text, Convert.ToString(dateTimePickerwife.Value), lstrId);
                this.husband_WifeTableAdapter.Fill(this.bharatDataSet.Husband_Wife);
            }
            Sum();
        }

        private void btnHusband_Click(object sender, EventArgs e)
        {
            if (txtwifespend.Text == string.Empty)
            {
                errorProvider1.SetError(txthusband, "Please Enter the Amount");
            }
            else if (errorProvider1.GetError(txthusband) == string.Empty)
            {
                AddAmount("HUSB", txthusband.Text, Convert.ToString(dateTimePickerhusb.Value), string.Empty);
                this.husband_WifeTableAdapter.Fill(this.bharatDataSet.Husband_Wife);
            }
            Sum();
        }

        private void LoadCategory()
        {
            DBFunction lDBFunction = new DBFunction();
            string lstrQuery = "Select Expenses_Category_Name from Expenses_Category where Expenses_Category_Table_Value = 'HUWF'";
            DataTable ldtbTable = lDBFunction.FetchDataFromDatabase("Bharat", lstrQuery);
            foreach (DataRow dr in ldtbTable.Rows)
                cmbcategory.Items.Add(Convert.ToString(dr["Expenses_Category_Name"]));
        }

        private void Result()
        {
            if (iintResult > 0)
            {
                lblResult.Text = "Husband will give " + iintResult + " Rs to Wife.";
            }
            else if (iintResult < 0)
            {
                lblResult.Text = "Wife have " + iintResult + " extra Rs";
            }
            else if (iintResult == 0)
            {
                lblResult.Text = "All Clear";
            }
        }

        private void Sum()
        {
            iintResult = dataGridView1.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToString(t.Cells[2].Value) == "WIFE").Sum(x => Convert.ToInt32(x.Cells[3].Value))
                - dataGridView1.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToString(t.Cells[2].Value) == "HUSB").Sum(x => Convert.ToInt32(x.Cells[3].Value));
            iintResult = Math.Abs(iintResult);
        }

        private void txtwifespend_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtwifespend.Text);
                errorProvider1.SetError(txtwifespend, "");
            }
            catch
            {
                errorProvider1.SetError(txtwifespend, "Please Enter Number");
            }
        }

        private void txthusband_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtwifespend.Text);
                errorProvider1.SetError(txthusband, "");
            }
            catch
            {
                errorProvider1.SetError(txthusband, "Please Enter Number");
            }
        }

        private void btnUpdateWife_Click(object sender, EventArgs e)
        {
            if (txtwifespend.Text == string.Empty)
            {
                errorProvider1.SetError(txtwifespend, "Please Enter the Amount");
            }
            else
            {
                DBFunction lDBFunction = new DBFunction();
                string lstrQuery = "Select Top 1 Expenses_Category_Id from Expenses_Category where Expenses_Category_Table_Value = 'HUWF' and Expenses_Category_Name = '" + Convert.ToString(cmbcategory.SelectedItem) + "' order by 1 desc";
                string Id = lDBFunction.FetchScalarFromDatabase("Bharat", lstrQuery);
                UpdateAmount(iintUpdateId, txtwifespend.Text, Convert.ToString(dateTimePickerwife.Value), Convert.ToInt32(Id));
                this.husband_WifeTableAdapter.Fill(this.bharatDataSet.Husband_Wife);
            }
            Sum();
        }

        private void btnUpdateHusb_Click(object sender, EventArgs e)
        {
            if (txtwifespend.Text == string.Empty)
            {
                errorProvider1.SetError(txthusband, "Please Enter the Amount");
            }
            else if (errorProvider1.GetError(txthusband) == string.Empty)
            {
                UpdateAmount(iintUpdateId, txthusband.Text, Convert.ToString(dateTimePickerhusb.Value), null);
                this.husband_WifeTableAdapter.Fill(this.bharatDataSet.Husband_Wife);
            }
            Sum();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iintUpdateId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == "HUSB")
            {
                txthusband.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                dateTimePickerhusb.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            }
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == "WIFE")
            {
                txtwifespend.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                dateTimePickerwife.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                cmbcategory.SelectedItem = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }
        }

        private void btnAddCtgry_Click(object sender, EventArgs e)
        {
            DBFunction lDBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("Expenses_Category_Table_Id", "2");
            ldict.Add("Expenses_Category_Table_Value", "HUWF");
            string promptValue = Prompt.ShowAddCategoryDialog("Category Add Box");
            if(promptValue != string.Empty)
            {
                ldict.Add("Expenses_Category_Name", promptValue);
                lDBFunction.InsertIntoTable("Bharat", "Expenses_Category", ldict);
            }
        }

        private void btnRmvCtgry_Click(object sender, EventArgs e)
        {
            DBFunction lDBFunction = new DBFunction();
            List<string> lstItem = new List<string>();
            foreach (string item in cmbcategory.Items)
                lstItem.Add(item);
            string promptValue = Prompt.ShowRemoveCategoryDialog("Category Remove Box", lstItem);
            if(promptValue != string.Empty)
            {
                string lstrQuery = "Select Top 1 Expenses_Category_Id from Expenses_Category where Expenses_Category_Table_Value = 'HUWF' and Expenses_Category_Name = '" + promptValue +"' order by 1 desc";
                string Id = lDBFunction.FetchScalarFromDatabase("Bharat", lstrQuery);
                lstrQuery = "Delete Expenses_Category where Expenses_Category_Id = " + Id;
                lDBFunction.UpdateTable("Bharat", lstrQuery);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            LoadForm();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            HusbandWifeAnalysis.Form1 form = new HusbandWifeAnalysis.Form1();
            form.ShowDialog();
        }
    }
}
