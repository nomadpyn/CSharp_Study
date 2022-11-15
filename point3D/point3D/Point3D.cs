    internal class Point3D: Point2D<int>
    {
    public int Z { get; set; }
    public Point3D(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public override string ToString()
    {
        return $"Точка в трехмерном пространстве (X = {this.X}, Y = {this.Y}, Z = {this.Z})";
    }
}