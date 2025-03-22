using aplicacionInventario4.Models;
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
        public Form1 myBaseForm;
        public FormsInventario mySecondForm;

        public FormsEliminarProducto(FormsInventario mySecondForm)
        {
            InitializeComponent();
            this.myBaseForm = mySecondForm.myBaseForm;
            this.mySecondForm = mySecondForm;
            IdProductoComboBox.DataSource = mySecondForm.myBaseForm.materiales;
        }

        private void FormsEliminarProducto_Load(object sender, EventArgs e)
        {

            EliminaProductoLabel.Text = "Descripción de categoria";
        }

        public void eliminarProducto()
        {
            //values=null;
            Material tmpMaterial = (Material)IdProductoComboBox.SelectedItem;

            this.myBaseForm.materiales.Remove(tmpMaterial);
        }

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            eliminarProducto();

            FormsInventario tempFormsInventario = new FormsInventario(this.myBaseForm);
            tempFormsInventario.Show();
            this.Hide();
        }

        private void IdProductoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            Material tmpMaterial = (Material)IdProductoComboBox.SelectedItem;

            this.IdProductoLabel.Text = Convert.ToString(tmpMaterial.DescripcionMaterial);

            this.DescripcionProductoLabel.Text = tmpMaterial.DescripcionMaterial;

            this.PrecioInternoProductoLabel.Text = Convert.ToString(tmpMaterial.PrecioInterno);

            this.PrecioVentaProductoLabel.Text = Convert.ToString(tmpMaterial.PrecioVenta);

            this.CantidadLabel.Text = Convert.ToString(tmpMaterial.Cantidad);

            this.CategoriaProductoLabel.Text = Convert.ToString(tmpMaterial.DescripcionCategoria);
        }
    }
}
