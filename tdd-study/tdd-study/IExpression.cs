using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public interface IExpression
    {
        Money Reduce(String to);
    }
}
