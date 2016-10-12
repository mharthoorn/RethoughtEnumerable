using System;

namespace RethoughtEnumerable
{

    public static class Iteration
    {
        public static void Foreach<T, C>(this IEnumerable<T, C> enumerable, Action<T> action)
        {
            var enumerator = enumerable.GetEnumerator();
            while (enumerable.TryGetNext(ref enumerator, out T value))
            {
                action(value);
            }
        }
    }
}
