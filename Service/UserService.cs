using AutoMapper;
using Contracts;
using Contracts.Links;
using Entities.Exceptions;
using Entities.LinkModels;
using Service.Contracts;
using Shared.Dtos;
using Shared.RequestFeatures;

namespace Service
{
    internal class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repository, ILoggerManager logger,
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<MetaData> GetAllUsersAsync(RequestParameters requestParameters, bool trackChanges)
        {
            var usersPage = await _repository.User.GetAllUsersAsync(requestParameters, 
                trackChanges);

            var apartmentsDto = _mapper.Map<IEnumerable<UserDto>>(usersPage);
            return usersPage.MetaData;
        }

        public async Task<UserDto> GetUserByIdAsync(string id, bool trackChanges)
        {
            var user = await _repository.User.GetUserByIdAsync(id, trackChanges);
            if (user is null)
                throw new UserNotFoundException(id);

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task<UserDto> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges)
        {
            var user = await _repository.User.GetUserByPhoneNumberAsync(phoneNumber, trackChanges);
            if (user is null)
                throw new UserNotFoundException();

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task<IEnumerable<UserDto>> GetUsersByIdsAsync(IEnumerable<string> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var users = await _repository.User.GetUsersByIdsAsync(ids, trackChanges);
            if (!ids.Count().Equals(users.Count()))
                throw new CollectionByIdsBadRequestException();

            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);

            return userDtos;
        }
    }
}
