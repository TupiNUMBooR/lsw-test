using System.Collections.Generic;

namespace Utils
{
    public static class ArrayUtils
    {
        public static T Random<T>(this IList<T> list)
        {
            if (list.Count == 0) return default;

            var index = UnityEngine.Random.Range(0, list.Count);
            return list[index];
        }
    }
}