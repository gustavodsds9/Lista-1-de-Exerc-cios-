using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9LIs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double d;
            double a;

            Console.Write("Informe o Valor do Diâmetro: ");
            d = double.Parse(Console.ReadLine());
            r = d / 2;
            a = Math.PI*Math.Pow(r, 2);
            Console.WriteLine("O Valor da Área do Circulo é: {0}", a);
        }
    }
}
