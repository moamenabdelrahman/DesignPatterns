namespace TaskScheduler.Resources
{
    public class File
    {
        public string name { get; set; }

        public File(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"File Name: {name}";
        }
    }
}
