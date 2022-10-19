using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        List<Producto> ObtenerProductos()

        {

            var producto1 = new producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 Quesos";
            producto1.Precio = 200;

            var producto2 = new producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 Quesos";
            producto2.Precio = 150;

            var producto3 = new producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Jamon y Queso";
            producto3.Precio = 250;

            var listadeproductos = new List<producto>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);


            return ListaProductos;
        }

    }
}
