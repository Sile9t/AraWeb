namespace Entities.Exceptions
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message) 
            : base(message) { }
    }

    public sealed class ApartmentNotFoundException : NotFoundException
    {
        public ApartmentNotFoundException(Guid id)
            : base($"Apartment with id: {id} doesn't exist in the database.")
        {
        }
    }

    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException() :
            base($"User doesn't exist in the database.")
        {
        }

        public UserNotFoundException(Guid id) :
            base($"User with id: {id} doesn't exist in the database.")
        {
        }
    }
}
