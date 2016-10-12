using System;

namespace RethoughtEnumerable
{

    class Program
    {
        static void Main(string[] args)
        {
            // this StringList implements Matthew Warrens rethought IEnumerable 
            // http://blog.paranoidcoding.com/2014/08/19/rethinking-enumerable.html

            var list = new StringList { "Foo", "Bar", "Fizz", "Buzz" };
            list.Foreach(s =>
                Console.WriteLine(s)
            );
            Console.ReadKey();
        }
    }
}
