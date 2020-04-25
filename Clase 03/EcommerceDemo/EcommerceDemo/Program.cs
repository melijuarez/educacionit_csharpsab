using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.EntidadesDeNegocio;

namespace EcommerceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ECOMMERCE DEMO");

            Producto productoUno = new Producto()
            {
                Id = 1,
                Discontinuado = false,
                Nombre = "Teclado",
                PrecioUnitario = 300,
                Stock = 10
            };

            Producto productoDos = new Producto()
            {
                Id = 2,
                Discontinuado = false,
                Nombre = "Mouse con cable",
                PrecioUnitario = 150,
                Stock = 5
            };


            Producto productoTres = new Producto()
            {
                Id = 3,
                Discontinuado = false,
                Nombre = "Mouse inalámbrico",
                PrecioUnitario = 500,
                Stock = 25
            };

            Compra compra = new Compra()
            {
                Id = 1,
                DireccionParaLaEntrega = "Calle falsa 123",
                Fecha = DateTime.Now,
                NombreParaLaEntrega = "Cosme Fulanito"
            };

            DetalleCompra detalleCompraUno = new DetalleCompra()
            {
                Producto = productoUno,
                Cantidad = 3,
                Precio = 300
            };

            DetalleCompra detalleCompraDos = new DetalleCompra()
            {
                Producto = productoDos,
                Cantidad = 1,
                Precio = 150
            };

            DetalleCompra detalleCompraTres = new DetalleCompra()
            {
                Producto = productoTres,
                Cantidad = 2,
                Precio = 500
            };

            compra.ProductosComprados.Add(detalleCompraUno);
            compra.ProductosComprados.Add(detalleCompraDos);
            compra.ProductosComprados.Add(detalleCompraTres);
            compra.ProductosComprados.Remove(detalleCompraUno);

            Console.WriteLine(compra.ProductosComprados.IndexOf(detalleCompraDos));

            foreach(DetalleCompra detalle in compra.ProductosComprados)
            {
                Console.WriteLine("Se compro el producto " + detalle.Producto.Nombre);
                detalle.Cantidad++;
            }

            DetalleCompra encontrados = compra.ProductosComprados.Find(pc => pc.Producto.Id == 4);

            Console.ReadKey();
        }
    }
}
