namespace aplicacionInventario4.Views
{
  partial class FormsCategorias
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
      AgregarCategoriaButton = new Button();
      CategoriasDataGridView = new DataGridView();
      AtrasButton = new Button();
      ((System.ComponentModel.ISupportInitialize)CategoriasDataGridView).BeginInit();
      SuspendLayout();
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.BackColor = Color.LightCoral;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label3.Location = new Point(235, 26);
      label3.Name = "label3";
      label3.Size = new Size(84, 21);
      label3.TabIndex = 11;
      label3.Text = "Categorias";
      // 
      // AgregarCategoriaButton
      // 
      AgregarCategoriaButton.Location = new Point(448, 295);
      AgregarCategoriaButton.Name = "AgregarCategoriaButton";
      AgregarCategoriaButton.Size = new Size(126, 23);
      AgregarCategoriaButton.TabIndex = 12;
      AgregarCategoriaButton.Text = "Agregar categoria";
      AgregarCategoriaButton.UseVisualStyleBackColor = true;
      AgregarCategoriaButton.Click += AgregarCategoriaButton_Click;
      // 
      // CategoriasDataGridView
      // 
      CategoriasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      CategoriasDataGridView.Location = new Point(29, 77);
      CategoriasDataGridView.Name = "CategoriasDataGridView";
      CategoriasDataGridView.Size = new Size(545, 191);
      CategoriasDataGridView.TabIndex = 13;
      CategoriasDataGridView.MouseEnter += CategoriasDataGridView_MouseEnter;
      // 
      // AtrasButton
      // 
      AtrasButton.Location = new Point(58, 306);
      AtrasButton.Name = "AtrasButton";
      AtrasButton.Size = new Size(75, 23);
      AtrasButton.TabIndex = 14;
      AtrasButton.Text = "Atrás";
      AtrasButton.UseVisualStyleBackColor = true;
      AtrasButton.Click += atrasButton_Click;
      // 
      // FormsCategorias
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(611, 360);
      Controls.Add(AtrasButton);
      Controls.Add(CategoriasDataGridView);
      Controls.Add(AgregarCategoriaButton);
      Controls.Add(label3);
      Name = "FormsCategorias";
      Text = "FormsCategorias";
      Deactivate += FormsCategorias_Deactivate;
      ((System.ComponentModel.ISupportInitialize)CategoriasDataGridView).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label3;
    private Button AgregarCategoriaButton;
    private DataGridView CategoriasDataGridView;
    private Button AtrasButton;
  }
}