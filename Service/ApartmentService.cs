using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.Dtos;

namespace Service
{
    internal class ApartmentService : IApartmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ApartmentService(IRepositoryManager repository, ILoggerManager logger,
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ApartmentDto> GetAllApartments(bool trackChanges)
        {
            var apartments = _repository.Apartment.GetAllApartments(trackChanges);
            if (apartments is null)
                throw new Exception();

            var apartmentsDto = _mapper.Map<ApartmentDto>(apartments);

            return apartmentsDto;
        }
    }
}
