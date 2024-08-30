using Entities.LinkModels;
using Microsoft.AspNetCore.Http;
using Shared.Dtos;

namespace Contracts.Links
{
    public interface IApartmentLinks
    {
        LinkResponse TryGenerateLinks(IEnumerable<ApartmentDto> apartmentsDto,
            string fields, HttpContext httpContext);
    }
}
