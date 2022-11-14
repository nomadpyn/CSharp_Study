    internal class Point
    {
    public int X { get; set; }
    public int Y { get; set; }
    public override string ToString()
    {
        return $"Точка X = {this.X}, Y = {this.Y}";
    }
}
