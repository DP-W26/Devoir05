using Devoir05.Models;
using Devoir05.Observers;
using Devoir05.Strategies;

namespace Devoir05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amount;
            bool valid;

            do
            {
                Console.Write("Enter amount: ");
                valid = decimal.TryParse(Console.ReadLine(), out amount);

                if (!valid)
                    Console.WriteLine("Invalid amount. Please enter a valid number (e.g., 109.92).");

            } while (!valid);

            var payment = new Payment(amount);

            payment.Attach(new EmailNotifier());
            payment.Attach(new SmsNotifier());

            string? choice;

            do
            {
                Console.Write("Enter payment method (1=Card, 2=PayPal, 3=Crypto): ");
                choice = Console.ReadLine();
                if (choice is null)
                    choice = string.Empty;

                valid = choice is "1" or "2" or "3";

                if (!valid)
                    Console.WriteLine("Invalid selection.");

            } while (!valid);

            switch (choice)
            {
                case "1":
                    payment.SetStrategy(new CreditCardPayment());
                    break;
                case "2":
                    payment.SetStrategy(new PayPalPayment());
                    break;
                case "3":
                    payment.SetStrategy(new CryptoPayment());
                    break;
            }


            payment.Process();
        }
    }
}
