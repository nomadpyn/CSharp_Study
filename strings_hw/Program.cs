
string? data = Console.ReadLine();

string[] strArr = data.Split(". ");

for(int i = 0; i < strArr.Length; i++)
{
    string temp = strArr[i];
    temp = char.ToUpper(temp[0]) + temp.Substring(1);
    strArr[i] = temp;
}

string data_up = String.Join(". ",strArr);

Console.WriteLine(data_up);

Console.WriteLine("Вывод данных на консоль");


