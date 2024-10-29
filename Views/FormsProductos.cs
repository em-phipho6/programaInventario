using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aplicacionInventario4.Models;

namespace aplicacionInventario4
{
    public partial class FormsProductos : Form
    {
        public Form1 myBaseForm;
        public FormsInventario mySecondForm;
        public FormsProductos(FormsInventario mySecondForm)
        {
            InitializeComponent();
            this.myBaseForm = mySecondForm.myBaseForm;
            this.mySecondForm = mySecondForm;
            IdProductoComboBox.DataSource = this.myBaseForm.materiales;
            //buscas en la base de datos 


            //mostrar en los text box la informacion
            //textbox1.text="";
        }

        private void ComprarProductoButton_Click(object sender, EventArgs e)
        {
            FormsComprarProducto tmpFormsComprarProducto;
            tmpFormsComprarProducto = new FormsComprarProducto();

            tmpFormsComprarProducto.Show();
        }

        private void FormsProductos_Load(object sender, EventArgs e)
        {
            //aqui se tienen que cargar los datos del producto, usando las labels para mostrar los valores correspondientes

        }

        private void VenderProductoButton_Click(object sender, EventArgs e)
        {
            FormsVenderProducto tmpFormsVenderProducto;
            tmpFormsVenderProducto = new FormsVenderProducto();

            tmpFormsVenderProducto.Show();
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdProductoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Categoria tmpCategoria = (Categoria)CategoriaComboBox.SelectedItem;
            Material tmpMaterial = (Material)IdProductoComboBox.SelectedItem;

            //temp = new Material(int.Parse(IdTextBox.Text), DescripcionProductoTextBox.Text, double.Parse(PrecioInternoTextBox.Text), double.Parse(PrecioVentaTextBox.Text), int.Parse(CantidadTextBox.Text), tmpCategoria)
            //textbox1.text="";

            //string selected = this.ComboBox.GetItemText(this.ComboBox.SelectedItem);

            //dependiendo del id son los datos que se les hará display
            //así como esta ahora, no muestra como tal el texto que se busca, esa apuntando y buscando correctemente, pero no se muestra bien
            this.IdProductoLabel.Text = Convert.ToString(tmpMaterial);

            this.DescripcionProductoLabel.Text = "hello";//como muestro los datos dependiendo del id del producto?;

            //for each loop para recorrer las celdas y asignar el texto?
            //foreach (DataGridViewRow row in ProductosDataGridView.Rows)
            foreach(DataGridViewCell cells in this.mySecondForm.ProductosDataGridView)
            {

            }


        }
    }
}
