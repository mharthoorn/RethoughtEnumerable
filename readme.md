## RethoughtEnumerable

This small program is a re-implementation of IEnumerable<T>.
It's an idea from Matthew Warren. 
http://blog.paranoidcoding.com/2014/08/19/rethinking-enumerable.html

And I believe it's a very sensible and worthwile attempt as it reduces enumeration calls by 50%.

As example a small StringList class implements ```List<string>``` and the alternative IEnumerable<T>

Matthew actually introduces a IEnumerable<T, E> where the Enumerator is now a simple struct (or class) 
of choice. The drawback of it is that implementers would have to implement their IEnumerables with two 
generic type parameters. For that I derived an ```IEnumerable<T, int>``` as a default implementation.

Since ```foreach( )``` will not work on this IEnumerable, there is a method Foreach that will immitate ```foreach( )```.

