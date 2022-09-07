namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the PasswordRules ");
            string password = Console.ReadLine();

            UserRegi user = new UserRegi();
            bool val1 = PasswordRules(password);

            if (val1)
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
