using Microsoft.AspNetCore.Http;
using Shared.RequestFeatures;

namespace Entities.LinkModels
{
    public record LinkParameters
    {
        ApartmentParameters ApartmentParameters { get; init; }
        HttpContext HttpContext { get; init; }
    }
}
