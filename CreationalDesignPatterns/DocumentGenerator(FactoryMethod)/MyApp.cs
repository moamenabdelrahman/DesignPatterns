using DocumentGenerator.Documents;

namespace DocumentGenerator
{
    public class MyApp
    {
        public IDocument CreateDocument(DocType type)
        {
            switch (type)
            {
                case DocType.Resume:
                    return new Resume();
                case DocType.Report:
                    return new Report();
                case DocType.Letter:
                    return new Letter();
                default:
                    throw new InvalidOperationException();
            }
        }

        public void SomeOperation()
        {
            try
            {
                var doc = CreateDocument(DocType.Resume);
                Console.WriteLine(doc);

                Console.WriteLine("\n********************************\n");

                doc = CreateDocument(DocType.Letter);
                Console.WriteLine(doc);
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Please Choose a valid document type");
            }
        }
    }
}