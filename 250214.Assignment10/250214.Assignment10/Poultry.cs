namespace _250214.Assignment10
{
    public class Poultry
    {
        public int id {  get; set; }
        public string name { get; set; }

        public Poultry() { }

        public Poultry(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Speak()
        {
            Console.WriteLine("Sound.....");
        }

        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
        }
    }
}
