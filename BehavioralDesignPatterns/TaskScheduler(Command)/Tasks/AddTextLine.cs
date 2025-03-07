using TaskScheduler.Resources;

namespace TaskScheduler.Tasks
{
    public class AddTextLine: ITask
    {
        private TextDocument _document { get; set; }

        private string _line { get; set; }

        public AddTextLine(TextDocument textDocument, string line)
        {
            _document = textDocument;
            _line = line;
        }

        public void Execute()
        {
            _document.lines.Add(_line);
        }

        public void Undo()
        {
            int cnt = _document.lines.Count;
            _document.lines.RemoveAt(cnt - 1);
        }
    }
}
