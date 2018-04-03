using System;

namespace FactoryMethod
{
    public static class Client
    {

        public static void Example()
        {
            var requests = new IRequest[2];

            requests[0] = new RequestDataCreator().FactoryMethod();
            requests[1] = new RequestEventCreator().FactoryMethod();
        }

    }
}
