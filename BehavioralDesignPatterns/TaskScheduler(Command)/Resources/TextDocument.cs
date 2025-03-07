using System.Text;

namespace TaskScheduler.Resources
{
    public class TextDocument
    {
        public List<string> lines { get; set; } = new List<string>();

        public override string ToString()
        {
            var builder = new StringBuilder();
            int i = 1;
            foreach (var line in lines)
                builder.AppendLine($"Line {i++}: {line}");
            
            return builder.ToString();
        }
    }
}
