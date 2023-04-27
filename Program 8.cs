using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c;
            double f;

            Console.Write("Informe o Valor da Temperatura em Graus Celsius ºC: ");
            c = double.Parse(Console.ReadLine());
            f = ((c / 5) * 9 + 32);
            Console.WriteLine("O Valor da Temperatura em Fahrenheit ºF é: {0}", f);
        }
    }
}
