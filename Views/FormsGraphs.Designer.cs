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
            GraficaCantidadProducto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            AtrasButton = new Button();
            ((System.ComponentModel.ISupportInitialize)GraficaCantidadProducto).BeginInit();
            SuspendLayout();
            // 
            // GraficaCantidadProducto
            // 
            chartArea2.Name = "ChartArea1";
            GraficaCantidadProducto.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            GraficaCantidadProducto.Legends.Add(legend2);
            GraficaCantidadProducto.Location = new Point(42, 28);
            GraficaCantidadProducto.Name = "GraficaCantidadProducto";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            GraficaCantidadProducto.Series.Add(series2);
            GraficaCantidadProducto.Size = new Size(617, 400);
            GraficaCantidadProducto.TabIndex = 0;
            GraficaCantidadProducto.Text = "GraficaCantidadProducto";
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(697, 405);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(75, 23);
            AtrasButton.TabIndex = 1;
            AtrasButton.Text = "Atras";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += AtrasButton_Click;
            // 
            // FormsGraphs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AtrasButton);
            Controls.Add(GraficaCantidadProducto);
            Name = "FormsGraphs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormsGraphs";
            Load += FormsGraphs_Load;
            ((System.ComponentModel.ISupportInitialize)GraficaCantidadProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaCantidadProducto;
        private Button AtrasButton;
    }
}