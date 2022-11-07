internal class SpeedComparer : IComparer<Auto>
{
    public int Compare(Auto ? a1,Auto ? a2)
    {
        if(a1 is null || a2 is null)
            throw new ArgumentException("Некорректное значение параметра");
        return a1.max_speed - a2.max_speed;
    }
}