using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Dollar
    {
        private int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return this.amount == dollar.amount;
        }
    }
}
