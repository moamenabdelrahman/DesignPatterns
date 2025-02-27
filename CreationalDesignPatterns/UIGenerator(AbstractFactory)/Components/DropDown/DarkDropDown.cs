namespace UIGenerator.Components.DropDown
{
    public class DarkDropDown : IDropDown
    {
        private string Description { get; set; }

        public DarkDropDown()
        {
            this.Description = "This is a Dark-themed DropDown!";
        }

        public void Display()
        {
            Console.WriteLine(this.Description);
        }
    }
}
