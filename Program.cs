namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Numeric Numbers ");
            string Numeric = Console.ReadLine();

            UserRegi user = new UserRegi();
            bool val = user.NumericNumbers(Numeric);

            if (val)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched");
            }
        }
    }
}
