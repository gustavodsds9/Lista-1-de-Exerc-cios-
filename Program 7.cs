using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milha;
            double km;

            Console.Write("Digite o Valor em Milhas Marítimas da Distância: ");
            milha = double.Parse(Console.ReadLine());
            km = (milha * 1852 / 1000);
            Console.WriteLine("O Valor em Km é: {0}", km);
        }
    }
}
