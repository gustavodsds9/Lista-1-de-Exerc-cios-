using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double v3;
            double v4;
            double media;

            Console.Write("Informe o 1º Valor: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o 2º Valor: ");
            v2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o 3º Valor: ");
            v3 = double.Parse(Console.ReadLine());
            Console.Write("Informe o 4º Valor: ");
            v4 = double.Parse(Console.ReadLine());

            media = (v1 + v2 + v3 + v4) / 4;

            Console.WriteLine("A Média dos Valores Informados é: {0}", media);
        }
    }
}
