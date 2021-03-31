using System;

namespace hackerank.hurdleRace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(hurdleRace(4,new int[] { 1,6,3,5,2}));
        }
        
        static int hurdleRace(int k, int[] height)
        {
            int doses = 0;
            
            for (int i = 0; i < height.Length; i++)
            {
                int difference = height[i] - k;

                    if(difference > 0)
                {
                    doses += difference;
                    k += difference;
                }
            }

            return doses;
        }
    }
}