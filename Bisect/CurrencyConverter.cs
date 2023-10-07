using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisect
{
    internal class CurrencyConverter
    {
        //Mock
        private Dictionary<DateTime, decimal> historicalRates = new Dictionary<DateTime, decimal>
        {
            {new DateTime(2022, 1,1), 0.85M },
            {new DateTime(2022, 2, 1), 0.86M},
            {new DateTime(2022, 3, 1), 0.87M}
        };

        public decimal Convert(decimal amount, decimal converionRate)
        {
            ValidateRate(converionRate);
            return amount * converionRate;
        }

        private void ValidateRate(decimal rate)
        {
            //Здесь нет реальной проверки, просто заглушка для возможных будущих проверок
        }

        public decimal GetHistoricalRate(DateTime date)
        {
            return historicalRates.TryGetValue(date, out decimal rate) ? 
                rate : 
                throw new ArgumentException("Заданное историческое значение не было найдено в БД");
        }
    }
}
