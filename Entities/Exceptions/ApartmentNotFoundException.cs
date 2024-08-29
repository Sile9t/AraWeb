namespace Entities.Exceptions
{
    public class ApartmentNotFoundException : NotFoundException
    {
        public ApartmentNotFoundException(Guid id)
            : base($"Apartment with id: {id} doesn't exist in the database.")
        {
        }
    }
}
