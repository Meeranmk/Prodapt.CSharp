namespace Prodapt.CSharp.Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            Console.WriteLine($"Today : {today}");
            Console.WriteLine($"Date Only:{today.ToShortDateString()}");
            Console.WriteLine($"Date time:{today.ToLongTimeString()}");
            Console.WriteLine($"Month Only:{today.ToLongDateString()}");
            Console.WriteLine("virat");
            Console.WriteLine("sachin");

        }
    }
}
