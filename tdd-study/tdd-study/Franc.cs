using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Franc
    {
        private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(this.amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Franc dollar = (Franc)obj;
            return this.amount == dollar.amount;
        }
    }
}
