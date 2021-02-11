using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Sum : IExpression
    {
        public Money Augend;
        public Money Addend;

        public Sum(Money augend, Money addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(String to)
        {
            int amount = Augend.amount + Addend.amount;
            return new Money(amount, to);
        }
    }
}
