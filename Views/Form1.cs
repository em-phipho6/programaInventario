using aplicacionInventario4.Views;
using aplicacionInventario4.Models;

namespace aplicacionInventario4
{

  public partial class Form1 : Form
  {
    //a las propiedades del formulario se le cambiaron unas cosas, para que saliera en el centro de la pantalla
    //para que no se le pudiera cambiar el tamaño de la ventana con el mouse, que no pudieran maximizar la ventana
    //

    public List<Categoria> categorias;
    public List<Material> materiales;
    public Form1()
    {
      InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      categorias = new List<Categoria>();//instanciando el objeto de la lista de transmisiones
      materiales = new List<Material>();//instanciando el objeto de la lista de materiales
    }

    private void button1_Click(object sender, EventArgs e)
    {//este boton es el que te lleva al formulario de Inventario
      //FormsInventario tempFormsInventario = new FormsInventario(this);

      FormsInventario tempFormsInventario;
      tempFormsInventario = new FormsInventario(this);
      
      tempFormsInventario.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {//este boton es el que te lleva al formulario de Categorias
      //se puede instanciar en 2 partes, como se esta haciendo aqui, al declarar primero la variable y luego se instancia
      FormsCategorias tempFormCategorias = null;
      if (tempFormCategorias == null)
      {
        tempFormCategorias = new FormsCategorias(this);
        tempFormCategorias.Show();
        //hello
      }
      else
      {
        tempFormCategorias.BringToFront();
      }
    }

  }
}
