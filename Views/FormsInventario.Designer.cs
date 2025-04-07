namespace aplicacionInventario4
{
  partial class FormsInventario
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
            AgregarProductoButton = new Button();
            label1 = new Label();
            ProductosDataGridView = new DataGridView();
            AtrasButton = new Button();
            BuscarProductoButton = new Button();
            EliminarProductoButton = new Button();
            VerGraficasButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Location = new Point(657, 535);
            AgregarProductoButton.Margin = new Padding(3, 4, 3, 4);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(151, 35);
            AgregarProductoButton.TabIndex = 0;
            AgregarProductoButton.Text = "Agregar Producto";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            AgregarProductoButton.Click += AgregarProductoButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // ProductosDataGridView
            // 
            ProductosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDataGridView.Location = new Point(14, 77);
            ProductosDataGridView.Margin = new Padding(3, 4, 3, 4);
            ProductosDataGridView.Name = "ProductosDataGridView";
            ProductosDataGridView.RowHeadersWidth = 51;
            ProductosDataGridView.Size = new Size(863, 431);
            ProductosDataGridView.TabIndex = 2;
            ProductosDataGridView.CellFormatting += ProductosDataGridView_CellFormatting;
            ProductosDataGridView.MouseEnter += ProductosDataGridView_MouseEnter;
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(97, 539);
            AtrasButton.Margin = new Padding(3, 4, 3, 4);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(86, 31);
            AtrasButton.TabIndex = 3;
            AtrasButton.Text = "Atrás";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += atrasButton_Click;
            // 
            // BuscarProductoButton
            // 
            BuscarProductoButton.Location = new Point(458, 537);
            BuscarProductoButton.Margin = new Padding(3, 4, 3, 4);
            BuscarProductoButton.Name = "BuscarProductoButton";
            BuscarProductoButton.Size = new Size(118, 31);
            BuscarProductoButton.TabIndex = 4;
            BuscarProductoButton.Text = "Buscar producto";
            BuscarProductoButton.UseVisualStyleBackColor = true;
            BuscarProductoButton.Click += BuscarProductoButton_Click;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(264, 539);
            EliminarProductoButton.Margin = new Padding(3, 4, 3, 4);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(150, 31);
            EliminarProductoButton.TabIndex = 5;
            EliminarProductoButton.Text = "Eliminar producto";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            EliminarProductoButton.Click += EliminarProductoButton_Click;
            // 
            // VerGraficasButton
            // 
            VerGraficasButton.Location = new Point(622, 27);
            VerGraficasButton.Margin = new Padding(3, 4, 3, 4);
            VerGraficasButton.Name = "VerGraficasButton";
            VerGraficasButton.Size = new Size(108, 31);
            VerGraficasButton.TabIndex = 6;
            VerGraficasButton.Text = "Ver gráficas";
            VerGraficasButton.UseVisualStyleBackColor = true;
            VerGraficasButton.Click += VerGraficasButton_Click;
            // 
            // FormsInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(VerGraficasButton);
            Controls.Add(EliminarProductoButton);
            Controls.Add(BuscarProductoButton);
            Controls.Add(AtrasButton);
            Controls.Add(ProductosDataGridView);
            Controls.Add(label1);
            Controls.Add(AgregarProductoButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormsInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            Load += FormsInventario_Load;
            ((System.ComponentModel.ISupportInitialize)ProductosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AgregarProductoButton;
    private Label label1;
    private DataGridView ProductosDataGridView;
    private Button AtrasButton;
        private Button BuscarProductoButton;
        private Button EliminarProductoButton;
        private Button VerGraficasButton;
    }
}