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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHARESNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHAREAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFITLOSSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHARESTRACKERHEADERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareTrackerProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bharatDataSet = new ShareTracker.BharatDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rdDelivery = new System.Windows.Forms.RadioButton();
            this.lblShareType = new System.Windows.Forms.Label();
            this.rdOption = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shareTrackerProcedureTableAdapter = new ShareTracker.BharatDataSetTableAdapters.ShareTrackerProcedureTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shareTrackerProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(1006, 345);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 40);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            
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
            this.dataGridView1.Location = new System.Drawing.Point(647, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(503, 594);
            this.dataGridView1.TabIndex = 5;
            
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
            this.sHARESNAMEDataGridViewTextBoxColumn.HeaderText = "Share Name";
            this.sHARESNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHARESNAMEDataGridViewTextBoxColumn.Name = "sHARESNAMEDataGridViewTextBoxColumn";
            // 
            // sHAREAMTDataGridViewTextBoxColumn
            // 
            this.sHAREAMTDataGridViewTextBoxColumn.DataPropertyName = "SHARE_AMT";
            this.sHAREAMTDataGridViewTextBoxColumn.HeaderText = "Share Amt";
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
            this.shareTrackerProcedureBindingSource.DataSource = this.bharatDataSet;
            // 
            // bharatDataSet
            // 
            this.bharatDataSet.DataSetName = "BharatDataSet";
            this.bharatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Location = new System.Drawing.Point(221, 105);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerExpense.TabIndex = 16;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(406, 48);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 40);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(776, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 44);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            
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
            this.rdOption.Location = new System.Drawing.Point(158, 11);
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
            this.panel1.Location = new System.Drawing.Point(71, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 52);
            this.panel1.TabIndex = 32;
            // 
            // shareTrackerProcedureTableAdapter
            // 
            this.shareTrackerProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.dateTimePickerExpense);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(22, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 144);
            this.panel2.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(216, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "BuyIdLabel";
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(221, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 22);
            this.textBox5.TabIndex = 21;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(221, 74);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(138, 22);
            this.textBox6.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(22, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 144);
            this.panel3.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(216, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "SellIdLabel";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 21;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 21;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(406, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(22, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 144);
            this.panel4.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(216, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "ChargeIdLabel";
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 22);
            this.textBox3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Share Buy Price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(54, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Share Quantity: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 22);
            this.textBox4.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(11, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "Charge Applied Date: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(221, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(406, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.textBox8);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.dateTimePicker3);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(19, 550);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(537, 106);
            this.panel5.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(58, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 23);
            this.label18.TabIndex = 20;
            this.label18.Text = "Extra Charges: ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(225, 28);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 22);
            this.textBox8.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(24, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 23);
            this.label19.TabIndex = 15;
            this.label19.Text = "Extra Charges Date: ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(225, 60);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(410, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1182, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "lblUser";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1266, 710);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shareTrackerProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
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
        private BharatDataSet bharatDataSet;
        private System.Windows.Forms.BindingSource shareTrackerProcedureBindingSource;
        private BharatDataSetTableAdapters.ShareTrackerProcedureTableAdapter shareTrackerProcedureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHAREAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFITLOSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESTRACKERHEADERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
    }
}

