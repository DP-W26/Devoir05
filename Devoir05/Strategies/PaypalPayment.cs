using Devoir05.Contracts;

namespace Devoir05.Strategies
{
    public class PayPalPayment : IPaymentStrategy
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}$");
            return true;
        }
    }
}
