using Contracts;

namespace Repository.Utility
{
    public sealed class FiveMinutePeriodicTimer : IPeriodicTimer
    {
        private readonly PeriodicTimer _timer = new(TimeSpan.FromMinutes(5));

        public ValueTask<bool> WaitForNextTickAsync(CancellationToken cancellationToken = default) =>
            _timer.WaitForNextTickAsync(cancellationToken);

        public void Dispose() => _timer.Dispose();
    }

    public sealed class OneMinutePeriodicTimer : IPeriodicTimer
    {
        private readonly PeriodicTimer _timer = new(TimeSpan.FromMinutes(1));

        public ValueTask<bool> WaitForNextTickAsync(CancellationToken cancellationToken = default) =>
            _timer.WaitForNextTickAsync(cancellationToken);

        public void Dispose() => _timer.Dispose();
    }
}
