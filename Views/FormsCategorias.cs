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

namespace aplicacionInventario4.Views
{
  public partial class FormsCategorias : Form
  {
    //se puso publico porque si no, no podremos permitir la referncia o conexion con el siguiente formulario 
    public Form1 myBaseForm;
    //de igual manera no se necesitan los 2 formularios, se necesita solo el principal para poder llamar o modificar la lista de categorias
    public FormsCategorias(Form1 myBaseForm)
    {
      InitializeComponent();
      this.myBaseForm = myBaseForm;
    }

    public void refrescarCategoriasDataGridView()
    {
      //este metodo es para refrescar el data grid view del forms de categorias, para mostrar los cambios que se han hecho
      //por ejemplo: agregar una categoria

      var source = new BindingSource();
      source.DataSource = myBaseForm.categorias;

      this.CategoriasDataGridView.DataSource = source;
      this.CategoriasDataGridView.Update();
      this.CategoriasDataGridView.Refresh();
    }

    private void AgregarCategoriaButton_Click(object sender, EventArgs e)
    {//la manera en que se nombra la variable, no es una accion, es como un nombre
      //la variable se dice que es de tipo FormsAgregarCategoria y tiene como nombre temFormAgregarCategoria
      FormsAgregarCategoria tempFormAgregarCategoria = new FormsAgregarCategoria(this);
      //tempFormAgregarCategoria = new FormsAgregarCategoria(this);
      tempFormAgregarCategoria.Show();
    }

    private void FormsCategorias_Deactivate(object sender, EventArgs e)
    {
      //este evento nos ayuda a esconder el formularo mientras no lo estamos usando, pero ya no aparece otra vez
      //pero al menos aqui por eso es el sig evento, para mostrar la información que ya se tiene guardada
      this.Hide();
    }

    private void CategoriasDataGridView_MouseEnter(object sender, EventArgs e)
    {
      //este evento es para que cuando el mouse entre al Data Grid View, se refresque y muestre los cambios
      this.refrescarCategoriasDataGridView();
    }

    private void atrasButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
