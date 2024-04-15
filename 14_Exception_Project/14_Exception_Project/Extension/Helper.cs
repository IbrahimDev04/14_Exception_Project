using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exception_Project.Extension
{
    internal static class Helper
    {
        public static string ToCapitalize(this string name)
        {
            return String.Concat(name.Substring(0,1).ToUpper(),name.Substring(1).ToLower());
        }
    }
}
