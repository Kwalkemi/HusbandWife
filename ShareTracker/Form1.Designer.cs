namespace ShareTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHARESNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHAREAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFITLOSSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareTrackerProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bharatDataSet1 = new ShareTracker.BharatDataSet1();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateBuy = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnShareAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rdDelivery = new System.Windows.Forms.RadioButton();
            this.lblShareType = new System.Windows.Forms.Label();
            this.rdOption = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuyId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuyQty = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSellId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSellQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateSell = new System.Windows.Forms.DateTimePicker();
            this.btnShareSell = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblChargeId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShareChargesAmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShareChargesDesc = new System.Windows.Forms.TextBox();
            this.btnShareCharge = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtExtraChargeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtExtraChargeAmt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dateExtraCharge = new System.Windows.Forms.DateTimePicker();
            this.btnShareExtraCharge = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblShareName = new System.Windows.Forms.Label();
            this.txtShareName = new System.Windows.Forms.TextBox();
            this.btnShareHeader = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.shareTrackerProcedureTableAdapter = new ShareTracker.BharatDataSet1TableAdapters.ShareTrackerProcedureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shareTrackerProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.sHARESNAMEDataGridViewTextBoxColumn,
            this.sHAREAMTDataGridViewTextBoxColumn,
            this.pROFITLOSSDataGridViewTextBoxColumn,
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shareTrackerProcedureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(677, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(503, 594);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // SNo
            // 
            this.SNo.HeaderText = "Serial No";
            this.SNo.MinimumWidth = 6;
            this.SNo.Name = "SNo";
            // 
            // sHARESNAMEDataGridViewTextBoxColumn
            // 
            this.sHARESNAMEDataGridViewTextBoxColumn.DataPropertyName = "SHARES_NAME";
            this.sHARESNAMEDataGridViewTextBoxColumn.HeaderText = "SHARES_NAME";
            this.sHARESNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHARESNAMEDataGridViewTextBoxColumn.Name = "sHARESNAMEDataGridViewTextBoxColumn";
            // 
            // sHAREAMTDataGridViewTextBoxColumn
            // 
            this.sHAREAMTDataGridViewTextBoxColumn.DataPropertyName = "SHARE_AMT";
            this.sHAREAMTDataGridViewTextBoxColumn.HeaderText = "SHARE_AMT";
            this.sHAREAMTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHAREAMTDataGridViewTextBoxColumn.Name = "sHAREAMTDataGridViewTextBoxColumn";
            this.sHAREAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROFITLOSSDataGridViewTextBoxColumn
            // 
            this.pROFITLOSSDataGridViewTextBoxColumn.DataPropertyName = "PROFIT_LOSS";
            this.pROFITLOSSDataGridViewTextBoxColumn.HeaderText = "PROFIT_LOSS";
            this.pROFITLOSSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROFITLOSSDataGridViewTextBoxColumn.Name = "pROFITLOSSDataGridViewTextBoxColumn";
            this.pROFITLOSSDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROFITLOSSDataGridViewTextBoxColumn.Visible = false;
            // 
            // sHARESTRACKERHEADERIDDataGridViewTextBoxColumn
            // 
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn.DataPropertyName = "SHARES_TRACKER_HEADER_ID";
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn.HeaderText = "SHARES_TRACKER_HEADER_ID";
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn.Name = "sHARESTRACKERHEADERIDDataGridViewTextBoxColumn";
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // shareTrackerProcedureBindingSource
            // 
            this.shareTrackerProcedureBindingSource.DataMember = "ShareTrackerProcedure";
            this.shareTrackerProcedureBindingSource.DataSource = this.bharatDataSet1;
            // 
            // bharatDataSet1
            // 
            this.bharatDataSet1.DataSetName = "BharatDataSet1";
            this.bharatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateBuy
            // 
            this.dateBuy.Location = new System.Drawing.Point(221, 105);
            this.dateBuy.Name = "dateBuy";
            this.dateBuy.Size = new System.Drawing.Size(160, 22);
            this.dateBuy.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(90, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 23);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Buy Date: ";
            // 
            // btnShareAdd
            // 
            this.btnShareAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShareAdd.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnShareAdd.Location = new System.Drawing.Point(406, 48);
            this.btnShareAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareAdd.Name = "btnShareAdd";
            this.btnShareAdd.Size = new System.Drawing.Size(111, 40);
            this.btnShareAdd.TabIndex = 22;
            this.btnShareAdd.Text = "Add";
            this.btnShareAdd.UseVisualStyleBackColor = false;
            this.btnShareAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1172, 45);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 31);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rdDelivery
            // 
            this.rdDelivery.AutoSize = true;
            this.rdDelivery.Checked = true;
            this.rdDelivery.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rdDelivery.Location = new System.Drawing.Point(284, 11);
            this.rdDelivery.Name = "rdDelivery";
            this.rdDelivery.Size = new System.Drawing.Size(112, 31);
            this.rdDelivery.TabIndex = 30;
            this.rdDelivery.TabStop = true;
            this.rdDelivery.Text = "Delivery";
            this.rdDelivery.UseVisualStyleBackColor = true;
            // 
            // lblShareType
            // 
            this.lblShareType.AutoSize = true;
            this.lblShareType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblShareType.Location = new System.Drawing.Point(17, 11);
            this.lblShareType.Name = "lblShareType";
            this.lblShareType.Size = new System.Drawing.Size(135, 27);
            this.lblShareType.TabIndex = 31;
            this.lblShareType.Text = "Shares Type: ";
            // 
            // rdOption
            // 
            this.rdOption.AutoSize = true;
            this.rdOption.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rdOption.Location = new System.Drawing.Point(170, 11);
            this.rdOption.Name = "rdOption";
            this.rdOption.Size = new System.Drawing.Size(107, 31);
            this.rdOption.TabIndex = 29;
            this.rdOption.Text = "Options";
            this.rdOption.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblShareType);
            this.panel1.Controls.Add(this.rdDelivery);
            this.panel1.Controls.Add(this.rdOption);
            this.panel1.Location = new System.Drawing.Point(325, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 52);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBuyId);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtBuyPrice);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtBuyQty);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.dateBuy);
            this.panel2.Controls.Add(this.btnShareAdd);
            this.panel2.Location = new System.Drawing.Point(22, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 144);
            this.panel2.TabIndex = 37;
            // 
            // lblBuyId
            // 
            this.lblBuyId.AutoSize = true;
            this.lblBuyId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblBuyId.Location = new System.Drawing.Point(216, 10);
            this.lblBuyId.Name = "lblBuyId";
            this.lblBuyId.Size = new System.Drawing.Size(118, 27);
            this.lblBuyId.TabIndex = 23;
            this.lblBuyId.Text = "BuyIdLabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(99, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Share Id: ";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(221, 45);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(138, 22);
            this.txtBuyPrice.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Share Buy Price: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(14, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Share Buy Quantity:";
            // 
            // txtBuyQty
            // 
            this.txtBuyQty.Location = new System.Drawing.Point(221, 74);
            this.txtBuyQty.Name = "txtBuyQty";
            this.txtBuyQty.Size = new System.Drawing.Size(138, 22);
            this.txtBuyQty.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSellId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSellPrice);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtSellQty);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.dateSell);
            this.panel3.Controls.Add(this.btnShareSell);
            this.panel3.Location = new System.Drawing.Point(22, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 144);
            this.panel3.TabIndex = 38;
            // 
            // lblSellId
            // 
            this.lblSellId.AutoSize = true;
            this.lblSellId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblSellId.Location = new System.Drawing.Point(216, 13);
            this.lblSellId.Name = "lblSellId";
            this.lblSellId.Size = new System.Drawing.Size(116, 27);
            this.lblSellId.TabIndex = 23;
            this.lblSellId.Text = "SellIdLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(99, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Share Id: ";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(221, 45);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(138, 22);
            this.txtSellPrice.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Share Sell Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Share Sell Quantity: ";
            // 
            // txtSellQty
            // 
            this.txtSellQty.Location = new System.Drawing.Point(221, 74);
            this.txtSellQty.Name = "txtSellQty";
            this.txtSellQty.Size = new System.Drawing.Size(138, 22);
            this.txtSellQty.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(92, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Sell Date: ";
            // 
            // dateSell
            // 
            this.dateSell.Location = new System.Drawing.Point(221, 105);
            this.dateSell.Name = "dateSell";
            this.dateSell.Size = new System.Drawing.Size(160, 22);
            this.dateSell.TabIndex = 16;
            // 
            // btnShareSell
            // 
            this.btnShareSell.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShareSell.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnShareSell.Location = new System.Drawing.Point(406, 48);
            this.btnShareSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareSell.Name = "btnShareSell";
            this.btnShareSell.Size = new System.Drawing.Size(111, 40);
            this.btnShareSell.TabIndex = 22;
            this.btnShareSell.Text = "Add";
            this.btnShareSell.UseVisualStyleBackColor = false;
            this.btnShareSell.Click += new System.EventHandler(this.btnShareSell_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblChargeId);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtShareChargesAmt);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtShareChargesDesc);
            this.panel4.Controls.Add(this.btnShareCharge);
            this.panel4.Location = new System.Drawing.Point(22, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 115);
            this.panel4.TabIndex = 39;
            // 
            // lblChargeId
            // 
            this.lblChargeId.AutoSize = true;
            this.lblChargeId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblChargeId.Location = new System.Drawing.Point(216, 10);
            this.lblChargeId.Name = "lblChargeId";
            this.lblChargeId.Size = new System.Drawing.Size(147, 27);
            this.lblChargeId.TabIndex = 23;
            this.lblChargeId.Text = "ChargeIdLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(99, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Share Id: ";
            // 
            // txtShareChargesAmt
            // 
            this.txtShareChargesAmt.Location = new System.Drawing.Point(221, 45);
            this.txtShareChargesAmt.Name = "txtShareChargesAmt";
            this.txtShareChargesAmt.Size = new System.Drawing.Size(138, 22);
            this.txtShareChargesAmt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Share Charges: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Share Charges Name: ";
            // 
            // txtShareChargesDesc
            // 
            this.txtShareChargesDesc.Location = new System.Drawing.Point(221, 73);
            this.txtShareChargesDesc.Name = "txtShareChargesDesc";
            this.txtShareChargesDesc.Size = new System.Drawing.Size(138, 22);
            this.txtShareChargesDesc.TabIndex = 21;
            // 
            // btnShareCharge
            // 
            this.btnShareCharge.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShareCharge.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnShareCharge.Location = new System.Drawing.Point(406, 48);
            this.btnShareCharge.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareCharge.Name = "btnShareCharge";
            this.btnShareCharge.Size = new System.Drawing.Size(111, 40);
            this.btnShareCharge.TabIndex = 22;
            this.btnShareCharge.Text = "Add";
            this.btnShareCharge.UseVisualStyleBackColor = false;
            this.btnShareCharge.Click += new System.EventHandler(this.btnShareCharge_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtExtraChargeName);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.txtExtraChargeAmt);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.dateExtraCharge);
            this.panel5.Controls.Add(this.btnShareExtraCharge);
            this.panel5.Location = new System.Drawing.Point(22, 525);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(537, 129);
            this.panel5.TabIndex = 40;
            // 
            // txtExtraChargeName
            // 
            this.txtExtraChargeName.Location = new System.Drawing.Point(225, 59);
            this.txtExtraChargeName.Name = "txtExtraChargeName";
            this.txtExtraChargeName.Size = new System.Drawing.Size(138, 22);
            this.txtExtraChargeName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Extra Charges Name: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(7, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(192, 23);
            this.label18.TabIndex = 20;
            this.label18.Text = "Extra Charges Amount: ";
            // 
            // txtExtraChargeAmt
            // 
            this.txtExtraChargeAmt.Location = new System.Drawing.Point(225, 28);
            this.txtExtraChargeAmt.Name = "txtExtraChargeAmt";
            this.txtExtraChargeAmt.Size = new System.Drawing.Size(138, 22);
            this.txtExtraChargeAmt.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(30, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 23);
            this.label19.TabIndex = 15;
            this.label19.Text = "Extra Charges Date: ";
            // 
            // dateExtraCharge
            // 
            this.dateExtraCharge.Location = new System.Drawing.Point(225, 90);
            this.dateExtraCharge.Name = "dateExtraCharge";
            this.dateExtraCharge.Size = new System.Drawing.Size(160, 22);
            this.dateExtraCharge.TabIndex = 16;
            // 
            // btnShareExtraCharge
            // 
            this.btnShareExtraCharge.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShareExtraCharge.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnShareExtraCharge.Location = new System.Drawing.Point(403, 36);
            this.btnShareExtraCharge.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareExtraCharge.Name = "btnShareExtraCharge";
            this.btnShareExtraCharge.Size = new System.Drawing.Size(111, 40);
            this.btnShareExtraCharge.TabIndex = 22;
            this.btnShareExtraCharge.Text = "Add";
            this.btnShareExtraCharge.UseVisualStyleBackColor = false;
            this.btnShareExtraCharge.Click += new System.EventHandler(this.btnShareExtraCharge_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1157, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 17);
            this.lblUser.TabIndex = 41;
            this.lblUser.Text = "lblUser";
            // 
            // lblShareName
            // 
            this.lblShareName.AutoSize = true;
            this.lblShareName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShareName.Location = new System.Drawing.Point(14, 25);
            this.lblShareName.Name = "lblShareName";
            this.lblShareName.Size = new System.Drawing.Size(112, 23);
            this.lblShareName.TabIndex = 42;
            this.lblShareName.Text = "Share Name: ";
            // 
            // txtShareName
            // 
            this.txtShareName.Location = new System.Drawing.Point(136, 26);
            this.txtShareName.Name = "txtShareName";
            this.txtShareName.Size = new System.Drawing.Size(175, 22);
            this.txtShareName.TabIndex = 43;
            // 
            // btnShareHeader
            // 
            this.btnShareHeader.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShareHeader.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnShareHeader.Location = new System.Drawing.Point(762, 19);
            this.btnShareHeader.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareHeader.Name = "btnShareHeader";
            this.btnShareHeader.Size = new System.Drawing.Size(100, 35);
            this.btnShareHeader.TabIndex = 24;
            this.btnShareHeader.Text = "Add";
            this.btnShareHeader.UseVisualStyleBackColor = false;
            this.btnShareHeader.Click += new System.EventHandler(this.btnShareHeader_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 28);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(901, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 23);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "Total : ";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(979, 26);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(62, 23);
            this.lblTotalValue.TabIndex = 45;
            this.lblTotalValue.Text = "Total : ";
            // 
            // shareTrackerProcedureTableAdapter
            // 
            this.shareTrackerProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1266, 710);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnShareHeader);
            this.Controls.Add(this.txtShareName);
            this.Controls.Add(this.lblShareName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shareTrackerProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateBuy;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnShareAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblShareType;
        private System.Windows.Forms.RadioButton rdDelivery;
        private System.Windows.Forms.RadioButton rdOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES_CATEGORY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES_TRACKER_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBuyId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuyQty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSellId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSellQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateSell;
        private System.Windows.Forms.Button btnShareSell;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblChargeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShareChargesAmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShareCharge;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtExtraChargeAmt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateExtraCharge;
        private System.Windows.Forms.Button btnShareExtraCharge;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtShareName;
        private System.Windows.Forms.Label lblShareName;
        private System.Windows.Forms.Button btnShareHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShareChargesDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtraChargeName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.BindingSource shareTrackerProcedureBindingSource;
        private BharatDataSet1 bharatDataSet1;
        private BharatDataSet1TableAdapters.ShareTrackerProcedureTableAdapter shareTrackerProcedureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHAREAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFITLOSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESTRACKERHEADERIDDataGridViewTextBoxColumn;
    }
}

