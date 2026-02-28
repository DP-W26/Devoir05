using Devoir05.Contracts;

namespace Devoir05.Observers
{
    public class EmailNotifier : IPaymentObserver
    {
        public void Update(string status, decimal amount)
        {
            Console.WriteLine($"[Email] Payment of {amount}$ is now {status}");
        }
    }
}
