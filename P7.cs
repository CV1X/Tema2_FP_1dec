using System;
namespace Tema_2_1DEC
{
    public class P7
    {
        static void Main(string[] args)
        {
            int n, k, i=1, max = 0, min = 0 ;
            Console.WriteLine("Introduceti cate nr are secventa");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti secventa");
            while (i <= n)
            {
                k = int.Parse(Console.ReadLine());
                if (k > max)
                    max = k;
                else
                    min = k;
                i++;

                
                
            }
            Console.WriteLine("Numarul maxim este " +max + " iar numarul minim este "+ min);

        }
    }
}

