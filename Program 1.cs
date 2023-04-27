using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.Write("Informe o valor da base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da altura: ");
            h = int.Parse(Console.ReadLine());
            a = b * h;
            Console.WriteLine("O valor da área do retângulo é: {0}", a);
        }
    }
}
