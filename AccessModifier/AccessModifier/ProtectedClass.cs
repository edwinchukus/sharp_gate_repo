using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class ProtectedClass : PublicClass
    {
        public void Test2()
        {
            ProtectedTest();
        }
    }
}
