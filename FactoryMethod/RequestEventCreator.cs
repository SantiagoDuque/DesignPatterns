using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class RequestEventCreator : IRequestCreator
    {
        public IRequest FactoryMethod()
        {
            return new RequestEvent();
        }
    }
}
