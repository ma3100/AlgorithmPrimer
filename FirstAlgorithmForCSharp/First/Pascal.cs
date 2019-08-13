using System;
namespace FirstAlgorithmForCSharp.First
{
    public class Pascal
    {
        public Pascal()
        {
            int N = 12;

            for(int n = 0; n <= N; n++)
            {
                for(int t=0; t<(N-n) * 3; t++)
                {
                    Console.Write(" ");
                }
                for(int r = 0;r <= n; r++)
                {
                    Console.Write($"{combi(n, r)}   ");
                }
                Console.WriteLine();
            }
        }

        private long combi(int n, int r)
        {
            long p = 1;

            for(int i = 1; i <= r; i++)
            {
                p = p * (n - i + 1) / i;
            }
            return p;
        }
    }
}
