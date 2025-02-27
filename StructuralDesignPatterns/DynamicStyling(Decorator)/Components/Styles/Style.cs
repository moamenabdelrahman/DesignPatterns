namespace DynamicStyling.Components.Styles
{
    public abstract class Style : IWidget
    {
        protected IWidget _wrappee { get; set; }

        protected Style(IWidget wrappee)
        {
            _wrappee = wrappee;
        }

        public abstract string Display();
    }
}
