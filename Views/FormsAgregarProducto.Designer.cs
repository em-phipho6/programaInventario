namespace aplicacionInventario4
{
  partial class FormsAgregarProducto
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
      label1 = new Label();
      label2 = new Label();
      IdTextBox = new TextBox();
      label3 = new Label();
      DescripcionProductoTextBox = new TextBox();
      label4 = new Label();
      PrecioInternoTextBox = new TextBox();
      label5 = new Label();
      PrecioVentaTextBox = new TextBox();
      label6 = new Label();
      CantidadTextBox = new TextBox();
      AgregarProductoButton = new Button();
      label7 = new Label();
      CategoriaComboBox = new ComboBox();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BackColor = Color.LightCoral;
      label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label1.Location = new Point(139, 27);
      label1.Name = "label1";
      label1.Size = new Size(180, 21);
      label1.TabIndex = 0;
      label1.Text = "Agregar nuevo producto";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(34, 76);
      label2.Name = "label2";
      label2.Size = new Size(21, 15);
      label2.TabIndex = 1;
      label2.Text = "ID:";
      // 
      // IdTextBox
      // 
      IdTextBox.Location = new Point(71, 68);
      IdTextBox.Name = "IdTextBox";
      IdTextBox.Size = new Size(100, 23);
      IdTextBox.TabIndex = 2;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(35, 114);
      label3.Name = "label3";
      label3.Size = new Size(140, 15);
      label3.TabIndex = 3;
      label3.Text = "Descripción del producto";
      // 
      // DescripcionProductoTextBox
      // 
      DescripcionProductoTextBox.Location = new Point(35, 143);
      DescripcionProductoTextBox.Name = "DescripcionProductoTextBox";
      DescripcionProductoTextBox.Size = new Size(387, 23);
      DescripcionProductoTextBox.TabIndex = 4;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(35, 187);
      label4.Name = "label4";
      label4.Size = new Size(81, 15);
      label4.TabIndex = 5;
      label4.Text = "Precio Interno";
      // 
      // PrecioInternoTextBox
      // 
      PrecioInternoTextBox.Location = new Point(35, 215);
      PrecioInternoTextBox.Name = "PrecioInternoTextBox";
      PrecioInternoTextBox.Size = new Size(100, 23);
      PrecioInternoTextBox.TabIndex = 6;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(219, 188);
      label5.Name = "label5";
      label5.Size = new Size(88, 15);
      label5.TabIndex = 7;
      label5.Text = "Precio de Venta";
      // 
      // PrecioVentaTextBox
      // 
      PrecioVentaTextBox.Location = new Point(219, 215);
      PrecioVentaTextBox.Name = "PrecioVentaTextBox";
      PrecioVentaTextBox.Size = new Size(100, 23);
      PrecioVentaTextBox.TabIndex = 8;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(35, 258);
      label6.Name = "label6";
      label6.Size = new Size(55, 15);
      label6.TabIndex = 9;
      label6.Text = "Cantidad";
      // 
      // CantidadTextBox
      // 
      CantidadTextBox.Location = new Point(34, 276);
      CantidadTextBox.Name = "CantidadTextBox";
      CantidadTextBox.Size = new Size(100, 23);
      CantidadTextBox.TabIndex = 10;
      // 
      // AgregarProductoButton
      // 
      AgregarProductoButton.Location = new Point(275, 341);
      AgregarProductoButton.Name = "AgregarProductoButton";
      AgregarProductoButton.Size = new Size(75, 23);
      AgregarProductoButton.TabIndex = 11;
      AgregarProductoButton.Text = "Agregar";
      AgregarProductoButton.UseVisualStyleBackColor = true;
      AgregarProductoButton.Click += AgregarProductoButton_Click;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(219, 258);
      label7.Name = "label7";
      label7.Size = new Size(58, 15);
      label7.TabIndex = 12;
      label7.Text = "Categoria";
      // 
      // CategoriaComboBox
      // 
      CategoriaComboBox.FormattingEnabled = true;
      CategoriaComboBox.Location = new Point(219, 276);
      CategoriaComboBox.Name = "CategoriaComboBox";
      CategoriaComboBox.Size = new Size(121, 23);
      CategoriaComboBox.TabIndex = 13;
      // 
      // FormsAgregarProducto
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(454, 395);
      Controls.Add(CategoriaComboBox);
      Controls.Add(label7);
      Controls.Add(AgregarProductoButton);
      Controls.Add(CantidadTextBox);
      Controls.Add(label6);
      Controls.Add(PrecioVentaTextBox);
      Controls.Add(label5);
      Controls.Add(PrecioInternoTextBox);
      Controls.Add(label4);
      Controls.Add(DescripcionProductoTextBox);
      Controls.Add(label3);
      Controls.Add(IdTextBox);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "FormsAgregarProducto";
      Text = "FormsAgregarProducto";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox IdTextBox;
    private Label label3;
    private TextBox DescripcionProductoTextBox;
    private Label label4;
    private TextBox PrecioInternoTextBox;
    private Label label5;
    private TextBox PrecioVentaTextBox;
    private Label label6;
    private TextBox CantidadTextBox;
    private Button AgregarProductoButton;
    private Label label7;
    private ComboBox CategoriaComboBox;
  }
}