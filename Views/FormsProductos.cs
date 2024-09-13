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
    public FormsProductos(Form1 myBaseForm)
    {
      InitializeComponent();
      this.myBaseForm = myBaseForm;
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
  }
}
