namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Mobile Format ");
            string Mobile = Console.ReadLine();

            UserRegi user = new UserRegi();
            bool val = user. Mobile Format(Mobile);

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
