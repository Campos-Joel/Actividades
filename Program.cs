using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Serialization;

namespace MyApp //actividad del 31/05 -joelcampos-
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto();
            Producto producto2 = new Producto();
            //mostrar producto1
            producto1.SetCodigo("010");
            producto1.SetNombre("producto A");
            /*
                                Para ejecutar IF-ELSE
            producto1.SetPrecio(-123.00);
            producto1.SetStock(-50);
            producto2.SetPrecio(-120.00);
            producto2.SetStock(-45);
            */

            producto1.SetPrecio(123.00);
            producto1.SetStock(50);
            Console.WriteLine("Producto 1");
            Console.WriteLine("Codigo " + producto1.GetCodigo());
            Console.WriteLine("Nombre: " + producto1.GetNombre());
            Console.WriteLine("Precio: " + producto1.GetPrecio());
            Console.WriteLine("Stock: " + producto1.GetStock());
            //mostrar producto2
            producto2.SetCodigo("011");
            producto2.SetNombre("Producto B");
            producto2.SetPrecio(120.00);
            producto2.SetStock(45);
            Console.WriteLine("Producto 2");
            Console.WriteLine("Codigo " + producto2.GetCodigo());
            Console.WriteLine("Nombre: " + producto2.GetNombre());
            Console.WriteLine("Precio: " + producto2.GetPrecio());
            Console.WriteLine("Stock: "+ producto2.GetStock());
            
        }
        
        public class Producto
        {
            private string codigo;
           
            private string nombre;
          
            private double precio;
          
            private int stock;


            //Get
            public string GetCodigo()
            {
                return codigo;
            }
            public string GetNombre()
            {
                return nombre;
            }
            public double GetPrecio()
            {
                return precio;
            }
            public int GetStock()
            {
                return stock;
            }
         //Set
            public void SetCodigo(string codigo)
            {
                this.codigo = codigo;
            }

             public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }

             public void SetPrecio(double precio)
            {
                if(precio < 0)
                {
                    Console.WriteLine("Precio invalido");
                }
                else
                {
                    this.precio = precio;
                }
                
            }

             public void SetStock(int stock)
            {
                if(stock < 0)
                {
                    Console.WriteLine("Stock invalido");
                }
                else
                {
                    this.stock = stock;
                }
                
            }

        } 
        
        
    }
}
