﻿namespace Entities.Exceptions
{
    public sealed class IdParametersBadRequestException : BadRequestException
    {
        public IdParametersBadRequestException()
            : base("Parameter ids is null.")
        {
        }
    }

    public sealed class CollectionByIdsBadRequestException : BadRequestException
    {
        public CollectionByIdsBadRequestException()
            : base("Collection count mismatch comparing to ids.")
        {
        }
    }

    public sealed class ApartmentCollectionBadRequestException : BadRequestException
    {
        public ApartmentCollectionBadRequestException()
            : base("Apartment collection sent from client is null.")
        {
        }
    }
}
