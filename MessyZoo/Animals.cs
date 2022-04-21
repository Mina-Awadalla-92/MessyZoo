﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessyZoo
{
    class Animal
    {
        public string name;
        public string age;
    }
    internal class Bear : Animal
    {
        public string name;
        public string age;
        public string color;
    }

    internal class Monkey : Animal
    {
        public string name;
        public string age;
        public string height;
    }

    internal class Parrot : Animal
    {
        public string name;
        public string age;
        public string wingspan;
    }
}
