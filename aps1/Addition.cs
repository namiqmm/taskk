﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps1
{
     internal sealed class Addition : Calculation
    {
        internal override int Operate(int number1, int number2)
        {
            return number1 + number2;   
        }
    }
}
