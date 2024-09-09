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

        public async Task<(IEnumerable<UserDto> users, MetaData metaData)> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            var usersPage = await _repository.User.GetAllUsersAsync(userParameters, 
                trackChanges);

            var usersDto = _mapper.Map<IEnumerable<UserDto>>(usersPage);
            return (users: usersDto, metaData: usersPage.MetaData);
        }

        public async Task<UserDto> GetUserByIdAsync(Guid id, bool trackChanges)
        {
            var user = await _repository.User.GetUserByIdAsync(id.ToString(), trackChanges);
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

        public async Task<IEnumerable<UserDto>> GetUsersByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var idsList = ids.Select(id => id.ToString());

            var users = await _repository.User.GetUsersByIdsAsync(idsList, trackChanges);
            if (!ids.Count().Equals(users.Count()))
                throw new CollectionByIdsBadRequestException();

            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);

            return userDtos;
        }
    }
}
