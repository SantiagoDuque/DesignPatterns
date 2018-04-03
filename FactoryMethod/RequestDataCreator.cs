using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class RequestDataCreator : IRequestCreator
    {
        public IRequest FactoryMethod()
        {
            return new RequestData();
        }
    }
}
