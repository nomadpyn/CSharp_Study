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
}