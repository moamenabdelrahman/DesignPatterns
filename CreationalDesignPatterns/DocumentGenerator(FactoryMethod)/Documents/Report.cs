namespace DocumentGenerator.Documents
{
    public class Report: IDocument
    {
        private string Description { get; set; }

        public Report()
        {
            Description = "Report Content:\n\t- Title\n\t- Introduction\n\t- Body\n\t- Conclusion\n\t- References";
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
