using System;

namespace Strategy
{
    public static class Client
    {
        public static void Example()
        {

            var people = new Person[4];


            people[0] = new Person()
            {
                Name = "Foo",
                Age = 56

            };

            people[1] = new Person()
            {
                Name = "Bar",
                Age = 11

            };

            people[2] = new Person()
            {
                Name = "Bob",
                Age = 13

            };

            people[3] = new Person()
            {
                Name = "Gina",
                Age = 45

            };


            BubbleSort(people);

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

        }

        private static void BubbleSort<T>(ICompareStrategy<T>[] comparable)
        {
            ICompareStrategy<T> temp;

            for (int write = 0; write < comparable.Length; write++)
            {
                for (int sort = 0; sort < comparable.Length - 1; sort++)
                {
                    if (comparable[sort + 1].IsLess((T) comparable[sort]))
                    {
                        temp = comparable[sort + 1];
                        comparable[sort + 1] = comparable[sort];
                        comparable[sort] = temp;
                    }
                }
            }
        }
    }
}
