internal class NameComparer : IComparer<Auto>
{
    public int Compare(Auto? a1, Auto? a2)
    {
        if (a1 is null || a2 is null)
            throw new ArgumentException("Некорректное значение параметра");
        return a1.name.CompareTo(a2.name);
    }
}