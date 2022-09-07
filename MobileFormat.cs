using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class MobileFormat
    {
        public static string USER_FIRST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        //public static string USER_LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string USER_MOBILE_FORMAT =  "^([+][0-9]{2}[ ]){0,1}[6-9]{1}[0-9]{9}$";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, USER_FIRST_NAME);
        }
          public bool MobileNumber(string mobileNumb)
        {
            return Regex.IsMatch(mobileNumb, MOBILE_NUMBER);
        }
    }
}
