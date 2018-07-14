using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicencePCL.Extentions
{
    public static class C_IEnumerableExtentions
    {
        public static TSource RandomElementInList<TSource>(this List<TSource> list, Random random)
        {
            return list[random.Next(0, list.Count)];
        }
    }
}
