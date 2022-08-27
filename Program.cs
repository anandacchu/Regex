namespace RegexDemo

{
    class program
    {
        public static void Main(string[] args)         
        {
            Console.WriteLine("Please enter the pincode");
            string code = Console.ReadLine();

           Pattern pattern = new Pattern();
           bool val = pattern.validatePincode(code);

            if(val)
            {
                Console.WriteLine("Matched");

            }
            else
            {
                Console.WriteLine("Not Matched");
            }
        }
    }
}




