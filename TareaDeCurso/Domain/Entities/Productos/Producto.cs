using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Productos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre {get; set;}
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAdquisicion { get; set; }

    }
}
