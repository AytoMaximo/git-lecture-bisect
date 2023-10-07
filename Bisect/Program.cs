using Bisect;

class Program
{
    //bisect
    static void Main()
    {
        CurrencyConverter converter= new CurrencyConverter();

        try
        {
            var convertedAmount = converter.Convert(100, 0.005M);
            Console.WriteLine(convertedAmount);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        //decimal convertedAmount = converter.Convert(100, 0.85M);
        //Console.WriteLine(convertedAmount.ToString());
    }
}