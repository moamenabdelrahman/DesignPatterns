namespace DynamicStyling.Components.Styles
{
    public class TextStyle: Style
    {
        public TextStyle(IWidget wrappee): base(wrappee)
        {
        }

        public override string Display()
        {
            return $"TextStyle({_wrappee.Display()})";
        }
    }
}
