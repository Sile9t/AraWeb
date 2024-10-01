using AutoMapper;
using Contracts;
using Contracts.Links;
using Contracts.Repositories;
using Entities.Exceptions;
using Entities.LinkModels;
using Service.Contracts.Services;
using Shared.Dtos;
using Shared.RequestFeatures;

namespace Service.Services
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

        public async Task<IEnumerable<UserDto>> GetUsersByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var users = await _repository.User.GetUsersByIdsAsync(ids, trackChanges);
            if (!ids.Count().Equals(users.Count()))
                throw new CollectionByIdsBadRequestException();

            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);

            return userDtos;
        }

        public async Task DeleteUserAsync(Guid id, bool trackChanges)
        {
            var user = await _repository.User.GetUserByIdAsync(id, trackChanges);
            if (user is null)
                throw new UserNotFoundException(id);

            _repository.User.DeleteUser(user);
            await _repository.SaveAsync();
        }

        public async Task UpdateUserAsync(Guid id, UserForUpdateDto userForUpdate, bool trackChanges)
        {
            var user = await _repository.User.GetUserByIdAsync(id, trackChanges);
            if (user is null)
                throw new UserNotFoundException(id);

            _mapper.Map(userForUpdate, user);
            await _repository.SaveAsync();
        }
    }
}
