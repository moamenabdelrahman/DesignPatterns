using TaskScheduler.Resources;

namespace TaskScheduler.Tasks
{
    public class UpdateStatus: ITask
    {
        private DbRecord _record { get; set; }

        private string _newStatus { get; set; }

        private string _backup { get; set; } = null!;

        public UpdateStatus(DbRecord record, string newStatus)
        {
            _record = record;
            _newStatus = newStatus;
        }

        public void Execute()
        {
            _backup = _record.status;
            _record.status = _newStatus;
        }

        public void Undo()
        {
            _record.status = _backup;
        }
    }
}
