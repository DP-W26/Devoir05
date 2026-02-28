using Devoir05.Contracts;
using Devoir05.Models;

namespace Devoir05.States
{
    public class PendingState : IPaymentState
    {
        public string Name => "Pending";

        public void Handle(Payment payment)
        {
            bool success = payment.ExecutePayment();

            if (success)
                payment.SetState(new CompletedState());
            else
                payment.SetState(new FailedState());
        }
    }
}
