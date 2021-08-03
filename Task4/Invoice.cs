using System;

namespace Task4
{
    public class Invoice
    {
        private int account;
        private string customer;
        private string provider;

        private string article;
        public string Article
        {
            get => article;
            set => article = value;
        }
        private int quantity;
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public Invoice()
        {
            this.account = 125;
            this.customer = "Atea";
            this.provider = "FinPosti";
        }

        public void CalculatePrice()
        {
            Console.WriteLine("All items that we have cost 1234 EUR,");
            Console.WriteLine($"You ordered {this.quantity} items of '{this.article}'");
            Console.WriteLine($"So {1234* this.quantity} EUR to be paid. (+ {(1234 * this.quantity) * 0.23} VAT)");
            Console.WriteLine($"So {(1234 * this.quantity)+(1234 * this.quantity) * 0.23} EUR to be paid. (including VAT)");
        }

    }
}