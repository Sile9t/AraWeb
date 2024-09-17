namespace Contracts
{
    public interface IPeriodicTimer : IDisposable
    {
        ValueTask<bool> WaitForNextTickAsync(CancellationToken cancellationToken = default);
    }
}
