using DocumentVersioning.Mementos;

namespace DocumentVersioning.Originators
{
    public class Document: IOriginator
    {
        private string _title { get; set; }

        private string _content { get; set; }

        private List<IMemento> _history { get; set; } = new List<IMemento>();

        public Document(string title, string content = "")
        {
            _title = title;
            _content = content;
        }

        public void SaveVersion()
        {
            var memento = new Memento(_title, _content);
            _history.Add(memento);
        }

        public void Restore(IMemento memento)
        {
            SaveVersion();
            _title = memento.GetTitle();
            _content = memento.GetContent();
        }

        public void SetTitle(string title)
        {
            SaveVersion();
            _title = title;
        }

        public void AddTextAt(string text, int pos)
        {
            if (pos > _content.Length) return;
            SaveVersion();
            _content = _content.Insert(pos, text);
        }

        public void RemoveTextAt(int pos, int len)
        {
            if (pos >= _content.Length) return;
            SaveVersion();
            _content = _content.Remove(pos, len);
        }

        public void Undo()
        {
            if(!_history.Any())
            {
                Console.WriteLine("No changes to undo!");
                return;
            }

            var memento = _history[_history.Count - 1];
            Restore(memento);
            _history.RemoveAt(_history.Count - 1);
        }

        public override string ToString()
        {
            return $"Title: {_title}\nContent:\n\t{_content}";
        }
    }
}
