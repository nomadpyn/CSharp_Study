internal class Point2D <T> where T : struct
{ 
    public T X { get; set; }
    public T Y { get; set; }
    public Point2D(T x, T y)
    {
        this.X = x;
        this.Y = y;
    }
    public Point2D()
    {
        X = default(T);
        Y = default(T);
    }
}