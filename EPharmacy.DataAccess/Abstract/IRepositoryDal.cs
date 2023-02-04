using EPharmacy.Core.DataAccess;
using EPharmacy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.DataAccess.Abstract
{
    public interface IRepositoryDal<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
    }
}
