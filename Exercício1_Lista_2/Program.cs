using System;

namespace Exercício1_Lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor de A:");
            int a = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int c = System.Convert.ToInt32(Console.ReadLine());
            
            if (c > a + b)
            {
                Console.WriteLine(c + " é maior que a soma de " + a + " + " + b);
            }
            else
            {
                Console.WriteLine(c + "não é maior que a soma de " + a + " + " + b);
            }



        }
    }
}
