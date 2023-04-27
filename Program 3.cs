using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Li1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double a;

            Console.Write("Informe o Valor da Diagonal: ");
            d = double.Parse(Console.ReadLine());
            a = Math.Pow(d, 2) / 2;
            Console.WriteLine("O Valor da Área do Quadrado é: {0}", a);
        }
    }
}
