namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter password:  ");
            string pwd = Console.ReadLine();

            bool val = user.Password(pwd);
            if (val)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched, there must be 8 characters and at least 1 uppercase, 1 digit in character.");
            }
        }
    }
}
