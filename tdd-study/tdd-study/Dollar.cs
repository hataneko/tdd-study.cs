using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(this.amount * multiplier);
        }
    }
}
