using System;

namespace AbstractFactory
{
    public static class Client
    {
        public static void Example()
        {
            IEmailFactory emailFactory = new EmailFactory();

            IEmailFormat html = emailFactory.CreateHtmlFormat();

            html.CreateEmail("text");


            IEmailFormat rich = emailFactory.CreateRichFormat();

            rich.CreateEmail("text");


            IEmailFormat plain = emailFactory.CreatePlainFormat();

            plain.CreateEmail("text");
        }
    }
}
