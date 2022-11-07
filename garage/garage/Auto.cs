internal class Auto
{
    public string? name;
    public string? color;
    public int max_speed;
   
    public Auto(string nameP, string colorP, int max_speedP)
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

