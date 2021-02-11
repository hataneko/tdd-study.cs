using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Money : IExpression
    {
        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(this.amount * multiplier, currency);
        }

        public string Currency()
        {
            return this.currency;
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return this.amount == money.amount && this.currency.Equals(money.currency);
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override string ToString()
        {
            return amount.ToString() + " " + currency;
        }

        public IExpression Plus(Money addend)
        {
            return new Money(amount + addend.amount, currency);
        }
    }
}
