﻿using Microsoft.AspNetCore.Http;
using Shared.RequestFeatures;

namespace Entities.LinkModels
{
    public record LinkParameters(ApartmentParameters ApartmentParameters, HttpContext HttpContext);
}
