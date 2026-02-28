using Devoir05.Models;

namespace Devoir05.Contracts
{
    public interface IPaymentState
    {
        void Handle(Payment payment);
        string Name { get; }
    }
}
