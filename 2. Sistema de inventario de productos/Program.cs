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

            public double cantidad;


            public double calcularValortot()

            {

                return precio*cantidad;


            }

            public string stock()

            {
                if (cantidad == 0)

                {
                    return ();

                }

                else

                {

                    return ();

                }

            }


            public void mostrarDatos()

            {
                Console.WriteLine($"El nombre del estudiante es: {nombre} | su promedio es de: {calcularProm():F2} | el estudiante está: {resultado()} ");


            }



        }


        static void Main(string[] args)

        {







        }
    }
}
