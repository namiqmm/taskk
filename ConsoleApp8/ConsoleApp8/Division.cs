﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Division : Calculation
    {
        internal override int Operate(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
