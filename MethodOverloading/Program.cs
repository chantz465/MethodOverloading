using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            var num2 = 4;
            bool isDollars = true;

            //Console.WriteLine("Give me two numbers to add together");
            var num1 = 2;
            decimal num3 = .3434234324m;
            decimal num4 = .999990343234m;



            Add(num1,num2);

            Add(num3, num4);

            Add(num1, num2,isDollars);





        }

        public static void Add(int num1, int num2)

        {
            int sumOf = num1 + num2;



            Console.WriteLine(sumOf);
        }

        public static void Add(decimal num3, decimal num4)

        {
            decimal sumOf = num3 + num4;



            Console.WriteLine(sumOf);
        }

        public static string Add(int num1, int num2, bool isDollars)
        {
            var sum = num1 + num2;

            if (isDollars == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isDollars == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isDollars == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }



        }




    }
}
