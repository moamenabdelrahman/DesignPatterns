namespace UIGenerator.Components.CheckBox
{
    public class LightCheckBox : ICheckBox
    {
        private string Description { get; set; }

        public LightCheckBox()
        {
            this.Description = "This is a Light-themed CheckBox!";
        }

        public void Display()
        {
            Console.WriteLine(this.Description);
        }
    }
}
