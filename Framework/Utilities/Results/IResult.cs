﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; set; }
        string Message { get; set; }    
    }
}
