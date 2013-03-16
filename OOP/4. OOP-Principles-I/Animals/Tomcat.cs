﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, byte age) : base(name, age, Gender.Male) { }
        public Tomcat(string name) : base(name, Gender.Male) { }
    }
}
