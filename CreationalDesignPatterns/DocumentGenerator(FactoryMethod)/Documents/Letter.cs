namespace DocumentGenerator.Documents
{
    public class Letter: IDocument
    {
        private string Description { get; set; }

        public Letter()
        {
            Description = "Letter Content:\n\t- Sender Address\n\t- Date\n\t- Recipient Address\n\t- Salutation\n\t- Body\n\t- Closing";
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
