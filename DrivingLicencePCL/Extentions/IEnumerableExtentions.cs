using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicencePCL.Extentions
{
    public static class IEnumerableExtentions
    {
        public static TSource RandomElement<TSource>(this IEnumerable<TSource> enumerable)
        {
            return enumerable.RandomElementUsing(new Random());
        }

        public static TSource RandomElementUsing<TSource>(this IEnumerable<TSource> enumerable, Random random)
        {
            return enumerable.ElementAt(random.Next(0, enumerable.Count()));
        }
    }
}
