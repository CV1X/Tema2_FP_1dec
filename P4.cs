using System;
namespace Tema_2_1DEC
{
    public class P4
    {
        static void Main(string[] args)
        {
            
            int n, a,k, p=0,aux;
            Console.WriteLine("Introduceti cate numere are secventa");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numerele din secventa");

            for (int i = 1; i <= n; i++)
            {
                k = int.Parse(Console.ReadLine());
                if (a == k)
                    aux=p;
                else
                    p++;
            }

            Console.WriteLine("Numarul "+ a + " Se afla pe pozitia "+ aux);
        }
    }
}

