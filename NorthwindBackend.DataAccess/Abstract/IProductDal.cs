using Core.DataAccess;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
