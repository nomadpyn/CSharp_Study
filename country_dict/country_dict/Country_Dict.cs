using System.Diagnostics;

internal class Country_Dict
{
    Dictionary<string, string> dict;

    public Country_Dict()
    {
        dict = new Dictionary<string, string>
        {
            ["China"] = "Китай",
            ["India"] = "Индия",
            ["USA"] = "США",
            ["Indonesia"] = "Индонезия",
            ["Pakistan"] = "Пакистан",
            ["Brazil"] = "Бразилия",
            ["Nigeria"] = "Нигерия",
            ["Bangladesh"] = "Бангладеш",
            ["Russia"] = "Россия",
            ["Mexico"] = "Мексика"
        };
    }
    public void showEngRus()
    {
        Console.WriteLine("In dictionary {0} words", this.dict.Count);
        foreach(KeyValuePair<string,string> i in this.dict.OrderBy(key => key.Key))
        {
            Console.WriteLine($"Eng: {i.Key}\tRus: {i.Value}");
        }
        Console.WriteLine();
    }
    public void showRusEng()
    {
        Console.WriteLine("В словаре {0} слов", this.dict.Count);
        foreach (KeyValuePair<string, string> i in this.dict.OrderBy(key => key.Value))
        {
            Console.WriteLine($"Rus: {i.Value}\tEng: {i.Key}");
        }
        Console.WriteLine();
    }
    public void searchEngRus()
    {
        Console.WriteLine("Enter name of country to search");
        string search = Console.ReadLine();
        if (dict.ContainsKey(search))
        {
            dict.TryGetValue(search, out string result);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No country in dictionary");
        }
    }
    public void searchRusEng()
    {
        Console.WriteLine("Введите название страны");
        string search = Console.ReadLine();
        if (dict.ContainsValue(search))
        {
            string myKey = dict.FirstOrDefault(x => x.Value == search).Key;
            Console.WriteLine(myKey);
        }
        else
        {
            Console.WriteLine("Такой страны нет в словаре");
        }
    }
}