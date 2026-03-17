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


            
          










        }








        static void Main(string[] args)

        {











        }
    }
}
