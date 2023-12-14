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

            string goal = "hello";
            Console.WriteLine(goal.ToUpper());

            string stick = " HELLO";
            Console.WriteLine(stick.ToLower());

            string user = "";
            Console.WriteLine(string.IsNullOrEmpty(user));

            string pwd = "";
            Console.WriteLine(string.IsNullOrWhiteSpace(pwd));

            string super = "set123";
            Console.WriteLine(super.Substring(1, 4));


            Console.WriteLine(stick.Trim());



        }
    }
}
