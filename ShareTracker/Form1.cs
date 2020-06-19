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

        public int iintUpdateId { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
           
            // TODO: This line of code loads data into the 'bharatDataSet.ShareTrackerProcedure' table. You can move, or remove it, as needed.
            this.shareTrackerProcedureTableAdapter.Fill(this.bharatDataSet.ShareTrackerProcedure);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }






        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == "Outgoing")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == "Incoming")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
            if (dataGridView1.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13) { }
               // Sum();
        }

    }
}
