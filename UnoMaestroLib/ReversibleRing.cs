namespace UnoMaestroLib;

public class ReversibleRing<T>
{
    private readonly IList<T> _elements;
    private Direction _direction = Direction.Clockwise;
    private int _index = -1;

    public ReversibleRing() : this(new T[] { })
    {
    }

    public ReversibleRing(IEnumerable<T> enumerable)
    {
        _elements = enumerable.ToList();
    }

    private void AdjustIndex(int step)
    {
        var length = _elements.Count();
        _index += step;
        _index %= length;
        if (_index < 0) _index += length;
    }

    public T Next()
    {
        return _elements[_index];
    }

    public void Skip()
    {
        AdjustIndex((int)_direction);
    }

    public void Reverse()
    {
        if (_direction is Direction.Clockwise)
        {
            _direction = Direction.CounterClockwise;
            return;
        }

        _direction = Direction.Clockwise;
    }
}