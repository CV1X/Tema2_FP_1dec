using System;
namespace Tema_2_1DEC
{
    public class P4
    {
        static void Main(string[] args)
        {
            int n, k,x=1,i=1;
            Console.WriteLine("introduceti cate nr are secventa");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele");
            while(i<=n && x==1)
            {

                k = int.Parse(Console.ReadLine());
                if (k < i)
                    x = 0;
                    
                i++;
            }


            if(x==1)
                Console.WriteLine("Numerele sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele NU sunt in ordine crescatoare");
        }
    }
}

