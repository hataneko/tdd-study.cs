using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Money : IExpression
    {
        protected internal int amount;
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

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return this.amount == money.amount && this.currency.Equals(money.currency);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(this.currency, to);
            return new Money(amount / rate, to);
        }

    }
}
