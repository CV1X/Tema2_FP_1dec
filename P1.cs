using System;
namespace Tema_2_1DEC
{
    public class P1
    {
        static void Main(string[] args)
        {
            int n,p=0,k;
            Console.WriteLine("Introduceti cate numere sa verific");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cate numerele");
            for (int i = 1; i <= n; i++)
            {
                k = int.Parse(Console.ReadLine());
                if (k % 2 == 0)
                    p++;
            }
            Console.WriteLine("Sunt " + p + " numere pare");

        }
    }
}

