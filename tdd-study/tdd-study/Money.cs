using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public abstract class Money
    {
        protected int amount;
        public abstract Money Times(int multiplier);
        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return this.amount == money.amount && this.GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
