using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1;
            Double soma;
            Double e;
            Double n2;
            Double raiz = 1.41;
            Console.WriteLine("Coloque o valor do Diagonal:");
            n1 = Double.Parse(Console.ReadLine());
            e = n1 / raiz;
            soma = n1 / raiz;
            n2 = soma * e;
            Console.WriteLine("O valor da Área");
            Console.WriteLine(n2);
        }
    }
}
