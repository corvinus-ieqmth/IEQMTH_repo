
namespace Webservice
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateFirst = new System.Windows.Forms.DateTimePicker();
            this.dateLast = new System.Windows.Forms.DateTimePicker();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.getCurrenciesResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(2, 111);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.Size = new System.Drawing.Size(610, 822);
            this.dgw.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRateData.Legends.Add(legend3);
            this.chartRateData.Location = new System.Drawing.Point(618, 111);
            this.chartRateData.Name = "chartRateData";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRateData.Series.Add(series3);
            this.chartRateData.Size = new System.Drawing.Size(633, 822);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // dateFirst
            // 
            this.dateFirst.Location = new System.Drawing.Point(13, 50);
            this.dateFirst.Name = "dateFirst";
            this.dateFirst.Size = new System.Drawing.Size(200, 22);
            this.dateFirst.TabIndex = 2;
            this.dateFirst.ValueChanged += new System.EventHandler(this.dateFirst_ValueChanged);
            // 
            // dateLast
            // 
            this.dateLast.Location = new System.Drawing.Point(240, 50);
            this.dateLast.Name = "dateLast";
            this.dateLast.Size = new System.Drawing.Size(200, 22);
            this.dateLast.TabIndex = 3;
            this.dateLast.ValueChanged += new System.EventHandler(this.dateLast_ValueChanged);
            // 
            // comboBox
            // 
            this.comboBox.DataSource = this.getCurrenciesResponseBindingSource;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(462, 50);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(306, 24);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(516, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // getCurrenciesResponseBindingSource
            // 
            this.getCurrenciesResponseBindingSource.DataSource = typeof(Webservice.MNBServiceReference.GetCurrenciesResponse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 935);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dateLast);
            this.Controls.Add(this.dateFirst);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dgw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesResponseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker dateFirst;
        private System.Windows.Forms.DateTimePicker dateLast;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource getCurrenciesResponseBindingSource;
    }
}

