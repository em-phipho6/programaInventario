using aplicacionInventario4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionInventario4
{
  public partial class FormsAgregarProducto : Form
  {
    public Form1 myBaseForm;
    public FormsInventario mySecondForm;
    public FormsAgregarProducto(FormsInventario mySecondForm)
    {
      InitializeComponent();
      this.myBaseForm = mySecondForm.myBaseForm;
      CategoriaComboBox.DataSource = this.myBaseForm.categorias;
      this.mySecondForm = mySecondForm;
    }

    private void AgregarProductoButton_Click(object sender, EventArgs e)
    {
      Categoria tmpCategoria = (Categoria)CategoriaComboBox.SelectedItem;

      Material temp;

      temp = new Material(int.Parse(IdTextBox.Text), DescripcionProductoTextBox.Text, double.Parse(PrecioInternoTextBox.Text), double.Parse(PrecioVentaTextBox.Text), int.Parse(CantidadTextBox.Text), tmpCategoria);

      this.myBaseForm.materiales.Add(temp);

      this.mySecondForm.refrescarProductosDataGridView();

      this.Close();

    }
  }
}
