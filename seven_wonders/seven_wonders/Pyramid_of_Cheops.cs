namespace wonders
{
    internal class Pyramid_of_Cheops
    {
        private readonly string name = "Пирамида Хеопса";
        private readonly string location = "Гиза";
        private readonly string age = "2550г. до н.э.";

        public void show()
        {
            Console.WriteLine($"{this.name}, {this.location} - {this.age}");
        }
    }
}