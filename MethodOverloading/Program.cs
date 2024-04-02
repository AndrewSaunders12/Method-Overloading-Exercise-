using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = Add(1, 2);
            var decimalAnswer = Add(1.3m, 2.7m);
            var thirdAnswer = Add(0, 0, true);
            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }

        public static int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public static decimal Add(decimal number1, decimal number2)
        {
            decimal sum = number1 + number2;
            return sum;
        }

        public static string Add(int number1, int number2, bool hero)
        {
            int sum = number1 + number2;
            if (hero == true && sum > 1)
            {
                
                return $"{sum} dollars";
            }
            else if (hero == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(hero == true && sum < 1)
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

