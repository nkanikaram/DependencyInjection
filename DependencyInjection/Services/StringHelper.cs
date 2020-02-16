using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.IServices;

namespace DependencyInjection.Services
{
    public class StringHelper : IStringHelper
    {
        public bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;
            else
            {
                if (str[0] != str[str.Length - 1])
                    return false;
                else
                    return IsPalindrome(str.Substring(1, str.Length - 2));
            }
        }

        public string Reverse(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + Reverse(str.Substring(0, str.Length - 1));
            else
                return str;
        }
    }
}
