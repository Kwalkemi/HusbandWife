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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string DBName = "Bharat";
        public int iintUpdateId { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm();
            
            lblBuyId.Text = string.Empty;
            lblSellId.Text = string.Empty;
            lblChargeId.Text = string.Empty;
        }

        private void LoadForm()
        {
            lblUser.Text = Login.FullName;
            // TODO: This line of code loads data into the 'bharatDataSet.ShareTrackerProcedure' table. You can move, or remove it, as needed.
            this.shareTrackerProcedureTableAdapter.Fill(this.bharatDataSet1.ShareTrackerProcedure, Login.UserId);
        }

        

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value) == "LOSS")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value) == "PROFIT")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
            if (dataGridView1.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
            {
                Sum();
            }
        }

        private void Sum()
        {
            lblTotalValue.Text = Convert.ToString(dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToInt32(x.Cells[2].Value)));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBFunction dBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("SHARES_TRACKER_HEADER_ID", lblBuyId.Text);
            ldict.Add("SHARES_PRICE_AMT", txtBuyPrice.Text);
            ldict.Add("SHARES_QUANTITY", txtBuyQty.Text);
            ldict.Add("SHARES_BUY_DATE", dateBuy.Text);
            int Id = dBFunction.InsertIntoTable(DBName, "SHARES_TRACKER_BUY", ldict);
            lblBuyId.Text = Id.ToString();
            lblSellId.Text = Id.ToString();
            lblChargeId.Text = Id.ToString();
            LoadForm();
        }

        private void btnShareHeader_Click(object sender, EventArgs e)
        {
            DBFunction dBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("SHARES_NAME", txtShareName.Text);
            ldict.Add("SHARE_TYPE_CODE_ID", "4");
            if (rdDelivery.Checked)
                ldict.Add("SHARE_TYPE_CODE_VALUE", "DELV");
            else if (rdOption.Checked)
                ldict.Add("SHARE_TYPE_CODE_VALUE", "OPTN");
            int id = dBFunction.InsertIntoTable(DBName, "SHARES_TRACKER_HEADER", ldict);
            if (id != 0)
            {
                lblBuyId.Text = Convert.ToString(id);
                lblSellId.Text = Convert.ToString(id);
                lblChargeId.Text = Convert.ToString(id);
            }
            LoadForm();
        }

        private void btnShareSell_Click(object sender, EventArgs e)
        {
            DBFunction dBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("SHARES_TRACKER_HEADER_ID", lblSellId.Text);
            ldict.Add("SHARES_PRICE_AMT", txtSellPrice.Text);
            ldict.Add("SHARES_QUANTITY", txtSellQty.Text);
            ldict.Add("SHARES_SELL_DATE", dateSell.Text);
            dBFunction.InsertIntoTable(DBName, "SHARES_TRACKER_SELL", ldict);
            LoadForm();
        }

        private void btnShareCharge_Click(object sender, EventArgs e)
        {
            DBFunction dBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("SHARES_TRACKER_HEADER_ID", lblChargeId.Text);
            ldict.Add("SHARES_CHARGES_AMT", txtShareChargesAmt.Text);
            ldict.Add("SHARES_CHARGES_DESCRIPTION", txtShareChargesDesc.Text);
            dBFunction.InsertIntoTable(DBName, "SHARES_TRACKER_CHARGES", ldict);
            LoadForm();
        }

        private void btnShareExtraCharge_Click(object sender, EventArgs e)
        {
            DBFunction dBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("SHARES_EXTRA_CHARGES_AMT", txtExtraChargeAmt.Text);
            ldict.Add("SHARES_EXTRA_CHARGES_DESCRIPTION", txtExtraChargeName.Text);
            ldict.Add("SHARES_CHARGES_DATE", dateExtraCharge.Text);
            dBFunction.InsertIntoTable(DBName, "SHARES_TRACKER_EXTRA_CHARGES", ldict);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iintUpdateId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            lblBuyId.Text = iintUpdateId.ToString();
            lblSellId.Text = iintUpdateId.ToString();
            lblChargeId.Text = iintUpdateId.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            LoadForm();
        }
    }
}
