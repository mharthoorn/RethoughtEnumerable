namespace RethoughtEnumerable
{

    public interface IEnumerable<T, E>
    {
        E GetEnumerator();
        bool TryGetNext(ref E enumerator, out T value);
    }
}
