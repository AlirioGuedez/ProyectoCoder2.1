using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parte1
{
    public class Venta
    {
        public long Id { get; set; }
        public string Comentarios { get; set; }

        
        public Venta(long Id, string Comentarios)
        {
            this.Id = Id;
            this.Comentarios = Comentarios;

        }

        public Venta()
        {

        }
    }
}
