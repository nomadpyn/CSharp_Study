namespace wonders
{
    internal class Gardens_of_Babylon
    {
        private readonly string name = "Висячие сады Семирамиды";
        private readonly string location = "Вавилон";
        private readonly string age = "600г. до н.э.";

        public void show()
        {
            Console.WriteLine($"{this.name}, {this.location} - {this.age}");
        }
    }
}