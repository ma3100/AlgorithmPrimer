using System;
namespace FirstAlgorithmForCSharp.First
{
    public class Euclidean
    {
        public Euclidean()
        {
        }

        public int minusPattern(int a,int b)
        {
            while(a != b)
            {
                if(a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            Console.WriteLine($"Answer:{a}");
            return a;
        }

        public int divisionPattern(int a,int b)
        {
            var divisionValue = -1;

            while(divisionValue != 0)
            {
                divisionValue = a % b;
                a = b;
                b = divisionValue;
            }

            Console.WriteLine($"Answer:{a}");
            return a;
        }
    }
}
