using System.ComponentModel.Design;
using System.Xml.Schema;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 7));
            Console.WriteLine(Add(5.2m, 7.2m));
            Console.WriteLine(Add(1, 0, true));
        }
        public static int Add(int a, int b) 
        { 
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool aboveOne)
        {
            
            var userSum = a + b;
            
            if (aboveOne && (userSum) != 1)
            {
                return $"{userSum} dollars";
            }
            else if (aboveOne && (userSum) == 1)
            {
                return $"{userSum} dollar";
            }
            else
            {
                return $"{userSum}";
            }
        }

    }
}
