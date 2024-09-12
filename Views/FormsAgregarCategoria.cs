using aplicacionInventario4.Models;
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
  public partial class FormsAgregarCategoria : Form
  {
    //estos son los parametros de esta clase
    private Form1 myBaseForm;
    private FormsCategorias mySecondForm;
    
    //este es el metodo constructor
    public FormsAgregarCategoria(FormsCategorias mySecondForm)
    {
      InitializeComponent();
      this.myBaseForm = mySecondForm.myBaseForm;
      this.mySecondForm = mySecondForm;
    }
    /*se hizo un ejercicio donde se sobrecargo el constructor para llamar a las variables
    en el sentido de que se tenian 2 constructores y diferentes formas de llamar a los formularios que queremos
    pero dado que no es muy necesario ya que necesitamos la lista del primer formulario y un metodo del segundo formulario
    llamamos a los dos formularios de la manera correcta
    pero se hizo el ejercicio para probar
    iba algo asi
     
    private Form1 myBaseForm

    public FormsAgregarCategoria(FormsCategorias mySecondForm)
    {
      this.mySecondForm = mySecondForm.myBaseForm;
    }
    public FormsAgregarCategoria(Form1 myBaseForm)
    {
      this.myBaseForm = myBaseForm;
    }
     
     */
    //este es el evento que nos ayuda a ver el siguiente formulario y hacer uso de el
    private void AgregarButton_Click(object sender, EventArgs e)
    {
      Categoria tmpCategoria = new Categoria(int.Parse(IdCategoriaTextBox.Text), DescripcionCategoriaTextBox.Text);

      this.myBaseForm.categorias.Add(tmpCategoria);

      this.mySecondForm.refrescarCategoriasDataGridView();

      this.Close();
    }
  }
}
