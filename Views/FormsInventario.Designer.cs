﻿namespace aplicacionInventario4
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
            ProductosDataGridView.RowEnter += ProductosDataGridView_RowEnter;
            ProductosDataGridView.RowLeave += ProductosDataGridView_RowLeave;
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
            // FormsInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AtrasButton);
            Controls.Add(ProductosDataGridView);
            Controls.Add(label1);
            Controls.Add(AgregarProductoButton);
            Name = "FormsInventario";
            Text = "FormsInventario";
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
  }
}