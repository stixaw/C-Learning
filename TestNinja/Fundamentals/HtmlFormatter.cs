namespace TestNinja.Fundamentals
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            var result = $"<strong>{content}</strong>";
			return result;
        }
    }
}