using Entities.Models;
using Repository.Utility;
using Shared.RequestFeatures;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace Repository
{
    public static class ApartmentRepositoryExtensions
    {
        public static IQueryable<Apartment> Filter(this IQueryable<Apartment> apartment,
            ApartmentParameters parameters) =>
            apartment.FilterBySquare(parameters.MinSquare, parameters.MaxSquare)
                .FilterByGuestsCount(parameters.MinGuestsCount, parameters.MaxGuestsCount)
                .FilterByBedsCount(parameters.MinBedsCount, parameters.MaxBedsCount)
                .FilterByRoomsCount(parameters.MinRoomsCount, parameters.MaxRoomsCount)
                .FilterByRate(parameters.MinRate, parameters.MaxRate)
                .FilterByReviewsCount(parameters.MinReviewsCount, parameters.MaxReviewsCount);

        public static IQueryable<Apartment> FilterBySquare(this IQueryable<Apartment> apartments,
            double minSquare, double maxSquare) =>
            apartments.Where(a => (a.Square >= minSquare && a.Square <= maxSquare));

        public static IQueryable<Apartment> FilterByGuestsCount(this IQueryable<Apartment> apartments,
            uint minGuestsCount, uint maxGuestsCount) =>
            apartments.Where(a => (a.GuestsCount >= minGuestsCount && a.GuestsCount <= maxGuestsCount));

        public static IQueryable<Apartment> FilterByBedsCount(this IQueryable<Apartment> apartments,
            uint minBedsCount, uint maxBedsCount) =>
            apartments.Where(a => (a.BedsCount >= minBedsCount && a.BedsCount <= maxBedsCount));

        public static IQueryable<Apartment> FilterByRoomsCount(this IQueryable<Apartment> apartments,
            uint minRoomsCount, uint maxRoomsCount) =>
            apartments.Where(a => (a.RoomsCount >= minRoomsCount && a.RoomsCount<= maxRoomsCount));

        public static IQueryable<Apartment> FilterByRate(this IQueryable<Apartment> apartments,
            double minRate, double maxRate) =>
            apartments.Where(a => (a.Rate >= minRate && a.Rate <= maxRate));

        public static IQueryable<Apartment> FilterByReviewsCount(this IQueryable<Apartment> apartments,
            long minReviewsCount, long maxReviewsCount) =>
            apartments.Where(a => (a.ReviewsCount >= minReviewsCount && a.ReviewsCount<= maxReviewsCount));

        public static IQueryable<Apartment> Search(this IQueryable<Apartment> apartments,
            string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return apartments;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return apartments.Where(a => a.Name.ToLower().Contains(lowerCaseTerm)
                && a.Address.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<Apartment> Sort(this IQueryable<Apartment> apartments, 
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return apartments;

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Apartment>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
                return apartments.OrderBy(a => a.Rate)
                    .ThenBy(a => a.ReviewsCount);

            return apartments.OrderBy(orderQuery);
        }
    }
}
