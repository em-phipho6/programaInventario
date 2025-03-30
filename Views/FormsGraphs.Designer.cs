namespace aplicacionInventario4.Views
{
    partial class FormsGraphs
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
            CantidadChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)CantidadChart).BeginInit();
            SuspendLayout();
            // 
            // CantidadChart
            // 
            chartArea2.Name = "ChartArea1";
            CantidadChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            CantidadChart.Legends.Add(legend2);
            CantidadChart.Location = new Point(86, 28);
            CantidadChart.Name = "CantidadChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            CantidadChart.Series.Add(series2);
            CantidadChart.Size = new Size(608, 348);
            CantidadChart.TabIndex = 0;
            CantidadChart.Text = "chart1";
            // 
            // FormsGraphs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CantidadChart);
            Name = "FormsGraphs";
            Text = "FormsGraphs";
            Load += FormsGraphs_Load;
            ((System.ComponentModel.ISupportInitialize)CantidadChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CantidadChart;
    }
}