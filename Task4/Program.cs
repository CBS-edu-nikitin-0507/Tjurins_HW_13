using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice();

            Console.Write("Enter article of an item: ");
            inv.Article = Console.ReadLine();
            _REDO:
            Console.Write("Quantity: ");
            int quan;
            bool success = int.TryParse(Console.ReadLine(), out quan);
            if (success)
            {
                inv.Quantity = quan;
            }
            else
            {
                Console.Clear();
                goto _REDO;
            }
            inv.CalculatePrice();

        }


    }
}
