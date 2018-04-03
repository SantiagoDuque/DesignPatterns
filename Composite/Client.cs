using System;

namespace Composite
{
    public static class Client
    {
        public static void Example()
        {
            IVisualComponent screen = new VisualContainer();

            screen.Add(new Icon());
            screen.Add(new Icon());

            IVisualComponent window = new VisualContainer();
            window.Add(new Icon());
            var icon = new Icon();
            window.Add(icon);
            screen.Add(window);
            window.Remove(icon);

            screen.Show();
        }
    }
}
