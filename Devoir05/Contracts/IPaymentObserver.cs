namespace Devoir05.Contracts
{
    public interface IPaymentObserver
    {
        void Update(string status, decimal amount);
    }
}
