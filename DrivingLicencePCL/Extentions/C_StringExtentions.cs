using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicencePCL.Extentions
{
    public static class C_StringExtentions
    {
        public static IEnumerable<string> TakeSubstringsByEncolsingChar(this string input, char separator)
        {
            for (int x1 = input.IndexOf(separator, 0), x2 = input.IndexOf(separator, x1 + 1); x1 != -1 && x2 != -1; x1 = input.IndexOf(separator, x1), x2 = input.IndexOf(separator, x1 + 1))
            {
                yield return input.Substring(x1 + 1, x2 - x1 - 1);

                x1 = x2 + 1;
            }
        }
    }
}
