namespace aplicacionInventario4
{
  partial class FormsComprarProducto
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
      label4 = new Label();
      label6 = new Label();
      CantidadVenderProductoTextBox = new TextBox();
      ComprarYaProductoButton = new Button();
      label3 = new Label();
      DescripcionProductoLabel = new Label();
      IdProductoLabel = new Label();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.ForeColor = Color.DarkCyan;
      label1.Location = new Point(15, 50);
      label1.Name = "label1";
      label1.Size = new Size(204, 15);
      label1.TabIndex = 0;
      label1.Text = "Usted va a comprar de este producto:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(29, 85);
      label2.Name = "label2";
      label2.Size = new Size(21, 15);
      label2.TabIndex = 1;
      label2.Text = "ID:";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(29, 121);
      label4.Name = "label4";
      label4.Size = new Size(143, 15);
      label4.TabIndex = 3;
      label4.Text = "Descripcion del producto:";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.ForeColor = Color.DarkCyan;
      label6.Location = new Point(29, 197);
      label6.Name = "label6";
      label6.Size = new Size(256, 15);
      label6.TabIndex = 5;
      label6.Text = "¿Cuanta cantidad de producto quiere comprar?";
      // 
      // CantidadVenderProductoTextBox
      // 
      CantidadVenderProductoTextBox.Location = new Point(50, 228);
      CantidadVenderProductoTextBox.Name = "CantidadVenderProductoTextBox";
      CantidadVenderProductoTextBox.Size = new Size(100, 23);
      CantidadVenderProductoTextBox.TabIndex = 6;
      // 
      // ComprarYaProductoButton
      // 
      ComprarYaProductoButton.Location = new Point(257, 305);
      ComprarYaProductoButton.Name = "ComprarYaProductoButton";
      ComprarYaProductoButton.Size = new Size(75, 23);
      ComprarYaProductoButton.TabIndex = 9;
      ComprarYaProductoButton.Text = "Comprar";
      ComprarYaProductoButton.UseVisualStyleBackColor = true;
      ComprarYaProductoButton.Click += ComprarYaProductoButton_Click;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.BackColor = Color.LightCoral;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label3.Location = new Point(146, 9);
      label3.Name = "label3";
      label3.Size = new Size(139, 21);
      label3.TabIndex = 10;
      label3.Text = "Comprar producto";
      // 
      // DescripcionProductoLabel
      // 
      DescripcionProductoLabel.AutoSize = true;
      DescripcionProductoLabel.Location = new Point(51, 146);
      DescripcionProductoLabel.Name = "DescripcionProductoLabel";
      DescripcionProductoLabel.Size = new Size(38, 15);
      DescripcionProductoLabel.TabIndex = 11;
      DescripcionProductoLabel.Text = "label5";
      // 
      // IdProductoLabel
      // 
      IdProductoLabel.AutoSize = true;
      IdProductoLabel.Location = new Point(56, 85);
      IdProductoLabel.Name = "IdProductoLabel";
      IdProductoLabel.Size = new Size(38, 15);
      IdProductoLabel.TabIndex = 12;
      IdProductoLabel.Text = "label5";
      // 
      // FormsComprarProducto
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(442, 387);
      Controls.Add(IdProductoLabel);
      Controls.Add(DescripcionProductoLabel);
      Controls.Add(label3);
      Controls.Add(ComprarYaProductoButton);
      Controls.Add(CantidadVenderProductoTextBox);
      Controls.Add(label6);
      Controls.Add(label4);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "FormsComprarProducto";
      Text = "FormsComprarProducto";
      Load += FormsComprarProducto_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label4;
    private Label label6;
    private TextBox CantidadVenderProductoTextBox;
    private Button ComprarYaProductoButton;
    private Label label3;
    private Label DescripcionProductoLabel;
    private Label IdProductoLabel;
  }
}