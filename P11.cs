using System;
namespace Tema_2_1DEC
{
    public class P11
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            int k,s=0;

            Console.WriteLine("Introduceti cate nr are secventa");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele din secventa");

            while (i <= n)
            {

                k = int.Parse(Console.ReadLine());
                int aux = 0, p = 1 ;
                while (k != 0)
                {
                    p = k % 10;
                    aux = aux * 10 + p;    
                    k = k/ 10;
                   
                }
                s = s + aux;
                i++;
                

            }
            Console.WriteLine("Suma inverselor este " + s);
        }
    }
}

