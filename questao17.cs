using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int estoque, max_estoque, min_estoque;
            float media;

            Console.WriteLine("Quantidade em estoque: ");
            estoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade m�xima em estoque: ");
            max_estoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade minima em estoque: ");
            min_estoque = int.Parse(Console.ReadLine());

            media = ( max_estoque + min_estoque ) / 2;

            if ( estoque >= media )
            {
                Console.WriteLine("N�o Efetuar Compra!");
            }
            else
            {
                Console.WriteLine("Efetuar Compra!");
            }

            Console.ReadKey();

        
        }

            
    }
}