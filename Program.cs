using System;
using System.Diagnostics.CodeAnalysis;

namespace Sales_system
{
   public class Program
    {
        static void Main(string[] args)
        {

            Proveedor proveedor = new Proveedor();
               

            Vendedor v1 = new Vendedor();
            v1.Nombre = "JUAN";
            v1.Edad = 35;
            proveedor.AddVendedor(v1);
          

            Vendedor v2 = new Vendedor();
            v2.Nombre = "LUISA";
            v2.Edad = 28;
            proveedor.AddVendedor(v2);
          

            Vendedor v3 = new Vendedor();
            v3.Nombre = "juliana";
            v3.Edad = 25;
            proveedor.AddVendedor(v3);
            

            

            Producto P1 = new Producto();
            P1.Nombre = "Arroz";
            P1.Valor = 1800;
            proveedor.Addproducto(P1);
            
           

            Producto P2 = new Producto();
            P2.Nombre = "panela";
            P2.Valor = 4000;
            proveedor.Addproducto(P2);

            Producto P3 = new Producto();
            P3.Nombre = "chocolate";
            P3.Valor = 5000;
            proveedor.Addproducto(P3);
           
            Venta b1 = new Venta();
            v1.Nombre = "JUAN";
            P1.Nombre = "Arroz";
            b1.Comentario = "calidad";
            proveedor.AddVenta(b1);


            Venta b2 = new Venta();
            v2.Nombre = "LUISA";
            P2.Nombre = "panela";
            b2.Comentario = "el consumidor";
            proveedor.AddVenta(b2);

            Venta b3 = new Venta();
            v3.Nombre = "juliana";
            P3.Nombre = "chocolate";
            b3.Comentario = "mejor sabor";
            proveedor.AddVenta(b3);



           //quien es vendedor que vendio el prodicto mas varato?



        }





    }

}
