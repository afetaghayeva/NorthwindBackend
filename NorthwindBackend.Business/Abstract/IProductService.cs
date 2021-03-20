using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategory(int categoryId);
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);

    }
}
