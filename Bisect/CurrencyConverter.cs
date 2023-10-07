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
            ValidateRate(converionRate);
            return amount * converionRate;
        }

        private void ValidateRate(decimal rate)
        {
            //Здесь нет реальной проверки, просто заглушка для возможных будущих проверок
        }
    }
}
