using System;

namespace catsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(catsAndMouse(1,3,2));
        }

        static string catsAndMouse(int x, int y, int z){
            int catA = Math.Abs(z-x);
            int catB = Math.Abs(z-y);

            if(catA == catB){
                return "Mouse C";
            } else if(catA > catB){
                return "Cat B";
            } else {
                return "Cat A";
            }

                         
        }
    }
}
