using System;

namespace Composite
{
    internal class Icon : IVisualComponent
    {
        public void Add(IVisualComponent visualComponent)
        {
            Console.WriteLine("Cannot add to a Icon Visual Component");
        }

        public void Remove(IVisualComponent visualComponent)
        {
            Console.WriteLine("Cannot remove from a Icon Visual Component");
        }

        public void Show()
        {
            Console.WriteLine("Showing Icon Visual Component");
        }
    }
}