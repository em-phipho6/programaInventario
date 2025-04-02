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
            AgregarProductoButton.Location = new Point(575, 401);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(132, 26);
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
            label1.Location = new Point(348, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // ProductosDataGridView
            // 
            ProductosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDataGridView.Location = new Point(12, 58);
            ProductosDataGridView.Name = "ProductosDataGridView";
            ProductosDataGridView.Size = new Size(755, 323);
            ProductosDataGridView.TabIndex = 2;
            ProductosDataGridView.CellFormatting += ProductosDataGridView_CellFormatting;
            ProductosDataGridView.MouseEnter += ProductosDataGridView_MouseEnter;
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(85, 404);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(75, 23);
            AtrasButton.TabIndex = 3;
            AtrasButton.Text = "Atrás";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += atrasButton_Click;
            // 
            // BuscarProductoButton
            // 
            BuscarProductoButton.Location = new Point(401, 403);
            BuscarProductoButton.Name = "BuscarProductoButton";
            BuscarProductoButton.Size = new Size(103, 23);
            BuscarProductoButton.TabIndex = 4;
            BuscarProductoButton.Text = "Buscar producto";
            BuscarProductoButton.UseVisualStyleBackColor = true;
            BuscarProductoButton.Click += BuscarProductoButton_Click;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(231, 404);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(131, 23);
            EliminarProductoButton.TabIndex = 5;
            EliminarProductoButton.Text = "Eliminar producto";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            EliminarProductoButton.Click += EliminarProductoButton_Click;
            // 
            // VerGraficasButton
            // 
            VerGraficasButton.Location = new Point(544, 20);
            VerGraficasButton.Name = "VerGraficasButton";
            VerGraficasButton.Size = new Size(75, 23);
            VerGraficasButton.TabIndex = 6;
            VerGraficasButton.Text = "Ver gráficas";
            VerGraficasButton.UseVisualStyleBackColor = true;
            VerGraficasButton.Click += VerGraficasButton_Click;
            // 
            // FormsInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VerGraficasButton);
            Controls.Add(EliminarProductoButton);
            Controls.Add(BuscarProductoButton);
            Controls.Add(AtrasButton);
            Controls.Add(ProductosDataGridView);
            Controls.Add(label1);
            Controls.Add(AgregarProductoButton);
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