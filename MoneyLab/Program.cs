using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CurrencyCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            string input;

            Console.WriteLine("Please enter your first amount.");
            input = Console.ReadLine();
            a = Convert.ToDouble(input);

            Console.WriteLine("Please enter your second amount.");
            input = Console.ReadLine();
            b = Convert.ToDouble(input);

            Console.WriteLine("Please enter your third amount.");
            input = Console.ReadLine();
            c = Convert.ToDouble(input);

            d = a + b + c;

            Console.WriteLine("Your sum of the three amounts is, " + d.ToString("n2"));

            
            Console.WriteLine("Your total is $" + d.ToString("n2"));
            Console.WriteLine("The average of the numbers inputed is, " + ((d / 3).ToString("n2")));

            double[] input2 = { a, b, c };
            double lowest = input2.Min();
            double highest = input2.Max();

            Console.WriteLine("The highest value entered is, " + "$" + highest.ToString("n2"));
            Console.WriteLine("The lowest value entered is, " + "$" + lowest.ToString("n2"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CreateSpecificCulture("da-Dk");

            Console.WriteLine("The value entered is equivalent to USD$ (United States Dollar), $" + d.ToString("n2"));
            Console.WriteLine("The value entered is equivalent to kr (Swedish Krona), " + d.ToString("C2",
                CultureInfo.CreateSpecificCulture("da-Dk")));
            Console.WriteLine("The value entered is equivalent to THB (Thai Baht), " + "฿" + d.ToString("n2"));
            d = Convert.ToInt32(d);
            Console.WriteLine("The value entered is equivalent to Yen¥ (Japanese Yen), " + "¥" + d);

            Console.ReadLine();












        }
    }
}
