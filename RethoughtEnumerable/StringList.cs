using System.Collections.Generic;

namespace RethoughtEnumerable
{

    public class StringList : List<string>, IEnumerable<string>
    {
        new public int GetEnumerator()
        {
            return 0;
        }

        public bool TryGetNext(ref int cursor, out string value)
        {
            if (cursor <= this.Count - 1)
            {
                value = this[cursor];
                cursor++;
                return true;
            }
            else
            {
                value = null;
                return false;
            }
        }
    }
}
