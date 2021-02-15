using System.Collections.Generic;

namespace tdd_study
{
    public class Bank
    {
        private Dictionary<Pair, int> Rates = new Dictionary<Pair, int>();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            this.Rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            return from.Equals(to) ? 1 : Rates[new Pair(from, to)];
        }
    }
}
