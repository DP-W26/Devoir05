using Devoir05.Contracts;
using Devoir05.Models;

namespace Devoir05.States
{
    public class FailedState : IPaymentState
    {
        public string Name => "Failed";

        public void Handle(Payment payment)
        {
            Console.WriteLine("Payment failed.");
        }
    }
}
