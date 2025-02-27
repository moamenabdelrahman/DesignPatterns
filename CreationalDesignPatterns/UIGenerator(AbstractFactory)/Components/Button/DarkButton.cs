namespace UIGenerator.Components.Button
{
    public class DarkButton : IButton
    {
        private string Description { get; set; }

        public DarkButton()
        {
            this.Description = "This is a Dark-themed button!";
        }

        public void Display()
        {
            Console.WriteLine(this.Description);
        }
    }
}
