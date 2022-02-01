using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Length>0)
            {
                char[] charArry = inputString.ToCharArray();
                charArry[0] = char.IsUpper(charArry[0]) ? 
                    char.ToLower(charArry[0]) : char.ToUpper(charArry[0]);

                return new string(charArry);
            }
            return inputString;
        }
    }
}
