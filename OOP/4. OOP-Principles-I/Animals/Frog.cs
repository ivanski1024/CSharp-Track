using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal
    {
        public Frog(string name, byte age, Gender sex) : base( name, age, sex) { }
        public Frog(string name, Gender sex) : base(name, 0, sex) { }

        public override string Sound()
        {
            return string.Format("Ribbit! I am {0} the frog! Ribbit!", this.Name);
        }
    }
}
