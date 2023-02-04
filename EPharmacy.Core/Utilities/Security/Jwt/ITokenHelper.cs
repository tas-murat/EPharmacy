using EPharmacy.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPharmacy.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
