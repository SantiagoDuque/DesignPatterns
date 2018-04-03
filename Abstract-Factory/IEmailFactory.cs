namespace AbstractFactory
{
    public interface IEmailFactory
    {
        IEmailFormat CreateHtmlFormat();
        IEmailFormat CreateRichFormat();
        IEmailFormat CreatePlainFormat();
    }
}