using Entities.Models;

namespace Service.Contracts.Additional
{
    public interface IDataShaper<T>
    {
        IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities,
            string fieldsString);
        ShapedEntity ShapeData(T entity, string fieldsString);
    }
}
