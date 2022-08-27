using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Pattern
    {
        public static string REGEX_PINCODE = "[1-9] {1} [0-9] {2} [' ']?[0-9] {3}";


        public bool validatePincode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}
