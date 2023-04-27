using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1;
            double l2;
            double a;

            Console.Write("Informe o Valor da Aresta: ");
            l1 = double.Parse(Console.ReadLine());
            l2 = l1;
            a = l1 * l2;
            Console.WriteLine("O Valor da Área do Quadrado é: {0}", a);

        }
    }
}
