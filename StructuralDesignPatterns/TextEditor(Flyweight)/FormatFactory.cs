using TextEditor.Character;

namespace TextEditor
{
    public class FormatFactory
    {
        private List<CharacterFormat> _formats { get; set; } = new List<CharacterFormat>();

        public CharacterFormat GetFormat(string font, int size, string color)
        {
            var toFind = new CharacterFormat(font, size, color);
            var format = _formats.Find(f => f.Equals(toFind));
            
            if (format is not null) return format;

            _formats.Add(toFind);
            return toFind;
        }
    }
}
