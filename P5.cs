using System;
namespace Tema_2_1DEC
{
    public class P4
    {
        static void Main(string[] args)
        {
            int n, i = 1, k, poz = 0 ;
            Console.WriteLine("Introduceti cate numere are secventa");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere");
            while(i <=n)
            {
                k = int.Parse(Console.ReadLine());
                
                if (k == i)
                    poz++;
                i++;

                if (poz != 0)
                    Console.WriteLine("Numarul " +k + "  se afla pe aceeasi pozitie");
            };

            }
    }
}