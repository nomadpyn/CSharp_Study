internal class ColorComparer : IComparer<Auto>
{
    public int Compare(Auto? a1, Auto? a2)
    {
        if (a1 is null || a2 is null)
            throw new ArgumentException("Некорректное значение параметра");
        return a1.color.CompareTo(a2.color);
    }
}