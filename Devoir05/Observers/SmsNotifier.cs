using Devoir05.Contracts;

namespace Devoir05.Observers
{
    public class SmsNotifier : IPaymentObserver
    {
        public void Update(string status, decimal amount)
        {
            Console.WriteLine($"[SMS] Payment of {amount}$ is now {status}");
        }
    }
}
