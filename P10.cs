using System;
namespace Tema_2_1DEC
{
    public class P10
    {
        static void Main(string[] args)
        {
            int n, i = 1, x = 0 ;
            float k, max=0;

            Console.WriteLine("Introduceti cate nr are secventa");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele din secventa");

            while (i <= n)
            {
                
                k = float.Parse(Console.ReadLine());
                
                for(int p = 1; p <= n; p++)
                {
                    if (k == p)
                    {

                    }
                }
                if (k == max)
                {
                    x++;
                    max = k;
                }
                i++;

            }
            Console.WriteLine("Numarul de numere consecutive este " + x);
        }
    }
}

