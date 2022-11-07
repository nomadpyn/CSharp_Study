internal class Auto
    {
    protected string? name;
    protected string? color;
    protected uint max_speed;
    public Auto(string nameP, string colorP, uint max_speedP)
    {
        this.name = nameP;
        this.color = colorP;
        this.max_speed = max_speedP;
    }
    public override string ToString()
    {
        return $"Авто {this.name} цветом {this.color} с макс скоростью {this.max_speed} км/ч";
    }
}

