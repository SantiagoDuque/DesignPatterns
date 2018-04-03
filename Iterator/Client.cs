using System;

namespace Iterator
{
    public static class Client
    {
        public static void Example()
        {

            var myList = new List<string>();

            myList.Add("hi");
            myList.Add("I");
            myList.Add("am");
            myList.Add("a");
            myList.Add("List");

            var iterator = myList.CreateIterator();
            while (iterator.Next())
            {
                Console.WriteLine((string) iterator.Actual());
            }

        }
    }
}
