namespace TaskScheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new MyApp();

            // Initial State
            app.DisplayState();

            Console.WriteLine("\n*****************************************\n");

            // Perform some tasks
            app.DoSomeTasks();
            app.DisplayState();

            Console.WriteLine("\n*****************************************\n");

            // Undo the last task
            app.Undo();
            app.DisplayState();
        }
    }
}
