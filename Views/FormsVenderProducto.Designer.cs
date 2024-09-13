namespace aplicacionInventario4
{
  partial class FormsVenderProducto
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
      CantidadProductoVenderTextBox = new TextBox();
      label6 = new Label();
      label4 = new Label();
      label2 = new Label();
      label1 = new Label();
      VenderYaProductoButton = new Button();
      label3 = new Label();
      IdProductoLabel = new Label();
      DescripcionProductoLabel = new Label();
      SuspendLayout();
      // 
      // CantidadProductoVenderTextBox
      // 
      CantidadProductoVenderTextBox.Location = new Point(59, 230);
      CantidadProductoVenderTextBox.Name = "CantidadProductoVenderTextBox";
      CantidadProductoVenderTextBox.Size = new Size(100, 23);
      CantidadProductoVenderTextBox.TabIndex = 13;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.ForeColor = Color.DarkCyan;
      label6.Location = new Point(38, 199);
      label6.Name = "label6";
      label6.Size = new Size(217, 15);
      label6.TabIndex = 12;
      label6.Text = "¿Cuanta cantidad de producto venderá?";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(38, 123);
      label4.Name = "label4";
      label4.Size = new Size(143, 15);
      label4.TabIndex = 11;
      label4.Text = "Descripcion del producto:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(38, 87);
      label2.Name = "label2";
      label2.Size = new Size(21, 15);
      label2.TabIndex = 10;
      label2.Text = "ID:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.ForeColor = Color.DarkCyan;
      label1.Location = new Point(24, 52);
      label1.Name = "label1";
      label1.Size = new Size(195, 15);
      label1.TabIndex = 9;
      label1.Text = "Usted va a vender de este producto:";
      // 
      // VenderYaProductoButton
      // 
      VenderYaProductoButton.Location = new Point(294, 322);
      VenderYaProductoButton.Name = "VenderYaProductoButton";
      VenderYaProductoButton.Size = new Size(75, 23);
      VenderYaProductoButton.TabIndex = 17;
      VenderYaProductoButton.Text = "Vender";
      VenderYaProductoButton.UseVisualStyleBackColor = true;
      VenderYaProductoButton.Click += VenderYaProductoButton_Click;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.BackColor = Color.LightCoral;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label3.Location = new Point(150, 19);
      label3.Name = "label3";
      label3.Size = new Size(126, 21);
      label3.TabIndex = 18;
      label3.Text = "Vender producto";
      // 
      // IdProductoLabel
      // 
      IdProductoLabel.AutoSize = true;
      IdProductoLabel.Location = new Point(70, 85);
      IdProductoLabel.Name = "IdProductoLabel";
      IdProductoLabel.Size = new Size(38, 15);
      IdProductoLabel.TabIndex = 19;
      IdProductoLabel.Text = "label5";
      // 
      // DescripcionProductoLabel
      // 
      DescripcionProductoLabel.AutoSize = true;
      DescripcionProductoLabel.Location = new Point(50, 150);
      DescripcionProductoLabel.Name = "DescripcionProductoLabel";
      DescripcionProductoLabel.Size = new Size(38, 15);
      DescripcionProductoLabel.TabIndex = 20;
      DescripcionProductoLabel.Text = "label5";
      // 
      // FormsVenderProducto
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(452, 398);
      Controls.Add(DescripcionProductoLabel);
      Controls.Add(IdProductoLabel);
      Controls.Add(label3);
      Controls.Add(VenderYaProductoButton);
      Controls.Add(CantidadProductoVenderTextBox);
      Controls.Add(label6);
      Controls.Add(label4);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "FormsVenderProducto";
      Text = "FormsVenderProducto";
      Load += FormsVenderProducto_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private TextBox CantidadProductoVenderTextBox;
    private Label label6;
    private Label label4;
    private Label label2;
    private Label label1;
    private Button VenderYaProductoButton;
    private Label label3;
    private Label IdProductoLabel;
    private Label DescripcionProductoLabel;
  }
}