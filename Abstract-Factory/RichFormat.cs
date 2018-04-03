using System;

namespace AbstractFactory
{
    internal class RichFormat : IEmailFormat
    {
        public void CreateEmail(string text)
        {
            Console.WriteLine("Create Email with rich text format");
        }
    }
}