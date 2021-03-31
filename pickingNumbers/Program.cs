using System;
using System.Collections.Generic;

namespace hackerank.pickingNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(pickingNumbers(new List<int>(){1,1,2,2,4,4,5,5,5}));            
        }
        
        
        public static int pickingNumbers(List<int> a)
        {
            int[] listArray = a.ToArray();
            int maxCounted = 0;
            int counter = 0;

            for (int i = 0; i < listArray.Length - 1; i++)
            {
                int iElement = listArray[i];
                for (int j = 0; j < listArray.Length; j++)
                {
                    int jElement = listArray[j];
                    int difference = iElement - jElement;

                    if (difference == 0 || difference == -1)
                    {
                        counter++;
                    }
                }
                if (counter > maxCounted)
                {
                    maxCounted = counter;
                }

                counter = 0;
            }
            return maxCounted;
        }
    }
}