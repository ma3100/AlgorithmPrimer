using System;
using System.Linq;

namespace FirstAlgorithmForCSharp.First
{
    public class MonteCalro
    {
        const int RANDOMNUM = 10000;

        public MonteCalro()
        {
            double x, y, montePai;
            var random = new Random();
            var inCircle = 0;
            foreach(var i in Enumerable.Range(0,RANDOMNUM))
            {
                x = random.NextDouble();
                y = random.NextDouble();

                if(x * x + y * y <= 1)
                {
                    inCircle++;
                }
            }

            montePai = (double)4 * inCircle / RANDOMNUM;
            Console.WriteLine($"Answer:{montePai}");
        }
    }
}
