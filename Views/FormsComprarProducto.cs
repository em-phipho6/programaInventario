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
  public partial class FormsComprarProducto : Form
  {
    public Form1 myBaseForm;
    public FormsInventario mySecondForm;
    public FormsComprarProducto(FormsInventario mySecondForm)
    {
      InitializeComponent();
      this.mySecondForm = mySecondForm;
      this.myBaseForm = mySecondForm.myBaseForm;
      
    }

    private void FormsComprarProducto_Load(object sender, EventArgs e)
    {
        //aqui se tienen que cargar los datos de la lista para que salgan acorde al producto seleccionado
        IdProductoLabel.Text = "";
        DescripcionProductoLabel.Text = "Aqui esta la descripcion del producto";

        //int selectedIndex =         

    }

    private void ComprarYaProductoButton_Click(object sender, EventArgs e)
    {
      //antes se tienen que guardar los cambios



      //al final, se cierra este formulario
      this.Close();
    }

    public void operacionComprarPrdocuto()
    {
      int cantidadVender, operacion, cantidadIntern;

      cantidadVender = int.Parse(CantidadVenderProductoTextBox.Text);

      //como llamar el valor de la cantidad del producto?
      //myBaseForm.materiales.cantidad = cantidadIntern;

    }

  }
}
