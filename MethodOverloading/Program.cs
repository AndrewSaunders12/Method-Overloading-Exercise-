namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(21,7));
            Console.WriteLine(Add(3.6m,6.4m));
            Console.WriteLine(Add(7, 14, true));
        }


        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        static string Add(int num1, int num2, bool isTrue)
        {
            if (isTrue)
            {
                return num1 + num2 + " dollars" ;
            }
            else
            {
                return "Nuh uh";
            }
        }

    }

}
