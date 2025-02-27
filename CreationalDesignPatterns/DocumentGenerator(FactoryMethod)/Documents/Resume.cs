namespace DocumentGenerator.Documents
{
    public class Resume: IDocument
    {
        private string Description { get; set; }

        public Resume()
        {
            Description = "Resume Content:\n\t- Personal Information\n\t- Education\n\t- Work Experience\n\t- Skills";
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
