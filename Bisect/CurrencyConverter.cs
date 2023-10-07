using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisect
{
    internal class CurrencyConverter
    {
        public decimal Convert(decimal amount, decimal converionRate)
        {
            return amount * converionRate;
        }
    }
}
