using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12Lis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double p3;
            double p4;
            double p5;
            double soma;
            double pagamento;
            double troco;

            Console.Write("Informe o Valor do 1º Produto: ");
            p1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o Valor do 2º Produto: ");
            p2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o Valor do 3º Produto: ");
            p3 = double.Parse(Console.ReadLine());
            Console.Write("Informe o Valor do 4º Produto: ");
            p4 = double.Parse(Console.ReadLine());
            Console.Write("Informe o Valor do 5º Produto: ");
            p5 = double.Parse(Console.ReadLine());
            soma = p1 + p2 + p3 + p4 + p5;
            Console.WriteLine("O Valor a Ser Pago é: {0}", soma);
            Console.WriteLine("Pagamento: ");
            pagamento = double.Parse(Console.ReadLine());
            troco = pagamento - soma;
            Console.WriteLine("O Troco será: {0}", troco);



        }
    }
}
