using System;

namespace AbstractFactory
{
    internal class HtmlFormat : IEmailFormat
    {
        public void CreateEmail(string text)
        {
            Console.WriteLine("Create Email with HTML format");
        }
    }
}