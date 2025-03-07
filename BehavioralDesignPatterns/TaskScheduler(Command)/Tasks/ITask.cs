namespace TaskScheduler.Tasks
{
    public interface ITask
    {
        public void Execute();

        public void Undo();
    }
}
