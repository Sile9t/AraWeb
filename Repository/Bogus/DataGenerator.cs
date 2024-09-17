using Bogus;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Bogus
{
    public static class DataGenerator
    {
        public static readonly List<User> Users = new();
        public static readonly List<Apartment> Apartments = new();

        private const int NumOfUsers = 5;
        private const int ApartsPerUser = 2;

        private static List<Apartment> GetBogusApartData(Guid id)
        {
            var apartGenerator = GetApartmentGenerator(id);
            var generatedAparts = apartGenerator.Generate(ApartsPerUser);
            return generatedAparts;
        }

        public static void InitBogusData()
        {
            var userGenerator = GetUserGenerator();
            var generatedUsers = userGenerator.Generate(NumOfUsers);
            generatedUsers.ForEach(u => Apartments.AddRange(GetBogusApartData(u.Id)));
            Users.AddRange(generatedUsers);
        }

        private static Faker<User> GetUserGenerator() =>
            new Faker<User>()
                .RuleFor(u => u.Id, _ => Guid.NewGuid())
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber());

        private static Faker<Apartment> GetApartmentGenerator(Guid ownerId) =>
            new Faker<Apartment>()
                .RuleFor(a => a.Id, _ => Guid.NewGuid())
                .RuleFor(a => a.Name, f => f.Lorem.Sentence(3))
                .RuleFor(a => a.Address, f => f.Address.FullAddress())
                .RuleFor(a => a.Square, f => Math.Round(f.Random.Double() * 100, 2))
                .RuleFor(a => a.GuestsCount, f => f.Random.Int(1,12))
                .RuleFor(a => a.BedsCount, f => f.Random.Int(1,8))
                .RuleFor(a => a.RoomsCount, f => f.Random.Int(1,4))
                .RuleFor(a => a.Rate, f => Math.Round(f.Random.Double() * 10, 1))
                .RuleFor(a => a.ReviewsCount, f => f.Random.Int(0,100))
                .RuleFor(a => a.OwnerId, _ => ownerId);

        public static List<User> GetSeededUsersFroDb()
        {
            using var dbContext = new RepositoryContext();

            dbContext.Database.EnsureCreated();

            var dbUsers = dbContext.Users.Include(u => u.Apartments).ToList();

            return dbUsers;
        }
    }
}
