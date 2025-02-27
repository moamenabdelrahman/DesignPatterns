namespace FileSystem.Items
{
    public class File : IItem
    {
        public string _name { get; set; }
        private int _size { get; set; }

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public string GetName() => _name;

        public int GetSize() => _size;

        public override string ToString() => $"Name: {_name}, Size: {_size}KB";

        public void DisplayHeirarchy()
        {
            Console.WriteLine($"- {this}");
        }
    }
}
