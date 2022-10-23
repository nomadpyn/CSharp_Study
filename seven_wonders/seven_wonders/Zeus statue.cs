namespace wonders
{
    internal class Zeus_Statue
    {
        private readonly string name = "Статуя Зевса в Олимпии";
        private readonly string location = "Олимпия";
        private readonly string age = "435г. до н.э.";

        public void show()
        {
            Console.WriteLine($"{this.name}, {this.location} - {this.age}");
        }
    }
}