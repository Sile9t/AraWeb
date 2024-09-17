using AutoMapper;
using Contracts;
using Contracts.Links;
using Entities.Exceptions;
using Entities.LinkModels;
using Entities.Models;
using Service.Contracts;
using Shared.Dtos;
using Shared.RequestFeatures;

namespace Service
{
    internal class ApartmentService : IApartmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IApartmentLinks _apartmentLinks;

        public ApartmentService(IRepositoryManager repository, ILoggerManager logger,
            IMapper mapper, IApartmentLinks apartmentLinks)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _apartmentLinks = apartmentLinks;
        }

        public async Task<(LinkResponse apartments, MetaData metaData)> GetAllApartmentsAsync(
            LinkParameters linkParameters, bool trackChanges)
        {
            var apartmentsWithMetaData = await _repository.Apartment.GetAllApartmentsAsync(
                linkParameters.ApartmentParameters, trackChanges);
            
            var apartmentsDto = _mapper.Map<IEnumerable<ApartmentDto>>(apartmentsWithMetaData);
            var links = _apartmentLinks.TryGenerateLinks(apartmentsDto,
                linkParameters.ApartmentParameters.Fields!, linkParameters.HttpContext);
            return (apartments: links, metaData: apartmentsWithMetaData.MetaData);
        }

        public async Task<IEnumerable<ApartmentDto>> GetApartmentsByIdsAsync(IEnumerable<Guid> ids, 
            bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var apartEntities = await _repository.Apartment.GetApartmentsByIdsAsync(ids, trackChanges);
            if (apartEntities.Count() != ids.Count())
                throw new CollectionByIdsBadRequestException();

            var apartsToReturn = _mapper.Map<IEnumerable<ApartmentDto>>(apartEntities);

            return apartsToReturn;
        }

        public async Task<IEnumerable<ApartmentDto>> GetApartmentsForOwnerAsync(Guid ownerId, bool trackChanges)
        {
            var apartments = await _repository.Apartment.GetApartmentsForOwnerAsync(ownerId, trackChanges);

            var apartmentsDto = _mapper.Map<IEnumerable<ApartmentDto>>(apartments);
            return apartmentsDto;
        }

        public async Task<ApartmentDto> GetApartmentByIdAsync(Guid id, bool trackChanges)
        {
            var apartment = await _repository.Apartment.GetApartmentByIdAsync(id, trackChanges);
            if (apartment is null)
                throw new ApartmentNotFoundException(id);

            var apartmentDto = _mapper.Map<ApartmentDto>(apartment);
            return apartmentDto;
        }

        public async Task<ApartmentDto> CreateApartmentForUserAsync(Guid userId, 
            ApartmentForCreationDto apartment, bool trackChanges)
        {
            var user = _repository.User.GetUserByIdAsync(userId, trackChanges);
            if (user is null)
                throw new UserNotFoundException(userId);

            var apartEntity = _mapper.Map<Apartment>(apartment);

            _repository.Apartment.CreateApartment(apartEntity);
            await _repository.SaveAsync();

            var apartToReturn = _mapper.Map<ApartmentDto>(apartEntity);

            return apartToReturn;
        }

        public async Task<(IEnumerable<ApartmentDto> apartments, string ids)> 
            CreateApartmentCollectionAsync(IEnumerable<ApartmentForCreationDto> apartmentCollection)
        {
            if (apartmentCollection is null)
                throw new ApartmentCollectionBadRequestException();

            var apartEntities = _mapper.Map<IEnumerable<Apartment>>(apartmentCollection);
            foreach (var apart in apartEntities)
                _repository.Apartment.CreateApartment(apart);

            await _repository.SaveAsync();

            var apartCollectionToReturn = _mapper.Map<IEnumerable<ApartmentDto>>(apartEntities);
            var ids = string.Join(",", apartCollectionToReturn.Select(x => x.Id));

            return (apartCollectionToReturn, ids);
        }

        public async Task DeleteApartmentAsync(Guid id, bool trackChanges)
        {
            var apartment = await _repository.Apartment.GetApartmentByIdAsync(id, trackChanges);
            if (apartment is null)
                throw new ApartmentNotFoundException(id);

            _repository.Apartment.DeleteApartment(apartment);
            await _repository.SaveAsync();
        }

        public async Task UpdateApartmentAsync(Guid id, ApartmentForUpdateDto apartmentForUpdate, 
            bool apartTrackChanges)
        {
            var apartment = await _repository.Apartment.GetApartmentByIdAsync(id, apartTrackChanges);
            if (apartment is null)
                throw new ApartmentNotFoundException(id);

            _mapper.Map(apartmentForUpdate, apartment);
            await _repository.SaveAsync();
        }

        public async Task<(ApartmentForUpdateDto apartmentToPatch, Apartment apartmentEntity)> 
            GetApartmentForPatchAsync(Guid id, bool trackChanges)
        {
            var apartmentEntity = await _repository.Apartment.GetApartmentByIdAsync(id, trackChanges);
            if (apartmentEntity is null)
                throw new ApartmentNotFoundException(id);

            var apartmentToPatch = _mapper.Map<ApartmentForUpdateDto>(apartmentEntity);

            return (apartmentToPatch, apartmentEntity);
        }

        public async Task SaveChangesForPatchAsync(ApartmentForUpdateDto apartmentToPatch, 
            Apartment apartmentEntity)
        {
            _mapper.Map(apartmentToPatch, apartmentEntity);
            await _repository.SaveAsync();
        }
    }
}
