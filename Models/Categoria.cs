using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionInventario4.Models
{
  public class Categoria
  {
    //declaracion de atributos
    private int idCategoria;
    private string descripcionCategoria;

    //se hace este override ToString para que la descripion de categorias salga bien (en el sentido de que se pueda leer y no salga como en las fotos)
    public override string ToString()
    {
      return descripcionCategoria.ToString();
    }

    //metodo constructor
    public Categoria(int idCategoria, string descripcionCategoria)
    {
      this.idCategoria = idCategoria;
      this.descripcionCategoria = descripcionCategoria;
    }
    
    //metodos accesores
    public int IdCategoria { get => idCategoria; set => idCategoria = value; }
    public string DescripcionCategoria { get => descripcionCategoria; set=> descripcionCategoria = value; }
  }
}
