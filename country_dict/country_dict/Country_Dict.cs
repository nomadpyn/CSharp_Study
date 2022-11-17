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
        foreach(KeyValuePair<string,string> i in this.dict)
        {
            Console.WriteLine($"Eng: {i.Key}\tRus: {i.Value}");
        }
    }
    public void showRusEng()
    {
        Console.WriteLine("В словаре {0} слов", this.dict.Count);
        foreach (KeyValuePair<string, string> i in this.dict)
        {
            Console.WriteLine($"Rus: {i.Value}\tEng: {i.Key}");
        }
    }
}