using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }

    }
}
