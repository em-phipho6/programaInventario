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
  public partial class FormsVenderProducto : Form
  {
    public FormsVenderProducto()
    {
      InitializeComponent();
    }

    private void FormsVenderProducto_Load(object sender, EventArgs e)
    {
      //aqui tienen que cargar los datos del producto que se eligió

    }

    private void VenderYaProductoButton_Click(object sender, EventArgs e)
    {


      //al final se tiene que cerrar el formulario
      this.Close();
    }

    public void venderProducto()
    {
      int cantidadVender;

      //necesito tomar el valor que se registra en la pregunta de cuanto va a vender, volver a convertilo en int
      //hacer la resta de los valores y que se refleje en el forms principal o en las listas

      /*
       * int operacion;
       * 
       * cantidadVender = int.Parse(CantidadVenderTextBox.Text)? asi se convertirá?
       * ya se habrá convertido desde que se registra el dato?
       * 
       * operacion = cantidad - cantidadVender;
       * 
       * operacion = cantidad;
       * asi se podran guardar los cambios?
       * se tendría que probar con un break si si se guardan los cambios
       * */



      //cantidadrestada = cantidad

    }
  }
}
