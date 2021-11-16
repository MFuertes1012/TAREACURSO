using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Productos;
using Domain.Enums;
using Domain.Interfaces;

namespace AppCore.Interfaces
{
    public interface IProductService : IService<Producto>
    {
      
            Producto GetProductoById(int id);
            Producto[] GetProductosByUnidadMedida(MeasureUnit um);
            string GetProductosAsJson();

            ProductItem[] GetProductsItems();
            ProductItem GetProductsItems(int productId);
        
    }


}
