using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
    }
}
