internal class Garage
{
    Auto[] arr;

    public Garage(uint amount_cars)
    {
        arr = new Auto[amount_cars];
        for(int i =0; i<arr.Length; i++)
        {
            Console.WriteLine("Введите марку машины, цвет и макс скорость");
            arr[i] = new Auto(Console.ReadLine(), Console.ReadLine(), uint.Parse(Console.ReadLine()));
        }
    }

    public override string ToString()
    {
        string all_garage = "";
        for (int i = 0; i < arr.Length; i++)
        {
            all_garage += arr[i].ToString() + "\n";
        }
        return all_garage;
    }
}
