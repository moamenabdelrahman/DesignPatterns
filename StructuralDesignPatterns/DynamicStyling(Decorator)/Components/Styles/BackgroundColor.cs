namespace DynamicStyling.Components.Styles
{
    public class BackgroundColor : Style
    {
        public BackgroundColor(IWidget wrappee): base(wrappee)
        {
        }

        public override string Display()
        {
            return $"BackgroundColor({_wrappee.Display()})";
        }
    }
}
