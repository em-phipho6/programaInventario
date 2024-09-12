using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionInventario4
{
  public partial class FormsComprarProducto : Form
  {
    public Form1 myBaseForm;
    public FormsProductos mySecondForm;
    public FormsComprarProducto()
    {
      InitializeComponent();
    }

    private void FormsComprarProducto_Load(object sender, EventArgs e)
    {

    }

    private void ComprarYaProductoButton_Click(object sender, EventArgs e)
    {
      //antes se tienen que guardar los cambios



      //al final, se cierra este formulario
      this.Close();
    }

    public void venderProducto()
    {
      int cantidadVender, operacion, cantidadIntern;

      cantidadVender = int.Parse(CantidadVenderProductoTextBox.Text);

      //como llamar el valor de la cantidad del producto?
      myBaseForm.materiales.cantidad = cantidadIntern;

    }

  }
}
