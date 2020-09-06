namespace Homework8_ConsoleApp.Task4
{
    public class Furniture : Item
    {
        public string Manufacture { get; set; }

        public Furniture(string manufacture, string name)
        {
            Manufacture = manufacture;
            Name = name;
        }
    }
}
