using System;
namespace Tema_2_1DEC
{
    public class P2
    {
        static void Main(string[] args)
        {
            int n, neg = 0, poz = 0, zero = 0, k;
            Console.WriteLine("Introduceti cate numere sa verific");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cate numerele");
            for (int i = 1; i <= n; i++)
            {
                k = int.Parse(Console.ReadLine());
                if (k < 0)
                    neg++;
                if (k == 0)
                    zero++;
                if (k > 0)
                    poz++;
                    
            }
            Console.WriteLine("In sir Sunt " + neg + " numere neg,  " + poz + " numere pozitive si " + zero + " numere 0");

        }
    }
}

