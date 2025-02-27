namespace UIGenerator.Components.Button
{
    public class LightButton : IButton
    {
        private string Description { get; set; }

        public LightButton()
        {
            this.Description = "This is a Light-themed button!";
        }

        public void Display()
        {
            Console.WriteLine(this.Description);
        }
    }
}
