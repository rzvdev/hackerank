using System;

namespace electroni_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMoneySpent(new int[]{3},new int[]{8}, 10));
            Console.ReadLine(); 
        }


        public static int GetMoneySpent(int[] keyboards, int[] drivers, int b){
            int maxPrice = -1;

            for(int i = 0; i < keyboards.Length; i++){
                for(int j = 0; j < drivers.Length; j++){
                    if((keyboards[i] + drivers[j]) > maxPrice && keyboards[i] + drivers[j] <= b){
                        maxPrice = keyboards[i] + drivers[j];
                    } 
                }
            }
            return maxPrice;
        }
    }
}
