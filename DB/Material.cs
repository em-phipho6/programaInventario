using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string DescripcionMaterial { get; set; }
        public double PrecioInterno { get; set; }
        public double PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int IdCategoria { get; set; }
        
        [ForeignKey("IdCategoria")]

        public virtual Categoria Categoria { get; set; }


    }

}
