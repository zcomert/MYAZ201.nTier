﻿using System.Collections.Generic;

namespace MYAZ201.nTier.Business.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

        List<IResult> Errors { get; }
    }
}