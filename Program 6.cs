using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double media;

            Console.Write("Digite o 1º Valor: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º Valor: ");
            v2 = double.Parse(Console.ReadLine());
            media = v1 * v2;
            double mediageo = Math.Sqrt(media);
            Console.WriteLine("A média Geométrica entre os Valores Informados é: {0}", mediageo);
        }
    }
}
