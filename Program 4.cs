using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b;
            double h;
            double a;

            Console.Write("Informe o Valor da Base do Triângulo: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe o Valor da Altura do Triângulo: ");
            h = double.Parse(Console.ReadLine());
            a = (b * h) / 2;
            Console.WriteLine("O Valor da Área do Triângulo é: {0}", a);
        }
    }
}
