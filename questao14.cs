using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace estudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano, nascimento;

            Console.WriteLine("Ano Atual: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Ano De Nascimento: ");
            nascimento = int.Parse(Console.ReadLine());

            if (ano - nascimento >= 18)
            {
                Console.WriteLine("Poder� votar este ano!");
            }
            else
            {
                Console.WriteLine("N�o poder� votar este ano!");
            }

            Console.ReadKey();

        }
    }
}