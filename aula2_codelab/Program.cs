using System;
using System.Collections.Generic;
using System.Linq;

namespace aula2_codelab
{
    class Program
    {
        static void Main(string[] args)
        {



            /*1.Algoritmo para calcular fatorial de um número informado pelo usuário.*/

            Console.Write("Digite um número para ver o fatorial:");
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = n;
            int mult = 1;

            Console.Write($"{n}! {n} x ");
            while (cont > 1)
            {
                cont--;
                Console.Write($"{cont} ");
                if (cont > 1)
                {
                    Console.Write("x ");
                }
                else
                {
                    Console.Write("= ");
                }
                mult = mult + (mult * cont);
            }
            Console.WriteLine(mult);

            /*2.Algoritmo para encontrar o maior valor de uma lista de números com
            tamanho e valores definidos por usuário.

            Console.Write("Digite o tamanho da lista:");
            int tam = Convert.ToInt32(Console.ReadLine());
            List<int> numeros = new List<int> { };

            for (int i = 0; i < tam; i++)
            {
                Console.Write($"Digite o {i + 1}° valor da lista:");
                int valor = Convert.ToInt32(Console.ReadLine());
                numeros.Add(valor);
            }

            int max = numeros.Max();
            Console.WriteLine($"Maior valor:{max}");*/

            /*3.Algoritmo para definir um array de números com tamanho e valores
            definidos pelo usuário e apresentá-lo em tela ordenado de forma
            crescente.

            Console.Write("Digite o tamanho do array:");
            int quant = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[quant];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° do array:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numeros);

            Console.WriteLine("[{0}] {1}", string.Join(", ", numeros), " é a lista ordenada!");*/

            /*4.Altere o algoritmo anterior para que os números sejam inseridos no
            array aleatoriamente: utilizar o objeto Random(). A aplicação também
            deve apresentar o número que tem a maior frequência

            Console.Write("Digite o tamanho do array:");
            int quant = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[quant];

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 100); 
            }
            Array.Sort(numeros);
            Console.WriteLine("[{0}] {1}", string.Join(", ", numeros), " é a lista ordenada!");*/
        }
    }
}
    