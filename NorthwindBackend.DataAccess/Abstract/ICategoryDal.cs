using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
