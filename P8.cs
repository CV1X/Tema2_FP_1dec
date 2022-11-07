using System;
namespace Tema_2_1DEC
{
    public class P8
    {
        static void Main(string[] args)
        {
            int n, i, a, b, c=0;
            Console.WriteLine("Introduceti cate nr se afla in secventa");
            n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
                Console.WriteLine("1");
            else
            {
                a = 1;
                b = 1;
                for (i = 3; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;

                }
                //Console.WriteLine(" numarul este " + c);
            }
            Console.WriteLine("f_"+ n + " este egal cu " + c);
        }
    }
}

