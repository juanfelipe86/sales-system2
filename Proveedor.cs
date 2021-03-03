using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_system
{
    class Proveedor 
    {
        Vendedor[] Vendedors = new Vendedor[4];
        int Vendedorscount = 0;

       
        Venta[] Ventas = new Venta[6];
        int Ventascount = 0;

        Producto[] Productos = new Producto[10];
        int Productoscount = 0;

        public void AddVendedor(Vendedor newVendedor)
        {
            Vendedors[Vendedorscount] = newVendedor;
            Vendedorscount++;

        }

        public void AddVenta(Venta newVenta)
        {
            Ventas[Ventascount] = newVenta;
            Ventascount++;

        }
        public void Addproducto(Producto newProducto)
        {
            Productos[Productoscount] = newProducto;
            Productoscount++;

        }

        public int CountVendedor()
        {
            int count = 0;


            for (int i = 0; i < Vendedorscount; i++)
            {
                if (Vendedors[i].)

            }

            return count;
        }


    }
}
