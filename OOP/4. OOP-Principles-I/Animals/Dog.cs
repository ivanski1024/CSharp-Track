using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, byte age, Gender sex) : base(name, age, sex) { }
        public Dog(string name, Gender sex) : base(name, 0, sex) { }

        public override string Sound()
        {
            return string.Format("Bau! I am {0} the dog. Bau!", this.Name);
        }
    }
}
