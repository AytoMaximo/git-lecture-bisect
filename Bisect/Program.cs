using Bisect;

class Program
{
    //bisect
    static void Main()
    {
        CurrencyConverter converter= new CurrencyConverter();
        //decimal convertedAmount = converter.Convert(100, 0.85M);
        //Console.WriteLine(convertedAmount.ToString());

        DateTime historicalDate = new DateTime(2022, 2, 1);
        decimal historicalRate = converter.GetHistoricalRate(historicalDate);
        decimal convertedAmount = converter.Convert(100, historicalRate);
        Console.WriteLine(convertedAmount.ToString());
    }
}