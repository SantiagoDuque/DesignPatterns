using System;

namespace AbstractFactory
{
    internal class PlainFormat : IEmailFormat
    {
        public void CreateEmail(string text)
        {
            Console.WriteLine("Create Email with plain text format");
        }
    }
}