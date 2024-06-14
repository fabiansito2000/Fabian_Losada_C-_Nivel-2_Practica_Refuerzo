using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe La Palabra:");
            string inputText = Console.ReadLine();

            string[] words = inputText.Split(' ');

            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();
            
            foreach (string word in words)
            {
                string cleanedWord = word.Trim().ToLower();
                if (!string.IsNullOrEmpty(cleanedWord))
                {
                    if (wordFrequencies.ContainsKey(cleanedWord))
                    {
                        wordFrequencies[cleanedWord]++;
                    }
                    else
                    {
                        wordFrequencies[cleanedWord] = 1;
                    }
                }
            }

            Console.WriteLine("Palabra\tFrecuencia");
            foreach (var entry in wordFrequencies)
            {
                Console.WriteLine($"{entry.Key}\t{entry.Value}");
            }
        }
    }
}
