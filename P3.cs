using System;
namespace Tema_2_1DEC
{
    public class P3
    {
        static void Main(string[] args)
        {
            int n, suma = 0, prod = 1, k;
            Console.WriteLine("Introduceti cate numere sa verific");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
                prod = prod * i;

            }
            Console.WriteLine("Suma este " + suma + " iar produsul este " + prod);

        }
    }

}