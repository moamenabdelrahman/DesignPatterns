namespace TextEditor.Character
{
    public class CharacterContext
    {
        private char _character { get; set; }
        private CharacterFormat _format { get; set; }

        public CharacterContext(CharacterFormat format, char character)
        {
            _format = format;
            _character = character;
        }

        public void TypeOnScreen()
        {
            _format.TypeOnScreen(_character);
        }

        public void SetCharacter(char character)
        {
            _character = character;
        }

        public void SetFormat(CharacterFormat format)
        {
            _format = format;
        }
    }
}
