using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double uah = 0;
            string options = "";
            string otherCur = "";

            bool whileFlag = true;
            
            Converter conv = new Converter(0.037, 0.031, 2.71);
            Console.WriteLine("Press ENTER to start of ESCAPE to exit");
            var input = Console.ReadKey();
            do
            {
                Console.Clear();
                Console.WriteLine("What you want to do: ");
                Console.WriteLine(" 1 - Convert UAH to EUR,USD or RUB");
                Console.WriteLine(" 2 - Convert EUR,USD or RUB to UAH");
                Console.Write("--> ");
                options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        options = "";
                        EnterUAH(uah, options, conv);
                        break;
                    case "2":
                        options = "";
                        EnterNotUAH(otherCur);
                        break;
                    default:
                        Console.WriteLine("404 option not found.");
                        break;
                }

                Console.ReadLine();
            } while (input.Key != ConsoleKey.Escape);
        }

        public static void EnterNotUAH(string str)
        {
         
            Console.WriteLine("Enter how much and which currency you would like to convert to UAH: ");
            Console.WriteLine("EXAMPLE: '5 USD' or '5 EUR' or '5 RUB'.");
            Console.Write("--> ");
            str = Console.ReadLine();

            string[] substr = str.Split(" ");

            double value = Double.Parse(substr[0]);
            string substrCur =  substr[1].ToUpper();

            switch (substrCur)
            {
                case "USD":
                    Console.WriteLine($"{value} USD = {value / 0.031} UAH");
                    break;
                case "EUR":
                    Console.WriteLine($"{value} EUR = {value / 0.037} UAH");
                    break;
                case "RUB":
                    Console.WriteLine($"{value} RUB = {value / 2.71} UAH");
                    break;
                default:
                    Console.WriteLine("404 option not found.");
                    break;
            }
            Console.Clear();

        }
        public static void EnterUAH(double uah, string options, Converter conv)
        {
            _Enter_UAH:
            Console.Write("Enter how much UAH you would like to convert: ");
            bool success = double.TryParse(Console.ReadLine(), out uah);
            if (success)
            {
                Console.WriteLine("\nChoose what you want to do:");
                Console.WriteLine(" 1 - Convert to EUR");
                Console.WriteLine(" 2 - Convert to USD");
                Console.WriteLine(" 3 - Convert to RUB");
                Console.Write("--> ");
                options = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                goto _Enter_UAH;
            }

            ConvertFromUAH(Math.Round((Double)uah, 2), options, conv);
        }
        public static void ConvertFromUAH(double uah,string options, Converter conv)
        {
            switch (options)
            {
                case "1":
                    Console.WriteLine($"{uah} UAH = {conv.UAH_2_EUR(uah)}");
                    break;
                case "2":
                    Console.WriteLine($"{uah} UAH = {conv.UAH_2_USD(uah)}");
                    break;
                case "3":
                    Console.WriteLine($"{uah} UAH = {conv.UAH_2_RUB(uah)}");
                    break;
                default:
                    Console.WriteLine("404 option not found.");
                    break;

            }
        }
    }
}
