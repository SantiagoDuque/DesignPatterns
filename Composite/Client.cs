using System;

namespace Composite
{
    public static class Client
    {
        public static void Example()
        {
            //IFileReader fileReaderCrypto = new FileReader();
            //fileReaderCrypto.Add(new CrytpoReader());


            //string text = fileReaderCrypto.Read();


            //IFileReader fileReaderCrytpoZip = new FileReader();
            //var crytpo = new Crytpo();
            //crytpo.Add(new Zipper());
            //fileReaderCrytpoZip.Add();


            //string text2 = fileReaderCrytpoZip.Read();


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
