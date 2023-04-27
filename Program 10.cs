using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double real;
            double dolar;
            double ct;
            double conversao;

            Console.Write("Cotação do Dólar em Reais (R$): ");
            real = double.Parse(Console.ReadLine());
            Console.Write("Informe o Dólar (U$): ");
            dolar = double.Parse(Console.ReadLine());

            conversao = dolar * real;
            Console.WriteLine("O Valor em Reais em Dólar é {0}", conversao);
        }
    }
}
