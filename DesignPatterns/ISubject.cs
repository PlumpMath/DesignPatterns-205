namespace DesignPatterns
{
    public interface ISubject
    {
        string Data { get; set; }

        void Notify();

        void Attach(IObserver observer);

        void Detach(IObserver observer);
    }
}