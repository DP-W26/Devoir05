using Devoir05.Contracts;

namespace Devoir05.Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}$");
            return true;
        }
    }
}
