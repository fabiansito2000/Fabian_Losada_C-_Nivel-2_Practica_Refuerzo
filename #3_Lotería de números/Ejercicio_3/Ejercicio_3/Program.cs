using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numerosGanadores = new List<int>();
            Random random = new Random();
            while (numerosGanadores.Count < 6)
            {
                int numeroAleatorio = random.Next(1, 50);
                if (!numerosGanadores.Contains(numeroAleatorio))
                {
                    numerosGanadores.Add(numeroAleatorio);
                }
            }

            List<int> numerosUsuario = new List<int>();
            Console.WriteLine("Escribe 6 numeros distintos entre 1 y 49:");
            while (numerosUsuario.Count < 6)
            {
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    if (numeroIngresado >= 1 && numeroIngresado <= 49 && !numerosUsuario.Contains(numeroIngresado))
                    {
                        numerosUsuario.Add(numeroIngresado);
                    }
                    else
                    {
                        Console.WriteLine("Numero invalido o repetido. Intentalo otra vez.");
                    }
                }
                else
                {
                    Console.WriteLine("Coloca un numero valido.");
                }
            }

            int aciertos = 0;
            foreach (int numeroGanador in numerosGanadores)
            {
                if (numerosUsuario.Contains(numeroGanador))
                {
                    aciertos++;
                }
            }

            Console.WriteLine("\nNumeros ganadores:");
            Console.WriteLine(string.Join(", ", numerosGanadores));
            Console.WriteLine("\nTus numeros elegidos:");
            Console.WriteLine(string.Join(", ", numerosUsuario));
            Console.WriteLine($"\nNumero de aciertos: {aciertos}");

            if (aciertos == 6)
            {
                Console.WriteLine("Felicitaciones! Acertaste todos los numeros.");
            }
        }
    }
}
