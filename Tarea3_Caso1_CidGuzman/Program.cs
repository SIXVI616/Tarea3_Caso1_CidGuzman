using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_Caso1_CidGuzman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializacion de variables
            double notaFinal = 0.0;

            Console.WriteLine("Ingrese la nota final:");

            if (double.TryParse(Console.ReadLine(), out notaFinal)) // Validacion de que la entrada se pueda convertir a double
            {
                if (notaFinal >= 0 && notaFinal <= 100) // Validar que la nota este dentro del rango
                {
                    if (notaFinal >= 70)
                    {
                        Console.WriteLine("Aprobado.");
                    }
                    else
                    {
                        Console.WriteLine("Reprobado.");
                    }
                }
                else
                {
                    Console.WriteLine("La nota debe estar entre el 0 y 100."); // Si la nota esta fuera del rango se muestra este mensaje
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado debe ser un numero."); // Si la entrada no se puede convertir a double muestra este mensaje
            }

        }
    }
}
