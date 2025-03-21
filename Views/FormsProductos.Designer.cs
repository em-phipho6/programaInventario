namespace aplicacionInventario4
{
  partial class FormsProductos
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

        #region Windows Forms Designer generated code
        private void InitializeComponent()
        {
            AtrasButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ComprarProductoButton = new Button();
            VenderProductoButton = new Button();
            label7 = new Label();
            label8 = new Label();
            CantidadLabel = new Label();
            PrecioInternoProductoLabel = new Label();
            DescripcionProductoLabel = new Label();
            IdProductoLabel = new Label();
            PrecioVentaProductoLabel = new Label();
            CategoriaProductoLabel = new Label();
            IdProductoComboBox = new ComboBox();
            SuspendLayout();
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(305, 344);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(75, 23);
            AtrasButton.TabIndex = 23;
            AtrasButton.Text = "Atrás";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += AtrasButton_Click;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 191);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 19;
            label5.Text = "Precio de Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 190);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 17;
            label4.Text = "Precio Interno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 117);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 15;
            label3.Text = "Descripción del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 79);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 13;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 25);
            label1.Name = "label1";
            label1.Size = new Size(310, 28);
            label1.TabIndex = 12;
            label1.Text = "Mostrar información del producto";
            // 
            // ComprarProductoButton
            // 
            ComprarProductoButton.Location = new Point(27, 344);
            ComprarProductoButton.Name = "ComprarProductoButton";
            ComprarProductoButton.Size = new Size(116, 23);
            ComprarProductoButton.TabIndex = 24;
            ComprarProductoButton.Text = "Comprar producto";
            ComprarProductoButton.UseVisualStyleBackColor = true;
            ComprarProductoButton.Click += ComprarProductoButton_Click;
            // 
            // VenderProductoButton
            // 
            VenderProductoButton.Location = new Point(173, 344);
            VenderProductoButton.Name = "VenderProductoButton";
            VenderProductoButton.Size = new Size(107, 23);
            VenderProductoButton.TabIndex = 25;
            VenderProductoButton.Text = "Vender producto";
            VenderProductoButton.UseVisualStyleBackColor = true;
            VenderProductoButton.Click += VenderProductoButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 261);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 26;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 261);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 29;
            label8.Text = "Cantidad";
            // 
            // CantidadLabel
            // 
            CantidadLabel.AutoSize = true;
            CantidadLabel.BackColor = SystemColors.GradientInactiveCaption;
            CantidadLabel.Location = new Point(45, 282);
            CantidadLabel.Name = "CantidadLabel";
            CantidadLabel.Size = new Size(105, 20);
            CantidadLabel.TabIndex = 30;
            CantidadLabel.Text = "CantidadLabel";
            // 
            // PrecioInternoProductoLabel
            // 
            PrecioInternoProductoLabel.AutoSize = true;
            PrecioInternoProductoLabel.BackColor = SystemColors.GradientInactiveCaption;
            PrecioInternoProductoLabel.Location = new Point(48, 223);
            PrecioInternoProductoLabel.Name = "PrecioInternoProductoLabel";
            PrecioInternoProductoLabel.Size = new Size(193, 20);
            PrecioInternoProductoLabel.TabIndex = 31;
            PrecioInternoProductoLabel.Text = "PrecioInternoProductoLabel";
            // 
            // DescripcionProductoLabel
            // 
            DescripcionProductoLabel.AutoSize = true;
            DescripcionProductoLabel.BackColor = SystemColors.GradientInactiveCaption;
            DescripcionProductoLabel.ForeColor = SystemColors.ControlText;
            DescripcionProductoLabel.Location = new Point(50, 148);
            DescripcionProductoLabel.Name = "DescripcionProductoLabel";
            DescripcionProductoLabel.Size = new Size(183, 20);
            DescripcionProductoLabel.TabIndex = 33;
            DescripcionProductoLabel.Text = "DescripcionProductoLabel";
            // 
            // IdProductoLabel
            // 
            IdProductoLabel.AutoSize = true;
            IdProductoLabel.BackColor = SystemColors.GradientInactiveCaption;
            IdProductoLabel.Location = new Point(60, 57);
            IdProductoLabel.Name = "IdProductoLabel";
            IdProductoLabel.Size = new Size(118, 20);
            IdProductoLabel.TabIndex = 34;
            IdProductoLabel.Text = "IdProductoLabel";
            // 
            // PrecioVentaProductoLabel
            // 
            PrecioVentaProductoLabel.AutoSize = true;
            PrecioVentaProductoLabel.BackColor = SystemColors.GradientInactiveCaption;
            PrecioVentaProductoLabel.Location = new Point(240, 218);
            PrecioVentaProductoLabel.Name = "PrecioVentaProductoLabel";
            PrecioVentaProductoLabel.Size = new Size(183, 20);
            PrecioVentaProductoLabel.TabIndex = 35;
            PrecioVentaProductoLabel.Text = "PrecioVentaProductoLabel";
            // 
            // CategoriaProductoLabel
            // 
            CategoriaProductoLabel.AutoSize = true;
            CategoriaProductoLabel.BackColor = SystemColors.GradientInactiveCaption;
            CategoriaProductoLabel.Location = new Point(242, 285);
            CategoriaProductoLabel.Name = "CategoriaProductoLabel";
            CategoriaProductoLabel.Size = new Size(170, 20);
            CategoriaProductoLabel.TabIndex = 36;
            CategoriaProductoLabel.Text = "CategoriaProductoLabel";
            // 
            // IdProductoComboBox
            // 
            IdProductoComboBox.FormattingEnabled = true;
            IdProductoComboBox.Location = new Point(60, 79);
            IdProductoComboBox.Name = "IdProductoComboBox";
            IdProductoComboBox.Size = new Size(121, 28);
            IdProductoComboBox.TabIndex = 37;
            IdProductoComboBox.SelectionChangeCommitted += IdProductoComboBox_SelectionChangeCommitted;
            // 
            // FormsProductos
            // 
            ClientSize = new Size(442, 401);
            Controls.Add(IdProductoComboBox);
            Controls.Add(CategoriaProductoLabel);
            Controls.Add(PrecioVentaProductoLabel);
            Controls.Add(IdProductoLabel);
            Controls.Add(DescripcionProductoLabel);
            Controls.Add(PrecioInternoProductoLabel);
            Controls.Add(CantidadLabel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(VenderProductoButton);
            Controls.Add(ComprarProductoButton);
            Controls.Add(AtrasButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormsProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormsProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion




        private Button AtrasButton;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button ComprarProductoButton;
    private Button VenderProductoButton;
    private Label label7;
    private Label label8;
    private Label CantidadLabel;
    private Label PrecioInternoProductoLabel;
    private Label DescripcionProductoLabel;
    private Label IdProductoLabel;
    private Label PrecioVentaProductoLabel;
    private Label CategoriaProductoLabel;
        private ComboBox IdProductoComboBox;
    }
}