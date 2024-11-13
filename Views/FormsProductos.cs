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
        public FormsProductos(FormsInventario mySecondForm/*, int numero*/)
        {
            InitializeComponent();
            this.myBaseForm = mySecondForm.myBaseForm;
            this.mySecondForm = mySecondForm;
            IdProductoComboBox.DataSource = mySecondForm.myBaseForm.materiales;

            //numero - posicion del objeto en la lista, con este se podría hacer la busqueda de la info del objeto
            //usando el SelectedIndex y la muestra de código que nos ayudó a hacer Hernando
            
            //buscas en la base de datos 

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
            Material tmpMaterial = (Material)IdProductoComboBox.SelectedItem;
            this.IdProductoComboBox.Text = Convert.ToString(tmpMaterial.DescripcionMaterial);

            //los textos del forms para que no se vea lo que es 
            IdProductoLabel.Text = "Identificación del producto";
            DescripcionProductoLabel.Text = "Descripcion del producto";
            PrecioInternoProductoLabel.Text = "Precio interno del producto";
            PrecioVentaProductoLabel.Text = "Precio venta del producto";
            CantidadLabel.Text = "Cantidad en stock del producto";
            CategoriaProductoLabel.Text = "Categoria del producto";

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
