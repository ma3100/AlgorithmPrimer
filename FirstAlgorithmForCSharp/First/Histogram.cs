using System;
using System.Linq;

namespace FirstAlgorithmForCSharp.First
{
    public class Histogram
    {
        public Histogram()
        {
            var histDic = Enumerable.Range(0,11).Select(x => x).ToDictionary(x => x * 10,x => 0);

            var rnd = new Random();
            var rnds = new int[10].Select(_ => rnd.Next(101)); //new int[5]は0を5個の配列になる

            foreach(var randomValue in rnds)
            {
                histDic[(randomValue / 10) * 10]++;
                Console.WriteLine(randomValue);
            }

            foreach(var resultValue in histDic)
            {
                Console.WriteLine($"{resultValue.Key}の数:{resultValue.Value}");
            }
        }
    }
}
