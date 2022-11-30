using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    internal class ProductoVendido
    {
       public long Id { get; set; }
       public long IdProducto { get; set; }
       public double Stock { get; set; }
       public long IdVenta { get; set; }
       
       public ProductoVendido(long Id, long IdProducto, double Stock, long IdVenta)
        {
            this.Id = Id;
            this.IdProducto = IdProducto;
            this.Stock = Stock;
            this.IdVenta = IdVenta;

        }
        public ProductoVendido()
        {

        }
    }
}
