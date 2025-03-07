using System.Reflection.Metadata;
using TaskScheduler.Resources;
using TaskScheduler.Tasks;

namespace TaskScheduler
{
    public class MyApp
    {
        private TextDocument _document { get; set; } = new TextDocument();
        
        private DbRecord _record { get; set; } = new DbRecord("123", "some name", "Pending");
        
        private Resources.File _file { get; set; } = new Resources.File("report.txt");

        private List<ITask> _history { get; set; } = new List<ITask>();

        public void DoSomeTasks()
        {
            // Example tasks
            var addTextTask = new AddTextLine(_document, "Hello, World!");
            var updateRecordTask = new UpdateStatus(_record, "Completed");
            var renameFileTask = new RenameFile(_file, "final_report.txt");

            // Execute tasks
            addTextTask.Execute();
            LogTask(addTextTask);

            updateRecordTask.Execute();
            LogTask(updateRecordTask);

            renameFileTask.Execute();
            LogTask(renameFileTask);
        }

        public void LogTask(ITask task)
        {
            _history.Add(task);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var lastTask = _history[_history.Count - 1];
                lastTask.Undo();
                _history.RemoveAt(_history.Count - 1);
                Console.WriteLine($"Undo: {lastTask.GetType().Name}");
            }
            else
            {
                Console.WriteLine("No tasks to undo.");
            }
            Console.WriteLine();
        }

        public void DisplayState()
        {
            Console.WriteLine("Document Content:");
            Console.WriteLine(_document);
            Console.WriteLine();

            Console.WriteLine("Record Content:");
            Console.WriteLine(_record);
            Console.WriteLine();

            Console.WriteLine("File Content:");
            Console.WriteLine(_file);
            Console.WriteLine();
        }
    }
}
