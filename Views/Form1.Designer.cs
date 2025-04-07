namespace aplicacionInventario4
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            IniciarSesionButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(347, 147);
            label1.Name = "label1";
            label1.Size = new Size(245, 61);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Subheading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(257, 237);
            label3.Name = "label3";
            label3.Size = new Size(464, 43);
            label3.TabIndex = 2;
            label3.Text = "Esta es la aplicación de inventario";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(347, 401);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Inventario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(235, 312);
            label2.Name = "label2";
            label2.Size = new Size(527, 29);
            label2.TabIndex = 4;
            label2.Text = "Por favor, de clic en el botón para ver el inventario";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(535, 401);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 5;
            button2.Text = "Categorias";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // IniciarSesionButton
            // 
            IniciarSesionButton.BackColor = SystemColors.ActiveCaption;
            IniciarSesionButton.ForeColor = SystemColors.ActiveCaptionText;
            IniciarSesionButton.Location = new Point(440, 490);
            IniciarSesionButton.Name = "IniciarSesionButton";
            IniciarSesionButton.Size = new Size(94, 29);
            IniciarSesionButton.TabIndex = 6;
            IniciarSesionButton.Text = "Iniciar sesion";
            IniciarSesionButton.UseVisualStyleBackColor = false;
            IniciarSesionButton.Click += IniciarSesionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(IniciarSesionButton);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.DeepSkyBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    private Label label3;
    private Button button1;
    private Label label2;
    private Button button2;
        private Button IniciarSesionButton;
    }
}
