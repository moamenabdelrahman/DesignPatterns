namespace FileSystem.Items
{
    public class Folder : IItem
    {
        private string _name { get; set; }
        private List<IItem> _items { get; set; } = new List<IItem>();

        public Folder(string name)
        {
            _name = name;
        }

        public string GetName() => _name;

        public int GetSize()
        {
            int size = 0;
            foreach (var item in _items) size += item.GetSize();
            return size;
        }

        public void AddItem(IItem item)
        {
            if (item is null || item.Equals(this)) throw new InvalidOperationException();

            _items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            _items.Remove(item);
        }

        public override string ToString() => $"Name: {_name}, Size: {GetSize()}KB";

        public void DisplayHeirarchy()
        {
            DFS(0);
        }

        private void DFS(int level)
        {
            string tab = "  ";
            for(int i=0; i<level; i++) Console.Write(tab);
            Console.WriteLine($"- {this}");

            foreach(var item in _items)
            {
                if(item is Folder x)
                    x.DFS(level + 1);
                else
                {
                    for (int i = 0; i < level+1; i++) Console.Write(tab);
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
}
