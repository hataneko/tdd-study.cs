namespace tdd_study
{
    public class Pair
    {
        private readonly string from;
        private readonly string to;
        
        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair)obj;
            return this.from.Equals(pair.from) && this.to.Equals(pair.to);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
