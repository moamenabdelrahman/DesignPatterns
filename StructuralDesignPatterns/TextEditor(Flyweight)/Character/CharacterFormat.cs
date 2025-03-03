namespace TextEditor.Character
{
    public class CharacterFormat
    {
        private string _font { get; set; }
        private int _size { get; set; }
        private string _color { get; set; }

        public CharacterFormat(string font, int size, string color)
        {
            _font = font;
            _size = size;
            _color = color;
        }

        public void TypeOnScreen(char character)
        {
            Console.WriteLine($"Typing the letter '{character}' with font:{_font}, size:{_size} and color:{_color}");
        }

        public override bool Equals(object? obj)
        {
            if(obj is CharacterFormat otherFormat)
            {
                return _font == otherFormat._font
                && _size == otherFormat._size
                && _color == otherFormat._color;
            }
            return false;
        }
    }
}
