using aplicacionInventario4.Views;
using aplicacionInventario4.Models;

namespace aplicacionInventario4
{

  public partial class Form1 : Form
  {
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
    { 
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
