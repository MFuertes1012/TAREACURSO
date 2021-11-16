using Domain.Entities.Productos;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class ProductRepository : BaseRepository<Producto>, IProductRepository
    {
        public Producto GetProductoById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El Id: {id} no es valido.");
            }

            if (data == null)
            {
                throw new Exception("Empty data.");
            }

            Producto product = null;
            foreach (Producto i in data)
            {
                if (i.Id == id)
                {
                    product = i;
                    break;
                }
            }

            return product;
        }
        public Producto[] GetProductosByUnidadMedida(MeasureUnit um)
        {
            Producto[] tmp = null;
            if (data == null)
            {
                return tmp;
            }

            foreach (Producto p in data)
            {
                if (p.UnidadMedida == um)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }
      //  public string GetProductosAsJson()
       // {
       //     return JsonConvert.SerializeObject(data);
       // }

    }
}
