using Devoir05.Contracts;

namespace Devoir05.Strategies
{
    public class CryptoPayment : IPaymentStrategy
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Processing crypto payment of {amount}$");
            return false; // simulate failure
        }
    }
}
