using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FirstAlgorithmForCSharp.First
{
    public class Eratosthenes
    {
        public Eratosthenes()
        {

        }

        public void notEratosthenes(int num)
        {
            var answerList = new List<int>();

            for (int x = 2; x < num; x++)
            {
                var limit = (int)Math.Sqrt(x);
                int targetNum;

                for (targetNum = limit; targetNum > 1; targetNum--)
                {
                    if (x % targetNum == 0)
                    {
                        break;
                    }
                }

                if (targetNum == 1)
                {
                    answerList.Add(x);
                }
            }
            Console.WriteLine("answer");
            Console.WriteLine(string.Join(" ", answerList));
        }

        public void eratosthenes(int num)
        {
            var answerArray = new int[num + 1];

            var limit = (int)Math.Sqrt(num);

            for(int i = 2;i <= limit;i++)
            {
                if(answerArray[i] == 0)
                {
                    for(int j = 2 * i;j <= num;j++)
                    {
                        if(j % i == 0)
                        {
                            answerArray[j] = 1;
                        }
                    }
                }
            }

            Console.WriteLine("answer");
            for(int i = 2; i <= num;i++)
            {
                if(answerArray[i] == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
}
