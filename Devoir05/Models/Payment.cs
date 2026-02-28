using Devoir05.Contracts;
using Devoir05.States;

namespace Devoir05.Models
{
    public class Payment
    {
        public decimal Amount { get; }
        private IPaymentStrategy _strategy;
        private IPaymentState _state;
        private readonly List<IPaymentObserver> _observers = new();

        public Payment(decimal amount)
        {
            Amount = amount;
            _state = new PendingState();
        }

        public void SetStrategy(IPaymentStrategy strategy)
            => _strategy = strategy;

        public void Attach(IPaymentObserver observer)
            => _observers.Add(observer);

        public void SetState(IPaymentState state)
        {
            _state = state;
            Notify();
        }

        public void Process()
        {
            _state.Handle(this);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(_state.Name, Amount);
        }

        public bool ExecutePayment()
            => _strategy.Pay(Amount);
    }
}
