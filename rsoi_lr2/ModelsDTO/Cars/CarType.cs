﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization;

namespace ModelsDTO.Cars
{ 

public enum CarType
{
    [EnumMember(Value = "SEDAN")]
    Sedan = 0,

    [EnumMember(Value = "SUV")]
    Suv = 1,

    [EnumMember(Value = "MINIVAN")]
    Minivan = 2,

    [EnumMember(Value = "ROADSTER")]
    Roadster = 3
}
}