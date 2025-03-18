namespace aplicacionInventario4.Views
{
    partial class FormsEliminarCategoria
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
            EliminarCategoriaIdLabel = new Label();
            EliminarCategoriaIdComboBox = new ComboBox();
            EliminarCateogoriaDescripcionLabel = new Label();
            EliminarCateogoriaDescripcionChangableLabel = new Label();
            ConfirmarEliminarCategoriaButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // EliminarCategoriaIdLabel
            // 
            EliminarCategoriaIdLabel.AutoSize = true;
            EliminarCategoriaIdLabel.BackColor = Color.Khaki;
            EliminarCategoriaIdLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            EliminarCategoriaIdLabel.Location = new Point(21, 78);
            EliminarCategoriaIdLabel.Name = "EliminarCategoriaIdLabel";
            EliminarCategoriaIdLabel.Size = new Size(69, 15);
            EliminarCategoriaIdLabel.TabIndex = 0;
            EliminarCategoriaIdLabel.Text = "Id categoria";
            // 
            // EliminarCategoriaIdComboBox
            // 
            EliminarCategoriaIdComboBox.FormattingEnabled = true;
            EliminarCategoriaIdComboBox.Location = new Point(43, 109);
            EliminarCategoriaIdComboBox.Name = "EliminarCategoriaIdComboBox";
            EliminarCategoriaIdComboBox.Size = new Size(121, 23);
            EliminarCategoriaIdComboBox.TabIndex = 1;
            // 
            // EliminarCateogoriaDescripcionLabel
            // 
            EliminarCateogoriaDescripcionLabel.AutoSize = true;
            EliminarCateogoriaDescripcionLabel.BackColor = Color.Khaki;
            EliminarCateogoriaDescripcionLabel.Location = new Point(26, 159);
            EliminarCateogoriaDescripcionLabel.Name = "EliminarCateogoriaDescripcionLabel";
            EliminarCateogoriaDescripcionLabel.Size = new Size(121, 15);
            EliminarCateogoriaDescripcionLabel.TabIndex = 2;
            EliminarCateogoriaDescripcionLabel.Text = "Descripcion categoria";
            // 
            // EliminarCateogoriaDescripcionChangableLabel
            // 
            EliminarCateogoriaDescripcionChangableLabel.AutoSize = true;
            EliminarCateogoriaDescripcionChangableLabel.Location = new Point(52, 191);
            EliminarCateogoriaDescripcionChangableLabel.Name = "EliminarCateogoriaDescripcionChangableLabel";
            EliminarCateogoriaDescripcionChangableLabel.Size = new Size(255, 15);
            EliminarCateogoriaDescripcionChangableLabel.TabIndex = 3;
            EliminarCateogoriaDescripcionChangableLabel.Text = "EliminarCateogoriaDescripcionChangableLabel";
            EliminarCateogoriaDescripcionChangableLabel.UseMnemonic = false;
            // 
            // ConfirmarEliminarCategoriaButton
            // 
            ConfirmarEliminarCategoriaButton.Location = new Point(149, 251);
            ConfirmarEliminarCategoriaButton.Name = "ConfirmarEliminarCategoriaButton";
            ConfirmarEliminarCategoriaButton.Size = new Size(75, 23);
            ConfirmarEliminarCategoriaButton.TabIndex = 4;
            ConfirmarEliminarCategoriaButton.Text = "Eliminar";
            ConfirmarEliminarCategoriaButton.UseVisualStyleBackColor = true;
            ConfirmarEliminarCategoriaButton.Click += ConfirmarEliminarCategoriaButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(129, 30);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 5;
            label1.Text = "A";
            // 
            // FormsEliminarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 340);
            Controls.Add(label1);
            Controls.Add(ConfirmarEliminarCategoriaButton);
            Controls.Add(EliminarCateogoriaDescripcionChangableLabel);
            Controls.Add(EliminarCateogoriaDescripcionLabel);
            Controls.Add(EliminarCategoriaIdComboBox);
            Controls.Add(EliminarCategoriaIdLabel);
            Name = "FormsEliminarCategoria";
            Text = "Eliminar Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EliminarCategoriaIdLabel;
        private ComboBox EliminarCategoriaIdComboBox;
        private Label EliminarCateogoriaDescripcionLabel;
        private Label EliminarCateogoriaDescripcionChangableLabel;
        private Button ConfirmarEliminarCategoriaButton;
        private Label label1;
    }
}