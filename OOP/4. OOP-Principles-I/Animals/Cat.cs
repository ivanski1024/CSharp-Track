using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public Cat(string name, byte age, Gender sex) : base(name, age, sex) { }
        public Cat(string name, Gender sex) : base(name, 0, sex) { }

        public override string Sound()
        {
            return string.Format("Miau! I am {0} the cat! Miau!", this.Name);
        }
    }
}
