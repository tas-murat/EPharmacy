using System;
using System.Collections.Generic;
using System.Text;
using EPharmacy.Core.Utilities.Results.Abstract;

namespace EPharmacy.Core.Utilities.Results.Concrete
{
    public class ErrorResult:Result
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult(string message) : base(false, message)
        {
        }
    }
}
