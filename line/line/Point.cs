    internal class Point<T> where T: struct
    {
    public T X { get; set; }
    public T Y { get; set; }

    public Point (T x, T y)
    {
        this.X = x;
        this.Y = y;
    }

    public override string ToString()
    {
        return $"Точка X = {this.X}, Y = {this.Y}";
    }
}
