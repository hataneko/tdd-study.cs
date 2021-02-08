using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_study
{
    public class Dollar
    {
        private int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public void Times(int multiplier)
        {
            _amount *= multiplier;
        }
    }
}
