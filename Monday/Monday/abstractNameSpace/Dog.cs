using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.abstractNameSapec
{
    class Dog
    {
        private string v1;
        private int v2;
        private bool v3;

        public Dog(string v1, int v2, bool v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal string ShowAnimalName()
        {
            Console.WriteLine("my animal name " );
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }
    }
}
