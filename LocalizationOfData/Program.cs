using System.Globalization;

namespace LocalizationOfData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ro-RO");
            // Thread.CurrentThread.CurrentCulture = new CultureInfo("fa");

            Console.Write("Please enter date=");
            string input = Console.ReadLine();

            DateTime inputDate =  Convert.ToDateTime(input, CultureInfo.CurrentCulture);
            Console.WriteLine(inputDate);

            DateTime date = new DateTime(2023, 11, 7);
            Console.WriteLine(date);

            decimal discount = -100;
            Console.WriteLine(discount.ToString("C"));
        }
    }
}