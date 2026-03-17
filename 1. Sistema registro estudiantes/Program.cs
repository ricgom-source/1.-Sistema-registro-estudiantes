using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sistema_registro_estudiantes
{
    internal class Program

    {
        class Estudiante

        {
            public string nombre;

            public double nota1;

            public double nota2;

            public double nota3;


            public double calcularProm() 
            
            {
                
                return (nota1+nota2+nota3)/3;
            
            
            }
            
            public string resultado()

            {
                if (calcularProm()>=61)

                {
                    return ("Usted ha sido aprobado");

                }

                else

                {

                    return ("Usted esta reprobado");

                }

            }


            public void mostrarDatos()

            {
                Console.WriteLine($"El nombre del estudiante es: {nombre} | su promedio es de: {calcularProm()} | el estudiante está: {resultado()} ");


            }



        }




        static void Main(string[] args)

        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            Console.Write("¿Cuántos estudiantes desea registrar?: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Estudiante e = new Estudiante();

                Console.WriteLine($"\nEstudiante {i + 1}");

                Console.Write("Nombre del estudiante: "); e.nombre = Console.ReadLine();

                Console.Write("Resultado de la nota 1: "); e.nota1 = double.Parse(Console.ReadLine());

                Console.Write("Resultado de la nota 2: "); e.nota2 = double.Parse(Console.ReadLine());

                Console.Write("Resultado de la nota 3: "); e.nota3 = double.Parse(Console.ReadLine());

                estudiantes.Add(e);
            }

            Console.WriteLine("\n--- LISTADO DE  ESTUDIANTES  ---");

            foreach (Estudiante e in estudiantes)

            {
                e.mostrarDatos();
            }







        }
    }
}
