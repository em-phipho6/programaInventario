namespace aplicacionInventario4.Views
{
    partial class FormsInicioSesion
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
            CorreoLabel = new Label();
            CorreoTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            label1 = new Label();
            TituloLabel = new Label();
            IniciarSesionButton = new Button();
            SuspendLayout();
            // 
            // CorreoLabel
            // 
            CorreoLabel.AutoSize = true;
            CorreoLabel.Location = new Point(37, 92);
            CorreoLabel.Name = "CorreoLabel";
            CorreoLabel.Size = new Size(132, 20);
            CorreoLabel.TabIndex = 0;
            CorreoLabel.Text = "Correo electronico";
            // 
            // CorreoTextBox
            // 
            CorreoTextBox.Location = new Point(37, 126);
            CorreoTextBox.Name = "CorreoTextBox";
            CorreoTextBox.Size = new Size(310, 27);
            CorreoTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(37, 232);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(310, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(37, 196);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(83, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(595, 443);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // TituloLabel
            // 
            TituloLabel.AutoSize = true;
            TituloLabel.BackColor = Color.LightCoral;
            TituloLabel.Location = new Point(138, 39);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(90, 20);
            TituloLabel.TabIndex = 5;
            TituloLabel.Text = "Inicar sesion";
            // 
            // IniciarSesionButton
            // 
            IniciarSesionButton.Location = new Point(125, 308);
            IniciarSesionButton.Name = "IniciarSesionButton";
            IniciarSesionButton.Size = new Size(112, 29);
            IniciarSesionButton.TabIndex = 6;
            IniciarSesionButton.Text = "Iniciar sesion";
            IniciarSesionButton.UseVisualStyleBackColor = true;
            IniciarSesionButton.Click += IniciarSesionButton_Click;
            // 
            // FormsInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 399);
            Controls.Add(IniciarSesionButton);
            Controls.Add(TituloLabel);
            Controls.Add(label1);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(CorreoTextBox);
            Controls.Add(CorreoLabel);
            Name = "FormsInicioSesion";
            Text = "Inicio sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CorreoLabel;
        public TextBox CorreoTextBox;
        public TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label label1;
        private Label TituloLabel;
        private Button IniciarSesionButton;
    }
}