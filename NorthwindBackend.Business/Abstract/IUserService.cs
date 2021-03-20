using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
