using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Converter_class
    {
    }
}
public class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usdRate;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eurRate;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / plnRate;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * usdRate;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * eurRate;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * plnRate;
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(27.50, 32.10, 7.30);

        double usdAmount = converter.ConvertToUSD(1000);
        Console.WriteLine("1000 UAH is equal to " + usdAmount + " USD");

        double uahAmount = converter.ConvertFromEUR(500);
        Console.WriteLine("500 EUR is equal to " + uahAmount + " UAH");

        double eurAmount = converter.ConvertToEUR(1000);
        Console.WriteLine("1000 UAH is equal to " + eurAmount + " EUR");

        double plnAmount = converter.ConvertToPLN(1000);
        Console.WriteLine("1000 UAH is equal to " + plnAmount + " PLN");

        Console.ReadLine();
    }
}