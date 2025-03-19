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
            /*
            //aqui se tienen que cargar los datos del producto, usando las labels para mostrar los valores correspondientes
            Material tmpMaterial = (Material)IdProductoComboBox.SelectedItem;
            this.IdProductoComboBox.Text = Convert.ToString(tmpMaterial.DescripcionMaterial);

            ////prueba de como usar el selected index
            IdProductoLabel.Text = Convert.ToString(" el index del producto (objeto) es: " + mySecondForm.indexFila);

            //look through the list
            for (int i = 0; i <= 5; i++)
            {
                int ayo = 0;
            }

            DescripcionProductoLabel.Text = "Descripcion del producto";
            PrecioInternoProductoLabel.Text = "Precio interno del producto";
            PrecioVentaProductoLabel.Text = "Precio venta del producto";
            CantidadLabel.Text = "Cantidad en stock del producto";
            CategoriaProductoLabel.Text = "Categoria del producto*/
        }

        public void eliminarProducto()
        {

        }

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            FormsInventario tempFormsInventario = new FormsInventario(this.myBaseForm);
            tempFormsInventario.Show();
            this.Hide();
        }

        private void IdProductoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            Material tmpMaterial = (Material)IdProductoComboBox.SelectedItem;

            this.IdProductoLabel.Text = Convert.ToString(tmpMaterial.DescripcionMaterial);

            this.DescripcionProductoLabel.Text = tmpMaterial.DescripcionMaterial;


            this.PrecioInternoProductoLabel.Text = Convert.ToString(tmpMaterial.PrecioInterno);

            this.PrecioVentaProductoLabel.Text = Convert.ToString(tmpMaterial.PrecioVenta);

            this.CantidadLabel.Text = Convert.ToString(tmpMaterial.Cantidad);

            this.CategoriaProductoLabel.Text = Convert.ToString(tmpMaterial.DescripcionCategoria);*/
        }
    }
}
