namespace wonders
{
    internal class Colossus_Of_Rhodes
    {
        private readonly string name = "Колосс Родосский";
        private readonly string location = "Родос";
        private readonly string age = "между 292г и 280г до н.э.";

        public void show()
        {
            Console.WriteLine($"{this.name}, {this.location} - {this.age}");
        }
    }
}