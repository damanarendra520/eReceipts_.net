namespace eReceipts
{
    partial class graphicalViewResults
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graphicalViewResults));
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_data
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_data.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_data.Legends.Add(legend2);
            this.chart_data.Location = new System.Drawing.Point(12, 50);
            this.chart_data.Name = "chart_data";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "spendings";
            this.chart_data.Series.Add(series2);
            this.chart_data.Size = new System.Drawing.Size(461, 305);
            this.chart_data.TabIndex = 0;
            this.chart_data.Text = "chart1";
            // 
            // graphicalViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 367);
            this.Controls.Add(this.chart_data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "graphicalViewResults";
            this.Text = "graphicalViewResults";
            this.Load += new System.EventHandler(this.load_chart_data);
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_data;
        //private System.Windows.Forms.Button reload_chart_data;
    }
}