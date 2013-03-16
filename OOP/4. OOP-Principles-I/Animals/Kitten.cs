using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, byte age) : base(name, age, Gender.Female) { }
        public Kitten(string name) : base(name, Gender.Female) { }

        public override string Sound()
        {
            return string.Format("Mew! I am {0}. I am a cute little kitten! Mew!", this.Name);
        }
    }
}
