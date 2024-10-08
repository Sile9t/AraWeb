﻿using Contracts.Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;
using System.Linq;

namespace Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public async Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            var users = await FindAll(trackChanges)
                .ToListAsync();

            var count = users.Count();

            var usersForPage = await FindAll(trackChanges)
                .OrderBy(a => a.UserName)
                .Paginate(userParameters)
                .ToListAsync();

            return new PagedList<User>(usersForPage, count, userParameters.PageNumber,
                userParameters.PageSize);
        }

        public async Task<IEnumerable<User>> GetUsersByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges) =>
            await FindByCondition(u => ids.Contains(u.Id), trackChanges)
                .ToListAsync();

        public async Task<User?> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges) =>
            await FindByCondition(u => u.PhoneNumber!.Equals(phoneNumber), trackChanges)
                .FirstOrDefaultAsync();

        public async Task<User?> GetUserByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(u => u.Id.Equals(id), trackChanges)
                .FirstOrDefaultAsync();

        public void DeleteUser(User user) =>
            Delete(user);

        public void UpdateUser(User user) =>
            Update(user);
    }
}
