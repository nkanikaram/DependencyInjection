using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.IServices
{
    public interface IStringHelper
    {
        bool IsPalindrome(string str);
        string Reverse(string str);
    }
}
