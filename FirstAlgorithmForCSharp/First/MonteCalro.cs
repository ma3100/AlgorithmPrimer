using System;
using System.Linq;

namespace FirstAlgorithmForCSharp.First
{
    public class MonteCalro
    {
        const int RANDOMNUM = 10000;

        public double getPai()
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
            return montePai;
        }

        public double getArea(double xLength, double yLength)
        {
            double x, y, monteArea;
            var random = new Random();
            var inCircle = 0;
            foreach (var i in Enumerable.Range(0, RANDOMNUM))
            {
                x = random.NextDouble() * xLength;
                y = random.NextDouble() * yLength;

                if (x * x / Math.Pow(xLength, 2) + y * y / Math.Pow(yLength, 2) <= 1)
                {
                    inCircle++;
                }
            }

            monteArea = 4.0 * ((xLength * yLength) * inCircle / RANDOMNUM);
            Console.WriteLine($"Answer:{monteArea}");
            return monteArea;
        }
    }
}
