namespace TaskScheduler.Tasks
{
    public class RenameFile: ITask
    {
        private Resources.File _file { get; set; }

        private string _newName { get; set; }

        private string _backup { get; set; } = null!;

        public RenameFile(Resources.File file, string newName)
        {
            _file = file;
            _newName = newName;
        }

        public void Execute()
        {
            _backup = _file.name;
            _file.name = _newName;
        }

        public void Undo()
        {
            _file.name = _backup;
        }
    }
}
