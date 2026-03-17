using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sistema_de_inventario_de_productos
{
    internal class Program

    {
        class Producto

        {
            public string nombre;

            public double precio;

            public int cantidad;


            public double calcularValortot()

            {

                return precio*cantidad;


            }

            public string stock()

            {
                if (cantidad == 0)

                {
                    return ("Sin existencias");

                }

                else if(cantidad<=6)

                {

                    return ("stock bajo");

                }

                else

                {
                    return ("stock suficiente");

                }

            }


            public void mostrarDatos()

            {
                Console.WriteLine($"Producto: {nombre} | su precio es de: Q{precio:F2}");

                Console.WriteLine();

                Console.WriteLine($"Cantidad de producto: {cantidad}| Total de inventario: Q{calcularValortot():F2}");


            }



        }


        static void Main(string[] args)

        {
            List<Producto> productos = new List<Producto>();

            Console.WriteLine("¿Cuantos productos desea registrar:_ ");

            int n = int.Parse(Console.ReadLine());

            for(int i=0;i < n;i++)

            {




            }






        }
    }
}
