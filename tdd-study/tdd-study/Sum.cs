namespace tdd_study
{
    public class Sum : IExpression
    {
        public IExpression Augend;
        public IExpression Addend;

        public Sum(IExpression augend, IExpression addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Reduce(bank, to).amount + Addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return null;
        }
    }
}
