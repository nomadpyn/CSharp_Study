namespace wonders
{
    internal class Halicarnassus_Mausoleum
    {
        private readonly string name = "Мавзолей в Галикарнасе";
        private readonly string location = "Галикарнас";
        private readonly string age = "351г. до н.э.";

        public void show()
        {
            Console.WriteLine($"{this.name}, {this.location} - {this.age}");
        }
    }
}
