using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Delegates
{

    public static class CollectionsExtensions
    {
        public static T GetMax<T>(this IEnumerable items, Func<T, float> getParameter) where T : class
        {
            float max = float.MinValue;
            T maxItem = null;
            foreach (T item in items)
            {
                if (getParameter(item) > max)
                {
                    max = getParameter(item);
                    maxItem = item;

                }

            }
            return maxItem;

        }
        public static float GetParametr<T>(T value)
        {
            return (float)Convert.ChangeType(value, typeof(float)); ;
        }


    }
}
