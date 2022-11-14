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
    public double Length()
    {
        return Math.Sqrt(Math.Pow((this.End.X - this.Start.X), 2) + Math.Pow((this.End.Y - this.Start.Y), 2));
    }
    public override string ToString()
    {
       
        return $"Прямая линия из точки {this.Start} в точку {this.End}";
    }
}