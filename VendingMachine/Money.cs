using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Money
    {
        private int totalCash;

        public int TotalCash
        {
            get
            {
                return totalCash;
            }
            set
            {
                totalCash = value;
            }
        }

        public Money(int _totalCash)
        {
            totalCash = _totalCash;
        }

        public Money()
        {
        }
    }
}
