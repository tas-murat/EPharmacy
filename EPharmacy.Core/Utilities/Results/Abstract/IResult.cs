﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EPharmacy.Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
}
}
