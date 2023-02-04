using System;
using System.Collections.Generic;
using System.Text;
using EPharmacy.Core.Utilities.Results.Abstract;

namespace EPharmacy.Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data) : base(data, true)
        {
        }

        public SuccessDataResult(T data,  string message) : base(data, true, message)
        {
        }
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        public SuccessDataResult(): base(default, true)
        {

        }
    }
}
