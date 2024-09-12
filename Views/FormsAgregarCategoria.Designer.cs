namespace aplicacionInventario4.Views
{
  partial class FormsAgregarCategoria
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
      label3 = new Label();
      label1 = new Label();
      label4 = new Label();
      IdCategoriaTextBox = new TextBox();
      DescripcionCategoriaTextBox = new TextBox();
      AgregarButton = new Button();
      SuspendLayout();
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.BackColor = Color.LightCoral;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label3.Location = new Point(130, 26);
      label3.Name = "label3";
      label3.Size = new Size(134, 21);
      label3.TabIndex = 12;
      label3.Text = "Agregar categoria";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label1.Location = new Point(46, 68);
      label1.Name = "label1";
      label1.Size = new Size(20, 17);
      label1.TabIndex = 13;
      label1.Text = "ID";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label4.Location = new Point(51, 112);
      label4.Name = "label4";
      label4.Size = new Size(168, 17);
      label4.TabIndex = 15;
      label4.Text = "Descripcion de la categoria";
      // 
      // IdCategoriaTextBox
      // 
      IdCategoriaTextBox.Location = new Point(100, 67);
      IdCategoriaTextBox.Name = "IdCategoriaTextBox";
      IdCategoriaTextBox.Size = new Size(100, 23);
      IdCategoriaTextBox.TabIndex = 16;
      // 
      // DescripcionCategoriaTextBox
      // 
      DescripcionCategoriaTextBox.Location = new Point(51, 144);
      DescripcionCategoriaTextBox.Name = "DescripcionCategoriaTextBox";
      DescripcionCategoriaTextBox.Size = new Size(280, 23);
      DescripcionCategoriaTextBox.TabIndex = 17;
      // 
      // AgregarButton
      // 
      AgregarButton.Location = new Point(285, 225);
      AgregarButton.Name = "AgregarButton";
      AgregarButton.Size = new Size(75, 23);
      AgregarButton.TabIndex = 18;
      AgregarButton.Text = "Agregar";
      AgregarButton.UseVisualStyleBackColor = true;
      AgregarButton.Click += AgregarButton_Click;
      // 
      // FormsAgregarCategoria
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(434, 307);
      Controls.Add(AgregarButton);
      Controls.Add(DescripcionCategoriaTextBox);
      Controls.Add(IdCategoriaTextBox);
      Controls.Add(label4);
      Controls.Add(label1);
      Controls.Add(label3);
      Name = "FormsAgregarCategoria";
      Text = "FormsAgregarCategoria";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label3;
    private Label label1;
    private Label label4;
    private TextBox IdCategoriaTextBox;
    private TextBox DescripcionCategoriaTextBox;
    private Button AgregarButton;
  }
}