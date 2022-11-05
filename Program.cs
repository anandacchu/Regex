namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the First Name ");
            //string firstname = Console.ReadLine();


            UserRegi user = new UserRegi();
            //bool val = user.FirstName(firstname);

            //if (val)
            //{
            //    Console.WriteLine("Pattern Matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern Not Matched");
            //}

            Console.WriteLine("Please enter the  Uppercase ");
            string uppercase = Console.ReadLine();
            bool val1 = user.Uppercase(uppercase);
            if (val1)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched,there must be 8 characters and at least 1 uppercase character.");
            }
        }
    }
}
