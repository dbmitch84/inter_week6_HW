using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter_week6_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //values used for the problems
            int a = 5; 
            int b = 11;
            int width = 4;
            int height = 3;
            int[] arr = { 6, 2, 400, 80 };
            string phrase = "Random writings and letters aeiou 7";

            Console.WriteLine("Product = {0}", Product(a,b));
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

            Console.WriteLine(); //blank space
            Console.WriteLine("Factorial = {0}",Factorial(a));
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

            Console.WriteLine(); //blank space
            
            string oldChar = "s";
            string newChar = "Spongebob";
            Replace(oldChar,newChar);
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

            Console.WriteLine(); //blank space
            Console.WriteLine("Parallelogram");
            MakeAsciiParallelogram(width,height);
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

            Console.WriteLine(); //blank space
            Console.WriteLine("AsciiRect");
            MakeAsciiRect(width,height);
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

            Console.WriteLine(); //blank space
            Console.WriteLine("SumOfArray");
            SumOfArray(arr);
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

            Console.WriteLine(); //blank space
            Console.WriteLine("MaxInArray");
            MaxInArray(arr);
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

            Console.WriteLine(); //blank space
            Console.WriteLine("MinInArray");
            MinInArray(arr);
            Console.WriteLine("******END OF METHOD******");//indicates end of current method

       

        }

      

        private static void MinInArray(int[] arr)
        {
           
            Console.WriteLine(arr.Min());
        }

        private static void MaxInArray(int[] arr)
        {
           
            Console.WriteLine(arr.Max());
        }

        private static void SumOfArray(int[] arr)
        {
             
            Console.WriteLine(arr.Sum());
        }

        private static void MakeAsciiRect(int width, int height)
        {
            for (int i = 0; i < height; i++) // loop for dashes
            {

                //loop for width
                for (int j = 0; j < width; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();

               
            }
            Console.WriteLine();//blank space that resets position for next console item
        }

        private static void MakeAsciiParallelogram(int width, int height)
        {
            
            for (int i = 0; i < height; i++) // loop for dashes
            {

                //loop for width
                for (int j = 0; j < width; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();

                //loop for spaces
                for (int l = 0; l <= i; l++)
                {
                    Console.Write("  ");//two space
                }
            }
            Console.WriteLine();//blank space that resets position for next console item
        }

        private static int Factorial(int a)
        {
            if (a == 1)
                return 1;
            else
                return a * Factorial(a - 1);
        }

        public static int Product(int a, int b)
        {
            return a + b; 
        }


        public static void Replace(string oldChar, string newChar)
        {
             oldChar = "s";
             newChar = "Spongebob";
            string phrase = "Random writings and letters aeiou";
            Console.WriteLine(phrase.Replace(oldChar, newChar));
            
           
        }

    }
}
