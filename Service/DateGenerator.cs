using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shared.Dtos;
using System.Linq;

namespace Service
{
    public class DateGenerator : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IPeriodicTimer _timer;

        public DateGenerator(IServiceProvider serviceProvider, ILoggerManager logger, IMapper mapper,
            IPeriodicTimer timer)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
            _mapper = mapper;
            _timer = timer;
        }

        public async Task StartAsync(CancellationToken stoppingToken)
        {
            //await Task.Yield();
            await Task.Delay(1_000);

            _logger.LogInfo($"{nameof(DateGenerator)} is running.");

            IServiceScope scope = _serviceProvider.CreateScope();

            try
            {
                var repository = scope.ServiceProvider.GetService<IRepositoryManager>();
                if (repository is null)
                {
                    _logger.LogInfo($"{nameof(DateGenerator)}: " +
                        $"{nameof(IRepositoryManager)} scope haven't been created.");
                    return;
                }

                do
                {

                    await CheckAllApartmentsForDatesAndCreateNewIfNeeded(repository);
                }
                while (!stoppingToken.IsCancellationRequested
                    && await _timer.WaitForNextTickAsync(stoppingToken));
            }
            catch (OperationCanceledException)
            {
                _logger.LogInfo($"{nameof(DateGenerator)} is stopping.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(DateGenerator)}: Exception has occured - {ex.Message}");
            }
        }

        public Task StopAsync(CancellationToken stoppingToken) =>
            Task.CompletedTask;

        private async Task CheckAllApartmentsForDatesAndCreateNewIfNeeded(IRepositoryManager repository)
        {
            var aparts = await repository.Apartment
                .GetAllApartmentsAsync(trackChanges: true);
            var dates = GenerateDates(DateTime.Now, DateTime.Now.AddMonths(6));

            foreach (var apart in aparts)
            {
                await CreateDateCollectionForApartmentAsync(repository, apart.Id, dates, trackChanges: true);
            }
        }

        public async Task CreateDateCollectionForApartmentAsync(IRepositoryManager repository, 
            Guid apartId, IEnumerable<DateTime> dateRange, bool trackChanges)
        {
            var apart = await repository.Apartment
                .GetApartmentByIdAsync(apartId, trackChanges);
            if (apart is null) return;

            var dateEntities = await CreateDateEntitiesCollectionForApartmentAsync(repository,
                apartId, dateRange, trackChanges);
            if (dateEntities is null) return;

            var dates = _mapper.Map<IEnumerable<ReservationDate>>(dateEntities);

            foreach (var date in dates)
            {
                repository.ReservationDate.CreateDate(date);
                await repository.SaveAsync();
            }
        }

        public async Task<IEnumerable<ReservationDateForCreationDto>?> 
            CreateDateEntitiesCollectionForApartmentAsync(IRepositoryManager repository, 
            Guid apartId, IEnumerable<DateTime> dateRange, bool trackChanges)
        {
            var apart = await repository.Apartment
                .GetApartmentByIdAsync(apartId, trackChanges);
            if (apart is null)
                return null;

            var existingDates = await repository.ReservationDate
                .GetDatesForApartmentAsync(apartId, trackChanges);
            var dates = dateRange.Except(existingDates.Select(d => d.Date))
                .Select(d => new ReservationDateForCreationDto { Date = d, ApartmentId = apartId });

            return dates;
        }

        private IEnumerable<DateTime> GenerateDates(DateTime start, DateTime end)
        {
            var startDate = start.AddDays(1 - start.Day).Date;
            var endDate = end.AddMonths(1).AddDays(1 - end.Day).Date;
            var dateSub = endDate.Subtract(startDate);
            var days = dateSub.TotalDays;
            var range = Enumerable.Range(0, (int)days)
                .Select(x => startDate.AddDays(1.0 * x).Date);

            return range;
        }
    }
}
