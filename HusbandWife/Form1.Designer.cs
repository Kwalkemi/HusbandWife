namespace HusbandWife
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateWife = new System.Windows.Forms.Button();
            this.btnWife = new System.Windows.Forms.Button();
            this.dateTimePickerwife = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWife = new System.Windows.Forms.Label();
            this.btnUpdateHusb = new System.Windows.Forms.Button();
            this.btnHusband = new System.Windows.Forms.Button();
            this.dateTimePickerhusb = new System.Windows.Forms.DateTimePicker();
            this.txthusband = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtwifespend = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.husbandWifeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.husbandWifeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.husbandWifeAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.husbandWifeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPENSES_CATEGORY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.husbandWifeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bharatDataSet = new HusbandWife.BharatDataSet();
            this.lblResult = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.husband_WifeTableAdapter = new HusbandWife.BharatDataSetTableAdapters.Husband_WifeTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCtgry = new System.Windows.Forms.Button();
            this.btnRmvCtgry = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.husbandWifeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Goldenrod;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(393, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(877, 572);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel1.Controls.Add(this.cmbcategory);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdateWife);
            this.splitContainer1.Panel1.Controls.Add(this.btnWife);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerwife);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblWife);
            this.splitContainer1.Panel1.Tag = "WifeContainter";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdateHusb);
            this.splitContainer1.Panel2.Controls.Add(this.btnHusband);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerhusb);
            this.splitContainer1.Panel2.Controls.Add(this.txthusband);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Tag = "HusbandContainer";
            this.splitContainer1.Size = new System.Drawing.Size(393, 572);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 1;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(183, 151);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(121, 24);
            this.cmbcategory.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(75, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Category: ";
            // 
            // btnUpdateWife
            // 
            this.btnUpdateWife.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateWife.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateWife.Location = new System.Drawing.Point(201, 194);
            this.btnUpdateWife.Name = "btnUpdateWife";
            this.btnUpdateWife.Size = new System.Drawing.Size(127, 40);
            this.btnUpdateWife.TabIndex = 6;
            this.btnUpdateWife.Text = "Update";
            this.btnUpdateWife.UseVisualStyleBackColor = false;
            this.btnUpdateWife.Click += new System.EventHandler(this.btnUpdateWife_Click);
            // 
            // btnWife
            // 
            this.btnWife.BackColor = System.Drawing.Color.LimeGreen;
            this.btnWife.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnWife.Location = new System.Drawing.Point(48, 195);
            this.btnWife.Name = "btnWife";
            this.btnWife.Size = new System.Drawing.Size(127, 40);
            this.btnWife.TabIndex = 3;
            this.btnWife.Text = "Add";
            this.btnWife.UseVisualStyleBackColor = false;
            this.btnWife.Click += new System.EventHandler(this.btnWife_Click);
            // 
            // dateTimePickerwife
            // 
            this.dateTimePickerwife.Location = new System.Drawing.Point(183, 106);
            this.dateTimePickerwife.Name = "dateTimePickerwife";
            this.dateTimePickerwife.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerwife.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Spend Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spend Amount: ";
            // 
            // lblWife
            // 
            this.lblWife.AutoSize = true;
            this.lblWife.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWife.Location = new System.Drawing.Point(153, 8);
            this.lblWife.Name = "lblWife";
            this.lblWife.Size = new System.Drawing.Size(66, 32);
            this.lblWife.TabIndex = 0;
            this.lblWife.Text = "Wife";
            // 
            // btnUpdateHusb
            // 
            this.btnUpdateHusb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdateHusb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateHusb.Location = new System.Drawing.Point(201, 202);
            this.btnUpdateHusb.Name = "btnUpdateHusb";
            this.btnUpdateHusb.Size = new System.Drawing.Size(127, 40);
            this.btnUpdateHusb.TabIndex = 9;
            this.btnUpdateHusb.Text = "Update";
            this.btnUpdateHusb.UseVisualStyleBackColor = false;
            this.btnUpdateHusb.Click += new System.EventHandler(this.btnUpdateHusb_Click);
            // 
            // btnHusband
            // 
            this.btnHusband.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHusband.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnHusband.Location = new System.Drawing.Point(48, 202);
            this.btnHusband.Name = "btnHusband";
            this.btnHusband.Size = new System.Drawing.Size(127, 40);
            this.btnHusband.TabIndex = 8;
            this.btnHusband.Text = "Add";
            this.btnHusband.UseVisualStyleBackColor = false;
            this.btnHusband.Click += new System.EventHandler(this.btnHusband_Click);
            // 
            // dateTimePickerhusb
            // 
            this.dateTimePickerhusb.Location = new System.Drawing.Point(188, 133);
            this.dateTimePickerhusb.Name = "dateTimePickerhusb";
            this.dateTimePickerhusb.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerhusb.TabIndex = 7;
            // 
            // txthusband
            // 
            this.txthusband.Location = new System.Drawing.Point(190, 80);
            this.txthusband.Name = "txthusband";
            this.txthusband.Size = new System.Drawing.Size(138, 22);
            this.txthusband.TabIndex = 6;
            this.txthusband.TextChanged += new System.EventHandler(this.txthusband_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(54, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Return Date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Return Amount: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Husband";
            // 
            // txtwifespend
            // 
            this.txtwifespend.Location = new System.Drawing.Point(184, 52);
            this.txtwifespend.Name = "txtwifespend";
            this.txtwifespend.Size = new System.Drawing.Size(138, 22);
            this.txtwifespend.TabIndex = 2;
            this.txtwifespend.TextChanged += new System.EventHandler(this.txtwifespend_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno,
            this.husbandWifeIdDataGridViewTextBoxColumn,
            this.husbandWifeTypeDataGridViewTextBoxColumn,
            this.husbandWifeAmtDataGridViewTextBoxColumn,
            this.husbandWifeDateDataGridViewTextBoxColumn,
            this.EXPENSES_CATEGORY_NAME});
            this.dataGridView1.DataSource = this.husbandWifeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(421, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 433);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Sno
            // 
            this.Sno.HeaderText = "Serial No";
            this.Sno.MinimumWidth = 6;
            this.Sno.Name = "Sno";
            // 
            // husbandWifeIdDataGridViewTextBoxColumn
            // 
            this.husbandWifeIdDataGridViewTextBoxColumn.DataPropertyName = "Husband_Wife_Id";
            this.husbandWifeIdDataGridViewTextBoxColumn.HeaderText = "Husband_Wife_Id";
            this.husbandWifeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.husbandWifeIdDataGridViewTextBoxColumn.Name = "husbandWifeIdDataGridViewTextBoxColumn";
            this.husbandWifeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.husbandWifeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // husbandWifeTypeDataGridViewTextBoxColumn
            // 
            this.husbandWifeTypeDataGridViewTextBoxColumn.DataPropertyName = "Husband_Wife_Type";
            this.husbandWifeTypeDataGridViewTextBoxColumn.HeaderText = "Husband_Wife_Type";
            this.husbandWifeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.husbandWifeTypeDataGridViewTextBoxColumn.Name = "husbandWifeTypeDataGridViewTextBoxColumn";
            this.husbandWifeTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // husbandWifeAmtDataGridViewTextBoxColumn
            // 
            this.husbandWifeAmtDataGridViewTextBoxColumn.DataPropertyName = "Husband_Wife_Amt";
            this.husbandWifeAmtDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.husbandWifeAmtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.husbandWifeAmtDataGridViewTextBoxColumn.Name = "husbandWifeAmtDataGridViewTextBoxColumn";
            // 
            // husbandWifeDateDataGridViewTextBoxColumn
            // 
            this.husbandWifeDateDataGridViewTextBoxColumn.DataPropertyName = "Husband_Wife_Date";
            this.husbandWifeDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.husbandWifeDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.husbandWifeDateDataGridViewTextBoxColumn.Name = "husbandWifeDateDataGridViewTextBoxColumn";
            // 
            // EXPENSES_CATEGORY_NAME
            // 
            this.EXPENSES_CATEGORY_NAME.DataPropertyName = "EXPENSES_CATEGORY_NAME";
            this.EXPENSES_CATEGORY_NAME.HeaderText = "Category";
            this.EXPENSES_CATEGORY_NAME.MinimumWidth = 6;
            this.EXPENSES_CATEGORY_NAME.Name = "EXPENSES_CATEGORY_NAME";
            this.EXPENSES_CATEGORY_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EXPENSES_CATEGORY_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // husbandWifeBindingSource
            // 
            this.husbandWifeBindingSource.DataMember = "Husband_Wife";
            this.husbandWifeBindingSource.DataSource = this.bharatDataSet;
            // 
            // bharatDataSet
            // 
            this.bharatDataSet.DataSetName = "BharatDataSet";
            this.bharatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Goldenrod;
            this.lblResult.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(479, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(66, 27);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // husband_WifeTableAdapter
            // 
            this.husband_WifeTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Goldenrod;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1081, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "Settings";
            // 
            // btnAddCtgry
            // 
            this.btnAddCtgry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddCtgry.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCtgry.Location = new System.Drawing.Point(1061, 126);
            this.btnAddCtgry.Name = "btnAddCtgry";
            this.btnAddCtgry.Size = new System.Drawing.Size(169, 44);
            this.btnAddCtgry.TabIndex = 6;
            this.btnAddCtgry.Text = "Add Category";
            this.btnAddCtgry.UseVisualStyleBackColor = false;
            this.btnAddCtgry.Click += new System.EventHandler(this.btnAddCtgry_Click);
            // 
            // btnRmvCtgry
            // 
            this.btnRmvCtgry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRmvCtgry.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnRmvCtgry.Location = new System.Drawing.Point(1052, 208);
            this.btnRmvCtgry.Name = "btnRmvCtgry";
            this.btnRmvCtgry.Size = new System.Drawing.Size(185, 44);
            this.btnRmvCtgry.TabIndex = 7;
            this.btnRmvCtgry.Text = "Remove Category";
            this.btnRmvCtgry.UseVisualStyleBackColor = false;
            this.btnRmvCtgry.Click += new System.EventHandler(this.btnRmvCtgry_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1061, 290);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 44);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnalysis.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnalysis.Location = new System.Drawing.Point(1061, 375);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(169, 44);
            this.btnAnalysis.TabIndex = 9;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = false;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 572);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRmvCtgry);
            this.Controls.Add(this.btnAddCtgry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtwifespend);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Husband Wife Money Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.husbandWifeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblWife;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtwifespend;
        private System.Windows.Forms.TextBox txthusband;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerwife;
        private System.Windows.Forms.DateTimePicker dateTimePickerhusb;
        private System.Windows.Forms.Button btnWife;
        private System.Windows.Forms.Button btnHusband;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUpdateWife;
        private System.Windows.Forms.Button btnUpdateHusb;
        private BharatDataSet bharatDataSet;
        private System.Windows.Forms.BindingSource husbandWifeBindingSource;
        private BharatDataSetTableAdapters.Husband_WifeTableAdapter husband_WifeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn husbandWifeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn husbandWifeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn husbandWifeAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn husbandWifeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES_CATEGORY_NAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddCtgry;
        private System.Windows.Forms.Button btnRmvCtgry;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAnalysis;
    }
}

