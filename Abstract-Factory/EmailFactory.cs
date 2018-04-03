namespace AbstractFactory
{
    public class EmailFactory : IEmailFactory
    {
        public IEmailFormat CreateHtmlFormat()
        {
            return new HtmlFormat();
        }

        public IEmailFormat CreatePlainFormat()
        {
            return new PlainFormat();
        }

        public IEmailFormat CreateRichFormat()
        {
            return new RichFormat();
        }
    }
}