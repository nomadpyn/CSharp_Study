namespace wonders
{
    internal class Alexandrian_Lighthouse
    {
        private readonly string name = "Александрийский маяк ";
        private readonly string location = "Александрия";
        private readonly string age = "III век до н.э.";

        public void show()
        {
            Console.WriteLine($"{this.name}, {this.location} - {this.age}");
        }
    }
}