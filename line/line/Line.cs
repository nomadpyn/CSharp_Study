    internal class Line
    {
    Point Start;
    Point End;
    
        public Line(Point a, Point b)
    {
        this.Start = a;
        this.End = b;
    }
    public Line(int ax,int ay,int bx,int by)
    {
        this.Start = new Point(ax, ay);
        this.End = new Point(bx, by);
    }
    public override string ToString()
    {
       
        return $"Прямая линия из точки {this.Start} в точку {this.End}";
    }
}