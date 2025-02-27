namespace UIGenerator.Components.DropDown
{
    public class LightDropDown : IDropDown
    {
        private string Description { get; set; }

        public LightDropDown()
        {
            this.Description = "This is a Light-themed DropDown!";
        }

        public void Display()
        {
            Console.WriteLine(this.Description);
        }
    }
}
