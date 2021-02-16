using System;

namespace Uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial, i,c;
            i = 0;
            c = 0;
            int[] vetor;

            vetor = new int[13];

            fatorial = 0;

            n = int.Parse(Console.ReadLine());

            while (n > 13)
            {
                n = int.Parse(Console.ReadLine());
            }

            for (c = n; c > 0; c--)
            {
                if (i == 0)
                {
                    i = 1;
                    //vetor[c] = c;
                    fatorial = c;
                }
                else
                {
                    //vetor[c] = c;
                    fatorial = fatorial * c;                }
            }

            Console.WriteLine(fatorial);
        }
    }
}
