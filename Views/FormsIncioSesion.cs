using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionInventario4.Views
{
    public partial class FormsInicioSesion : Form
    {
        public Form1 myBaseForm;
        public FormsInicioSesion(Form1 myBaseForm)
        {
            InitializeComponent();

            this.myBaseForm = myBaseForm;
        }

        private void IniciarSesionButton_Click(object sender, EventArgs e)
        {
            verificarInicioSesion();
        }

        public void verificarInicioSesion()
        {

            if (this.CorreoTextBox.Text == "al03008611" && this.PasswordTextBox.Text == "holacomoest4")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                this.CorreoTextBox.Clear();
                this.PasswordTextBox.Clear();
            }
        }

        public void codificacionDatos()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(this.PasswordTextBox.Text);
            string base64String = Convert.ToBase64String(bytes);
            MessageBox.Show(base64String);
        }
    }
}
