using System;

namespace estruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros vc vai digitar: ");
            int num = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= num; i++) {
                Console.Write("Valor #"+i+": ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Total: "+soma);
        }
    }
}
