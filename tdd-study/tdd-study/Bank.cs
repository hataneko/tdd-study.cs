﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Bank
    {
        public Money Reduce(IExpression source, String to)
        {
            return source.Reduce(to);
        }
    }
}