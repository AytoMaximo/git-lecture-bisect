using Bisect;

class Program
{
    //bisect
    static void Main()
    {
        CurrencyConverter converter= new CurrencyConverter();
        decimal convertedAmount = converter.Convert(100, 0.85M);
        Console.WriteLine(convertedAmount.ToString());
    }
}