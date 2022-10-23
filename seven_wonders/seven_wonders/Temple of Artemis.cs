namespace wonders
{
    internal class Temple_Of_Artemis
    {
        private readonly string name = "Храм Артемиды Эфесской";
        private readonly string location = "Эфес";
        private readonly string age = "550 г. до н. э.";

        public void show()
        {
            Console.WriteLine($"{this.name}, {this.location} - {this.age}");
        }
    }
}