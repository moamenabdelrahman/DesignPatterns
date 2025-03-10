namespace DocumentVersioning.Mementos
{
    public class Memento : IMemento
    {
        private string _title { get; set; }

        private string _content { get; set; }

        public Memento(string title, string content)
        {
            _title = title;
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetTitle()
        {
            return _title;
        }
    }
}
