using System;
namespace Tema_2_1DEC
{
    public class P9
    {
        static void Main(string[] args)
        {
            int n,i=1,x=1;
            float k;
            Console.WriteLine("Introduceti cate nr are secventa");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numerele din secventa");

            while (i <= n && x == 1)
            {

                k = float.Parse(Console.ReadLine());
                if (k < i)
                    x = 0;
                


                i++;
            }
            if (x == 1)
                Console.WriteLine("sirul este monoton ");
            else
                Console.WriteLine("Sirul nu este monoton");
            
        }
    }
}

