using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;

            Console.Write("Informe o Valor de X: ");
            x=double.Parse(Console.ReadLine());
            Console.Write("Informe o Valor de Y: ");
            y =double.Parse(Console.ReadLine());
            z = Math.Pow(x, y);
            Console.WriteLine("Resultado: {0}", z);
        }
    }
}
