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

            Console.WriteLine("Please enter the  Special Character ");
            string specialcharacter = Console.ReadLine();
            bool val1 = user.Special Character(specialcharacter);
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
