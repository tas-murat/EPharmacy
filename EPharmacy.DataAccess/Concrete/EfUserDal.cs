﻿using EPharmacy.Core.DataAccess.EntityFramework;
using EPharmacy.Core.Entities.Concrete;
using EPharmacy.DataAccess.Abstract;
using EPharmacy.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, PharmacyContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new PharmacyContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
