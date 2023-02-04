using EPharmacy.Core.DataAccess.EntityFramework;
using EPharmacy.Core.Entities;
using EPharmacy.DataAccess.Abstract;
using EPharmacy.DataAccess.Concrete.EntityFramework.Contexts;

namespace EPharmacy.DataAccess.Concrete
{
    public class EFRepositoryDal<T> : EfEntityRepositoryBase<T, PharmacyContext>, IRepositoryDal<T> where T : class, IEntity, new()
    {
    }
}
