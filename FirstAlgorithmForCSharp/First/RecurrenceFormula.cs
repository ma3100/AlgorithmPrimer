using System;
namespace FirstAlgorithmForCSharp.First
{
    public class RecurrenceFormula
    {
        public RecurrenceFormula()
        {
            int n, r;

            for (n = 0; n <= 5; n++)
            {
                for (r = 0; r <= n; r++)
                {
                    Console.Write($"{n} C {r} = {combi(n,r)} ");
                }
                Console.WriteLine();
            }
        }

        // 漸化式を解くコード
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
