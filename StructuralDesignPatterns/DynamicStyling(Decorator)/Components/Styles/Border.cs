namespace DynamicStyling.Components.Styles
{
    public class Border : Style
    {
        public Border(IWidget wrappee): base(wrappee)
        {
        }

        public override string Display()
        {
            return $"Border({_wrappee.Display()})";
        }
    }
}
