﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Infrastructure.Logging
{
    public interface ILogger
    {
        void Log(string message);
    }

}
