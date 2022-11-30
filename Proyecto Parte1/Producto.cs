using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    internal class Producto
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public double Stock { get; set; }
        public long IdUsuario { get; set; }

        public Producto(long Id, string Descripcion, double Costo, double PrecioVenta, double Stock, long IdUsuario)
        {
            this.Id = Id;
            this.Descripcion = Descripcion;
            this.Costo = Costo;
            this.PrecioVenta = PrecioVenta;
            this.Stock = Stock;
            this.IdUsuario = IdUsuario;

        }
        public Producto() { }


    }
}
