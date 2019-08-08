using System;
namespace FirstAlgorithmForCSharp.First
{
    public class Polynomial
    {
        public Polynomial()
        {
            var keisuu = new int[]{ 1,2,3,4,5};

            for(int i = 1;i <= 5; i++)
            {
                Console.WriteLine($"多項式 ({i} = {polynomial(i,keisuu,4)})");
            }

        }

        private int polynomial(int i, int[] keisuu, int v)
        {
            int p = keisuu[v];
            for(int x = v - 1; x >= 0; x--)
            {
                p = p * i + keisuu[x];
            }

            return p;
        }
    }
}
