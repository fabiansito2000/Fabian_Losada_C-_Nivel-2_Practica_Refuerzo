using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> calificaciones = new List<double>();

            Console.WriteLine("coloca cualquier calificacion (luego colocas 'fin' para terminar):");
            string input;
            while ((input = Console.ReadLine()) != "fin")
            {
                if (double.TryParse(input, out double calificacion))
                {
                    calificaciones.Add(calificacion);
                }
                else
                {
                    Console.WriteLine("Caracter no válido Ingresa un número decimal o 'fin' para terminar.");
                }
            }

            if (calificaciones.Count > 0)
            {
                double maxCalificacion = double.MinValue;
                double minCalificacion = double.MaxValue;
                double sumaCalificaciones = 0;

                foreach (var calificacion in calificaciones)
                {
                    maxCalificacion = Math.Max(maxCalificacion, calificacion);
                    minCalificacion = Math.Min(minCalificacion, calificacion);
                    sumaCalificaciones += calificacion;
                }

                double promedioCalificaciones = sumaCalificaciones / calificaciones.Count;


                Console.WriteLine($"Calificación mas alta: {maxCalificacion}");
                Console.WriteLine($"Calificación mas baja: {minCalificacion}");
                Console.WriteLine($"Promedio de calificaciones: {promedioCalificaciones}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }
        }
    }
}
