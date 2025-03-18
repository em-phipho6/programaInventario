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
    public partial class FormsEliminarProducto : Form
    {
        public FormsEliminarProducto()
        {
            InitializeComponent();
        }

        private void FormsEliminarProducto_Load(object sender, EventArgs e)
        {

        }

        public void eliminarProducto()
        {

        }

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            FormsInventario tempFormsInventario = new FormsInventario(this);
            tempFormsInventario.Show();
            this.Hide();
        }
    }
}
