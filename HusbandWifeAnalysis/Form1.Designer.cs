namespace HusbandWifeAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.husbandWifeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bharatDataSet = new HusbandWifeAnalysis.BharatDataSet();
            this.husband_WifeTableAdapter = new HusbandWifeAnalysis.BharatDataSetTableAdapters.Husband_WifeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.husbandWifeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.husbandWifeBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Money";
            series1.XValueMember = "Expenses_Category_Name";
            series1.YValueMembers = "Amount";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(910, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Expenses Analysis";
            title1.ToolTip = "Expenses Analysis";
            this.chart1.Titles.Add(title1);
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
            // husband_WifeTableAdapter
            // 
            this.husband_WifeTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(977, 506);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Expenses Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.husbandWifeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private BharatDataSet bharatDataSet;
        private System.Windows.Forms.BindingSource husbandWifeBindingSource;
        private BharatDataSetTableAdapters.Husband_WifeTableAdapter husband_WifeTableAdapter;
    }
}

