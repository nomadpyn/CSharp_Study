    internal class Line<T> where T: struct
    {
    Point<T> Start;
    Point<T> End;
    
        public Line(Point<T> a, Point<T> b)
    {
        this.Start = a;
        this.End = b;
    }
    public Line(T ax,T ay,T bx,T by)
    {
        this.Start = new Point<T>(ax, ay);
        this.End = new Point<T>(bx, by);
    
    }
    public override string ToString()
    {
       
        return $"Прямая линия из точки {this.Start} в точку {this.End}";
    }
}