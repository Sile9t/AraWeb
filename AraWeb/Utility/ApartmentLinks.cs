using Contracts.Links;
using Entities.LinkModels;
using Entities.Models;
using Microsoft.Net.Http.Headers;
using Service.Contracts;
using Shared.Dtos;

namespace AraWeb.Utility
{
    public class ApartmentLinks : IApartmentLinks
    {
        private readonly LinkGenerator _linkGenerator;
        private readonly IDataShaper<ApartmentDto> _dataShaper;

        public ApartmentLinks(LinkGenerator linkGenerator, IDataShaper<ApartmentDto> dataShaper)
        {
            _linkGenerator = linkGenerator;
            _dataShaper = dataShaper;
        }

        public LinkResponse TryGenerateLinks(IEnumerable<ApartmentDto> apartmentsDto, 
            string fields, HttpContext httpContext)
        {
            var shapedApartments = ShapeData(apartmentsDto, fields);

            if (ShouldGenerateLinks(httpContext))
                return ReturnLinkedApartments(apartmentsDto, fields, httpContext, shapedApartments);

            return ReturnShapedApartments(shapedApartments);
        }

        private List<Entity> ShapeData(IEnumerable<ApartmentDto> apartmentsDto, string fields) =>
            _dataShaper.ShapeData(apartmentsDto, fields)
                .Select(e => e.Entity)
                .ToList();

        private bool ShouldGenerateLinks(HttpContext httpContext)
        {
            var mediaType = (MediaTypeHeaderValue)httpContext.Items["AcceptHeaderMeadiaType"];

            return mediaType.SubTypeWithoutSuffix.EndsWith("hateoas",
                StringComparison.InvariantCultureIgnoreCase);
        }

        private LinkResponse ReturnShapedApartments(List<Entity> shapedApartments) =>
            new LinkResponse { ShapedEntities = shapedApartments };

        private LinkResponse ReturnLinkedApartments(IEnumerable<ApartmentDto> apartmentsDto,
            string fields, HttpContext httpContext, List<Entity> shapedApartments)
        {
            var apartmentDtoList = apartmentsDto.ToList();

            for (var index = 0; index < apartmentDtoList.Count; index++)
            {
                var apartmentLinks = CreateLinksForApartment(httpContext,
                    apartmentDtoList[index].Id, fields);
                shapedApartments[index].Add("Links", apartmentLinks);
            }

            var apartmentCollection = new LinkCollectionWrapper<Entity>(shapedApartments);
            var linkedApartments = CreateLinksForApartments(httpContext, apartmentCollection);

            return new LinkResponse { HasLinks = true, LinkedEntities = linkedApartments };
        }

        private List<Link> CreateLinksForApartment(HttpContext httpContext, Guid id, string fields = "")
        {
            var links = new List<Link>
            {
                new Link(_linkGenerator.GetUriByAction(httpContext, "GetApartment",
                values: new {id, fields}),
                "self",
                "GET"),
                new Link(_linkGenerator.GetUriByAction(httpContext, "DeleteApartment",
                values: new {id}),
                "delete_apartment",
                "DELETE"),
                new Link(_linkGenerator.GetUriByAction(httpContext, "UpdateApartment",
                values: new {id}),
                "update_apartment",
                "PUT"),
                new Link(_linkGenerator.GetUriByAction(httpContext, "PartiallyUpdateApartment",
                values: new {id}),
                "partially_update_apartment",
                "PATCH")
            };

            return links;
        }

        private LinkCollectionWrapper<Entity> CreateLinksForApartments(HttpContext httpContext,
            LinkCollectionWrapper<Entity> apartmentsWrapper)
        {
            apartmentsWrapper.Links.Add(new Link(_linkGenerator.GetUriByAction(httpContext, "GetApartments",
                values: new { }),
                "self",
                "GET"));

            return apartmentsWrapper;
        }
    }
}
