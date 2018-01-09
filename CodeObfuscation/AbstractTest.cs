using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeObfuscation
{
    abstract class AbstractTest
    {
        abstract public void AbstractMethod();
    }

    class AbstractTestImplementation: AbstractTest
    {
        public override void AbstractMethod()
        {
            throw new NotImplementedException();
        }
    }
}
