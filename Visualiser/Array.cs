namespace Visualiser;

public class Array<T>
{
    private readonly T[] _internalArray;

    public T this[int index]
    {
        get => _internalArray[index];
        set
        {

        }
    }

    public Array(T[] array)
    {
        _internalArray = array;
    }
}
