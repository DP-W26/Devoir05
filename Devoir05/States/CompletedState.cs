using Devoir05.Contracts;
using Devoir05.Models;

namespace Devoir05.States
{
    public class CompletedState : IPaymentState
    {
        public string Name => "Completed";

        public void Handle(Payment payment)
        {
            Console.WriteLine("Payment already completed.");
        }
    }
}
