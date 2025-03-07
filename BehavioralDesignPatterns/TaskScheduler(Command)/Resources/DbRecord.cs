namespace TaskScheduler.Resources
{
    public class DbRecord
    {
        public string id { get; set; }
        public string name { get; set; }
        public string status { get; set; }

        public DbRecord(string id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return $"ID: {id} | Name: {name} | Status: {status}";
        }
    }
}
