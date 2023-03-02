using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Teste_1
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 5, 3, 9, 6, 4, 1 };
            int sum = 0;

            // Imprime a lista original
            Console.WriteLine("Original List: ");
            foreach (var index in numbers)
            {
                Console.Write(index + " ");
            }

            //Valida o 9 e troca por 5
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    numbers[i] = 5;
                }
            }
            //remove o 4
            numbers = Array.FindAll(numbers, n => n != 4);

            Console.WriteLine("\nLista modificada: ");
            foreach (var numero in numbers)
            {
                Console.Write(numero + " ");
            }

            // Calcula e imprime a soma dos valores da nova lista
            foreach (int index in numbers)
            {
                sum += index;
            }
            Console.WriteLine($"\nSoma dos valores da nova modificada: {sum}");
        }
    }
}
