using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionInventario4.Models
{
  public class Material
  {
    //declaracion de atributos
    private int idMaterial;
    private string descripcionMaterial;
    private double precioInterno;
    private double precioVenta;
    private int cantidad;
    //private int cantidadMinima;
    private Categoria descripcionCategoria;

    //metodo constructor
    public override string ToString()
    {
        return descripcionMaterial;
    }


    public Material(int idMaterial, string descripcionMaterial, double precioInterno, double precioVenta, int cantidad, /*int cantidadMinima,*/ Categoria descripcionCategoria)
    {
      this.idMaterial = idMaterial;
      this.descripcionMaterial = descripcionMaterial;
      this.precioInterno = precioInterno;
      this.precioVenta = precioVenta;
      this.cantidad = cantidad;
      //this.cantidadMinima = cantidadMinima;
      this.descripcionCategoria = descripcionCategoria;
    }

    //metodos accesores 
    public int IdMaterial { get => idMaterial; set => idMaterial = value; }
    public string DescripcionMaterial { get => descripcionMaterial; set => descripcionMaterial = value; }
    public double PrecioInterno { get => precioInterno; set => precioInterno = value; }
    public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
    //public int CantidadMinima { get => cantidadMinima; set => cantidadMinima = value; }
    public Categoria DescripcionCategoria { get => descripcionCategoria; set => descripcionCategoria = value; }

  }
}
